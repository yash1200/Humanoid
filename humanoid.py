from datetime import *
from Adafruit_PWMServoDriver import *
import bluetooth
import threading

class Server:
	def __init__(self):
		self.sock=bluetooth.BluetoothSocket( bluetooth.RFCOMM )
		self.sock.bind(("",1))
		self.sock.listen(1)
		self.data = ""
		self.connected = False

	def run_server(self):
		print('started')
		while True:
			print 'running'
			self.client,a=self.sock.accept()
			cThread=threading.Thread(target=self.handler,args=(c,a))
			cThread.deamon=True
			cThread.start()
			print(str(a[0])+':'+str(a[1])+'connected')
			self.connected = True

	def handler(self,c,a):
		try:
			while True: # HAS POTENTIAL TO CREATE PROBLEMS MAY ADD GARBAGE DATA
				self.data=data+c.recv(1024)
				print(data)
		except:
			c.close()

	def send(self,data):
		data = str(data)
		self.client.send(data)

	def read(self):
		retval = self.data
		self.data = ""
		return retval

	def connected(self):
		return self.connected

class Program:
	def __init__(self):
		self.MIN_PULSE_WIDTH = 140
		self.MAX_PULSE_WIDTH = 590
		self.DEFAULT_PULSE_WIDTH = 1500
		self.FREQUENCY = 60
		self.pwm1 = Adafruit_PWMServoDriver()
		self.inipos="90,80,80,75,75,80,70,85,70,80,80,80,67,77,80,90;"
		self.ang=[]
		self.prevangle=[-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1]
		self.comm = Server()
		self.b = ''
		self.comm.run_server()

	def RUN(self):
		self.b = self.comm.read()
		if(self.comm.connected()):
			self.comm.send(self.b)
			if (self.b=="calib"):
				self.ang = self.serialread(inipos);
				self.inputservo(0);
				self.b=''
			elif(self.b=="start"):
				startup();
				self.comm.send("start up done");
			elif(self.b.equals("detach")):
				self.prevangle[0]=-1;
				for i in range(16):
					self.pwm1.setPWM(i, 0, 0);
					delay(50);
				self.comm.send("servos detached");#stopall the servos
				self.b=''
		else:
			Serial.println("Servo Input Recieved");
			self.tempinputpos = self.b;
			self.serialread(self.b);
			self.b=''
			self.inputservo(0);

	def serialread(self,s):
		sl = s.split(",")
		s=[]
		for i in range(16):
			if i !=15:
				s.append(int(sl[i]))
			else:
				s.append(int(sl[i][:-2]))
		return self.mirror(s)

	def mirror(self,l):
		r=[]
		for i in range(len(l)):
			if i in [0,1,2,3,4,10,12,15]:
				r.append(180-l[i])
			else:
				r.append(l[i])
		return r

	def inputservo(a):
		msg=""
		if a==0:
			msg = "fast moving"
		else:
			msg = "slow moving"
		if self.prevangle[0]!=-1:
			for i in range(16):
				if self.ang[i]!=self.prevangle[i]:
					self.comm.send(msg)
					self.comm.send(i)
					self.comm.send("-")
					self.comm.send(self.ang[i])
					if self.ang[i]==-2 or self.ang[i]==182:
						self.pwm1.setPWM(i,0,0)
					else:
						self.pwm1.setPWM(i,0,self.pulsewidth(ang[i]))
					time.sleep(1)# WILL SLEEP FOR 1 SEC TODO CHANGE TO LESSER INTERVAL
		else:
			for i in range(16):
				self.comm.send(msg)
				self.comm.send(i)
				self.comm.send("-")
				self.comm.send(self.ang[i])
				self.pwm1.setPWM(i, 0, self.pulseWidth(self.ang[i]))
				time.sleep(1)

	def pulsewidth(self):
		pass

	def startup(self):
		for i in range(16):
			self.pwm1.setPWM(i,0,0)
			time.sleep(1)
		self.b = self.inipos
		self.comm.send(b)
		self.serialread(b)
		self.inputservo(0)

humanoid = Program()
while True:
	humanoid.RUN()
