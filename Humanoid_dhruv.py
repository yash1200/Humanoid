import bluetooth
import threading
#from __future__ import division
import time
import sys
import Adafruit_PCA9685
import pymssql
import MySQLdb



inputcomp = False
servo_min = 140  # Min pulse length out of 4096
servo_max = 590  # Max pulse length out of 4096
prevangle=[-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1]
inipos="90,90,90,90,90,90,90,90,90,90,90,90,90,90,90,90;"
ang=[]



pwm = Adafruit_PCA9685.PCA9685()
pwm.set_pwm_freq(60)


def getinipos():
    
    db = MySQLdb.connect("localhost", "sa", "123hex", "Humanoid")
    curs=db.cursor()
    curs.execute("Select inipos from init_pos;")
    res=curs.fetchall()
    for row in res:
        print("reading init pos")
        print(row[0])
        inipos = row[0]
    curs.close()
    db.close()
    return inipos

def saveinipos(pos):
    global inipos
    db = MySQLdb.connect("localhost", "sa", "123hex", "Humanoid")
    curs=db.cursor()
    curs.execute("update init_pos set inipos = '{}' where id = 0; select '1' as command")
    res=curs.fetchall()
    for row in res:
        if(row[0]=="1"):
            print("save success")
    curs.close()
    db.close()
    


def pulsewidth(value):
    global servo_min,servo_max 
    leftSpan = 180
    rightSpan = servo_max-servo_min
    valueScaled = float(value) / float(leftSpan)
    return int(servo_min + (valueScaled * rightSpan))

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
        #print(s1[i])
        s.append(int(sl[i]))
    return mirror(s)


def serialprint(msg):
    global client_sock,connected
    msg=str(msg)
    print(msg)
    if(connected):
        client_sock.send(msg)


def inputservo(ang,a):
    global pwm,prevangle
    msg=""
    if a==0:
	msg = "fast moving"
    else:
	msg = "slow moving"
    if prevangle[0]!=-1:
        for i in range(16):
	    if ang[i]!=prevangle[i]:
                serialprint(msg+" "+str(i)+"-"+str(ang[i]))
                prevangle[i]=ang[i]
		if ang[i]==-2 or ang[i]==182:
		    pwm.set_pwm(i,0,0)
		else:
		    self.pwm1.setPWM(i,0,pulsewidth(ang[i]))
		    time.sleep(a)
    else:
        for i in range(16):
	    serialprint(msg+" "+str(i)+"-"+str(ang[i]))
	    pwm.set_pwm(i, 0, pulsewidth(ang[i]))
	    time.sleep(a)


    
   ## pwm.set_pwm(i, 0, 0)


def detach():
    global pwm
    for i in range(16):
        pwm.set_pwm(i, 0, 0)
        time.sleep(0.01)


def startup():
    global ang,pwm
    detach()
    inipos = getinipos()
    inipos=inipos[:-1]
    ang=serialread(inipos)
    inputservo(ang,0.1)



    

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
                    #print(data)
                if(inputcomp):
                    if(data=="start"):
                        #print("start function call")
                        startup()
                        #serialprint("startup")
                    elif(data=="detach"):
                        detach()
                        serialprint("detach")
                        #print("detach function call")
                    elif(data=="saveinit"):
                        setinitpos(data+";")
                        #print("saveinit function call")
                    else :
                        ang=serialread(data)
                        print("positions recieved")
                        inputservo(ang,0)
                        
        
        
        except(bluetooth.btcommon.BluetoothError):
            print("connection from user disconnected")
            connected = False
            break
        except(KeyboardInterrupt, SystemExit):
            print("detaching servos")
            detach()
            sys.exit()
        
            
        
