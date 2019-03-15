#include <Wire.h>
#include <Adafruit_PWMServoDriver.h>
Adafruit_PWMServoDriver pwm1 = Adafruit_PWMServoDriver(0x40);
Adafruit_PWMServoDriver pwm2 = Adafruit_PWMServoDriver(0x41);
#define MIN_PULSE_WIDTH 650
#define MAX_PULSE_WIDTH 2350
#define DEFAULT_PULSE_WIDTH 1500
#define FREQUENCY 50
uint8_t servonum = 0;

  
      String b;
      boolean inputcomp = false;
      int p=0;
      int ang[16]; 

      void setup()
      {
      Serial.begin(9600);
      Serial.println("16 channel Servo test!");
      pwm1.begin();
      pwm1.setPWMFreq(FREQUENCY);

      for(int i=0;i<=15;i++)
      { pinMode(i,INPUT);
        }
        for(int i=0;i<16;i++)
      {pwm1.setPWM(i, 0, pulse_wide(90));
      delay(100);
      
      }
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
     Serial.println("Input Recieved");
    serialread();
    inputcomp = false;
    b="";
    inputservo();
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

