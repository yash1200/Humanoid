#include <Wire.h>
#include <Adafruit_PWMServoDriver.h>
Adafruit_PWMServoDriver pwm1 = Adafruit_PWMServoDriver(0x40);
Adafruit_PWMServoDriver pwm2 = Adafruit_PWMServoDriver(0x41);
#define MIN_PULSE_WIDTH 650
#define MAX_PULSE_WIDTH 2350
#define DEFAULT_PULSE_WIDTH 1500
#define FREQUENCY 50
uint8_t servonum = 0;

  
      String b,inipos="90,80,80,75,75,80,70,85,70,80,80,80,67,77,80,90;";
      boolean inputcomp = false;
      int p=0;
      int ang[16],angread[16];
      int inipos2[16]={90,80,80,75,75,80,70,85,70,80,80,80,67,77,80,90};
      

      void setup()
      {
      Serial.begin(9600);
      Serial.print("16 channel Servo test!");
      pwm1.begin();
      pwm1.setPWMFreq(FREQUENCY);
      Serial.print("setting init pos");
      servocallibration();
      b = inipos;
      serialread();
      
      inputservo();
      resetInput();
      }
    
    
     void loop()
    {
     if(Serial.available()>0)
    {
     char c=Serial.read();
     if(c != ';')
    {
       b+=c;
    } 
    else
    {
      inputcomp = true;
    }
    }
   if(inputcomp)
    {
      if(b.equals("getservoread"))
      {getservoread();}
      
      if(b.equals("detach"))
      {
        for(int i=0;i<16;i++)
        {
          pwm1.setPWM(i, 0, 0);
        }
        Serial.println("servos detached");
        resetInput();
        
      }
      else{
     Serial.println("Input Recieved");
    serialread();
    resetInput();
    inputservo();
    }
    }
  }
     // to read angles
     void serialread()
     { 
     int a=0;
     for(int i=0;i<b.length();i++)
     {
     if(b[i]==',')
     { 
     ang[a]=(b.substring(p,i)).toInt();
     a++;
     p=i+1;}
     }
     ang[a]=(b.substring(p,b.length())).toInt();
     }
        
    
     
int pulse_wide(int angle){
  int pulse = map(angle,0,180,140,580);
  return pulse;
}
void inputservo()
{ for(int i = 0 ; i<16 ; i++)
{
  pwm1.setPWM(i, 0, pulse_wide(ang[i]));
}
}
void resetInput()
{
  b="";
  inputcomp = false;
}

void getservoread()
{
for(int i=0;i<16;i++)
{
 angread[i]= analogRead('A'+i);
 Serial.print(angread[i]);
 Serial.print(" "); 
}
Serial.print(";");
} 

void servocallibration()
{ for(int i=0;i<16;i++)
{ 
  pwm1.setPWM(i, 0, pulse_wide(inipos2[i]+5));
  int p=analogRead('A'+i);
  pwm1.setPWM(i, 0, pulse_wide(inipos2[i]-5));
  int q=analogRead('A'+i);
  double changeperdegree= (p-q)/2;
  pwm1.setPWM(i, 0, pulse_wide(inipos2[i]));
}
  
  }
