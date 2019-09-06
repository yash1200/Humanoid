import bluetooth
import threading
from __future__ import division
import time
import sys
import Adafruit_PCA9685

inputcomp = False
servo_min = 140  # Min pulse length out of 4096
servo_max = 590  # Max pulse length out of 4096
prevangle=[-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1]


pwm = Adafruit_PCA9685.PCA9685()
pwm.set_pwm_freq(60)


def pulsewidth(value):
    global servo_min,servo_max 
    leftSpan = 180
    rightSpan = servo_max-servo_min
    valueScaled = float(value) / float(leftSpan)
    return servo_min + (valueScaled * rightSpan)

def mirror(l):
    r=[]
    for i in range(len(l)):
        if i in [0,1,2,3,4,10,12,15]:
            r.append(180-l[i])
	else:
            r.append(l[i])
    return r


def serialread(s):
    sl = s.split(",")
    s=[]
    for i in range(16):
        s.append(int(sl[i]))
    return self.mirror(s)


def serialprint(msg):
    global client_sock,connected
    if(connected):
        client_sock.send(msg)


def inputservo(ang,a):
    global pwm,prevangle
    msg=""
    if a==0:
	msg = "fast moving"
    else:
	msg = "slow moving"
    if self.prevangle[0]!=-1:
        for i in range(16):
	    if ang[i]!=prevangle[i]:
                serialprint(msg)
                serialprint(i)
		serialprint("-")
		serialprint(self.ang[i])
		if self.ang[i]==-2 or self.ang[i]==182:
		    pwm.set_pwm(i,0,0)
		else:
		    self.pwm1.setPWM(i,0,pulsewidth(ang[i]))
		    time.sleep(a)
	    else:
                for i in range(16):
		    serialprint(msg)
		    serialprint(i)
		    serialprint("-")
		    serialprint(ang[i])
		    pwm.set_pwm(i, 0, pulseWidth(ang[i]))
		    time.sleep(a)


    
   ## pwm.set_pwm(i, 0, 0)





while(1):
    server_sock=bluetooth.BluetoothSocket( bluetooth.RFCOMM )
    port = 1
    server_sock.bind(("",port))
    server_sock.listen(1)
    client_sock,address = server_sock.accept()
    print "Accepted connection from ",address
    connected = True
    while(1):
        try:
            if(connected):
                data = client_sock.recv(1024)
                if(data[-1] == ";"):
                    data = data[:-1]
                    inputcomp = True
                    print(data)
                if(inputcomp):
                    if(data=="start"):
                        print("start function call")
                    elif(data=="detach"):
                        print("detach function call")
                    elif(data=="saveinit"):
                        print("saveinit function call")
                    else :
                        ang[]=serialread(data)
                        inputservo(ang,0)
                        print("positions recieved")
        except:
            print("connection from used disconnected")
            connected = False
            break
        
            
        
