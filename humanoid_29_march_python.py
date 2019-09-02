#import Arduino
#import Wire
#import EEPROM
#import Adafruit_PWMServoDriver

MIN_PULSE_WIDTH = 140
MAX_PULSE_WIDTH = 590
DEFAULT_PULSE_WIDTH = 1500
FREQUENCY = 60

pwm1 = Adafruit_PWMServoDriver()

changeperdegree = []
firststart = True
inputcomp = False
analogPins=['A0','A1','A2','A3','A4','A5','A6','A7','A8','A9','A10','A11','A12','A13','A14','A15']
inipos="90,80,80,75,75,80,70,85,70,80,80,80,67,77,80,90;"
ang=[]
angread=[]
prevangle=[-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1]
iniposarray=[]
inianalogread=[]
finalanalogread=[]
finalangle=[]
servonum = 16

def setup():
	for i in range(16):
		pinMode(analogPins[i],INPUT);
	Serial.begin(9600)
	Serial.print("setting inipos")
	pwm1.begin()
	pwm1.swetPWMFreq(FREQUENCY)
	for i in range(16):
		pwm1.setPWM(i,0,0)
		delay(50)

def startup():
	for i in range(16):
		pwm1.setPWM(i,0,0)
		delay(50)
	getinitialpos()
	b = inipos
	Serial.println(b)
	serialread(b)
	servocallibration()
	inputservo(0)
	for i in range(16):
		inianalogread[i] = analogRead(analogPins[i])
		delay(100)
		Serial.print(inianalogread[i])
		if i!=15:
			Serial.print(",")
		else:
			Serial.print(";")

def serialread(input):
	a=0
	p=0
	comma=0
	for i in range(len(input)):
		if input[i]==',':
			comma = comma+1
	if comma==15:
		for i in range(len(input)):
			if input[i]==',':
				ang[a]=int(input[p:i])
				a+=1
				p=i+1
		ang[a]=int(input[p:len(input)-1])
		mirror()

def pulse_wide(angle):
	pass

def inputservo(a):
	msg=""
	if a==0:
		msg = "fast moving"
	else:
		msg = "slow moving"
	if prevangle[0]!=-1:
		for i in range(16):
			if ang[i]!=prevangle[i]:
				Serial.print(msg)
				Serial.print(i)
				Serial.print("-")
				Serial.println(ang[i])
				if ang[i]==-2 or ang[i]==182:
					pwm1.setPWM(i,0,0)
				else:
					pwm1.setPWM(i,0,pulsewidth(ang[i]))
				delay(a)
	else:
		for i in range(16):
			Serial.print(msg)
  			Serial.print(i)
  			Serial.print("-")
  			Serial.println(ang[i])
  			pwm1.setPWM(i, 0, pulseWidth(ang[i]))
			delay(a)

def resetInput():
	b=""
	inputcomp = False

def getservoread():
	detachh()
	for i in range(16):
		finalanalogread[i]=analogRead(analogPins[i])
		delay(100)
	for i in range(16):
		finalangle[i]=((finalanalogread[i]-inianalogread[i])/changeperdegree[i])-iniposarray[i]
		Serial.print(finalangle[i])
		if i!=15:
			Serial.print(",")
		else:
			Serial.print(";")

def detachh():
	prevangle[0]=-1
	for i in range(16):
		pwm1.setPWM(i,0,0)
		delay(50)
	Serial.println("servos detached")

def servocallibration():
	for i in range(16):
		pwm1.setPWM(i,0,pulsewidth(iniposarray[i]+5))
		delay(500)
		p=analogRead(i)
		Serial.print("servo "+str(i)+" - "+str(p)+" , ")
		pwm1.setPWM(i,0,pulsewidth(iniposarray[i]-5))
		delay(500)
		q = analogRead(i)
		Serial.print(str(q))
		changeperdegree[i]= float(p-q)/10.0
		pwm1.setPWM(i,0,pulsewidth(iniposarray[i]))
		Serial.print("--change per digree ->"+str(changeperdegree[i])+"--angle->")
		Serial.println(iniposarray[i])

def saveinipos():
	pass

def getinipos():
	z=""
	#read eeprom into z
	tparr = z.split(",")
	for i in range(16):
		iniposarray[i] = int(tparr[i])

def pulseWidth(angle):
	pass

def bend():
	for i in range(40):
    	pwm1.setPWM(3, 0, pulseWidth(ang[3]--))
    	pwm1.setPWM(8, 0, pulseWidth(ang[8]++))
    	delay(50)
  	prevangle[0] = -1
  	for i in range(40):
    	pwm1.setPWM(3, 0, pulseWidth(ang[3]++))
    	pwm1.setPWM(8, 0, pulseWidth(ang[8]--))
    	delay(50)
  	resetInput();

def mirror():
	for i in range(16):
		if i in [0,1,2,3,4,10,12,15]:
			ang[i] = 180 - ang[i]

def pushup():
	pushmax[16] = {84,100,84,128,92,93,88,93,119,97,84,100,87,94,77,85};
  	pushmin[16] = {84,100,84,120,92,93,88,93,111,97,84,100,87,94,33,41};
  	mintmax = 1000;
  	movespeed = 100;
  	times = 5;
  	diff[16];
   	for i in range(16):
    	ang[i] = pushmin[i];
    	diff[i] = pushmax[i]-pushmin[i];
  	mirror();
  	inputservo(100);
  	for p in range(times+1):
    	Serial.print("pushup no - ");
    	Serial.println(p);
  		for i in range(10):
       		for z in range(16):
        	if (pushmax[z] != pushmin[z]):
        		double a = diff[z]/10;
        		if(pushmin[z]>pushmax[z] or z in [0,1,2,3,4,10,12,15]):
          			ang[z]=ang[z]-a;
          			pwm1.setPWM(z, 0, pulseWidth(ang[z]));
        		else:
          			ang[z]=ang[z]+a;
          			pwm1.setPWM(z, 0, pulseWidth(ang[z]));
        		delay(10);
			delay(10);
		for i in range(10):
       		for z in range(16):
        	if (pushmax[z] != pushmin[z]):
        		double a = diff[z]/10;
        		if(pushmin[z]>pushmax[z] or z in [0,1,2,3,4,10,12,15]):
          			ang[z]=ang[z]+a;
          			pwm1.setPWM(z, 0, pulseWidth(ang[z]));
        		else:
        			ang[z]=ang[z]-a;
          			pwm1.setPWM(z, 0, pulseWidth(ang[z]));
        		delay(10);
			delay(10);
	resetInput();
	Serial.println("pushup done");

def loop():
	if(Serial.available()>0):
        char c=Serial.read();
        if(c != ';'):
          	b+=c;
       	else:
        	inputcomp = True;
    if(inputcomp):
       	Serial.println(b);
       	if(b.equals("getservoread")):	
       		getservoread();
       		resetInput();
       	elif (b.equals("calib")):
         	serialread(inipos);
         	servocallibration();
         	inputservo(0);
         	for i in range(16):
                inianalogread[i] = analogRead(analogPins[i]);
                delay(100);
        	resetInput();
       	elif(b.equals("pushup")):
        	pushup();
       	elif(b.equals("bend")):
       		bend();
       		Serial.println("bending");
       	elif(b.equals("start")):
       		startup();
       		Serial.println("start up done");
       	elif(b.equals("detach")):
        	prevangle[0]=-1;
        	for i in range(16):
     			pwm1.setPWM(i, 0, 0);
        		delay(50);
        	Serial.println("servos detached");#stopall the servos
        	resetInput();
       	elif(b.equals("saveinit")):
        	saveinitialpos();#save thr initial position
        	resetInput();
    else:
    	Serial.println("Servo Input Recieved");
    	tempinputpos = b;
    	serialread(b);
    	resetInput();#servo angle set
    	inputservo(0);
