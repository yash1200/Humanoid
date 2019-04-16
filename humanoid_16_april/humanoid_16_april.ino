#include "Arduino.h"
#include <Wire.h>
#include <EEPROM.h>
#include <Adafruit_PWMServoDriver.h>0


#define MIN_PULSE_WIDTH 140
#define MAX_PULSE_WIDTH 590
#define DEFAULT_PULSE_WIDTH 1500
#define FREQUENCY 60


Adafruit_PWMServoDriver pwm1 = Adafruit_PWMServoDriver();


      double changeperdegree[16];
      boolean firststart= true;
      boolean inputcomp = false;
      uint8_t analogPins[]={A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13,A14,A15};
      String tempinputpos;
      String b,inipos="90,80,80,75,75,80,70,85,70,80,80,80,67,77,80,90;";
      int ang[16],angread[16];
      int prevangle[16]={-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};
      int iniposarray[16];
      int inianalogread[16];
      int finalanalogread[16];
      int finalangle[16];
      int servonum = 16;


void setup()
     {
       for(int i=0;i<16;i++)
           {
             pinMode(analogPins[i],INPUT); //defining analog pins
           }

       Serial.begin(9600);
       Serial.print("setting init pos");
       pwm1.begin();
       pwm1.setPWMFreq(FREQUENCY);

       for(int i=0;i<16;i++)
           {
             pwm1.setPWM(i, 0, 0);
             delay(50);
           }


      }
void startup()
      {
        for(int i=0;i<16;i++)
            {
             pwm1.setPWM(i, 0, 0);
             delay(50);
            }

        getinitialpos();
        b = inipos;
        Serial.println(b);
        serialread(b);
        servocallibration();
        inputservo(0);
        for(int i = 0;i<16;i++)
        {
          inianalogread[i] = analogRead(analogPins[i]);
          delay(100);
          Serial.print(inianalogread[i]);
          if (i!=15){
          Serial.print(",");
  }
  else
  {
    Serial.print(";");
  }
          
        }
        resetInput();
       }

     // to read angles
     void serialread(String input)////////////read incoming data for servo angles
     {
     int a=0;
     int p=0;
     int comma = 0;
     for(int i=0;i<input.length();i++)
     {
      if(input[i]==',')
     {
     comma++ ;
     }
     }
     if(comma==15)
     {
       for(int i=0;i<input.length();i++)
     {
     if(input[i]==',')
     {
     ang[a]=(input.substring(p,i)).toInt();
     a++;
     p=i+1;}
     }
     ang[a]=(input.substring(p,input.length())).toInt();
     mirror();/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     }


     }



int pulse_wide(int angle){
  int pulse = map(angle,0,180,140,590);
  return pulse;
}
void inputservo(int a)//////////////////////////////////////////////////////////////////for all servo startup
{
  String msg;
  if(a == 0)
  {
     msg = "fast moving";
  }
  else
  {
    msg = "slow moving";
  }

  if(prevangle[0] != -1){
  for(int i = 0 ; i<16 ; i++){
    if(ang[i]!=prevangle[i]){
  Serial.print(msg);
  Serial.print(i);
  Serial.print("-");
  Serial.println (ang[i]);
  if(ang[i]== -2||ang[i]== 182)
  {
    pwm1.setPWM(i, 0, 0);
  }else
  {
    pwm1.setPWM(i, 0, pulseWidth(ang[i]));
  }

  delay(a);
    }
  }
}else
{
  for(int i = 0 ; i<16 ; i++)
{
  Serial.print(msg);
  Serial.print(i);
  Serial.print("-");
  Serial.println (ang[i]);
  pwm1.setPWM(i, 0, pulseWidth(ang[i]));
  delay(a);
}


}
for(int i = 0 ;i<16;i++)
{
  if(ang[i]!=prevangle[i]){
  prevangle[i] = ang[i];}
}

}





void resetInput()
{
  b="";
  inputcomp = false;
}

void getservoread()
{
  detachh();
for(int i=0;i<16;i++)
{
 finalanalogread[i]= analogRead(analogPins[i]);
 delay(100);
}
 for(int i = 0;i<16;i++)
 {
  finalangle[i] = ((finalanalogread[i]-inianalogread[i])/changeperdegree[i])+iniposarray[i];
  Serial.print(finalangle[i]);
  if (i!=15){
    Serial.print(",");
  }
  else
  {
    Serial.print(";");
  }
 


}

}
void detachh()
{
  prevangle[0]=-1;
        for(int i=0;i<16;i++)
     {
        pwm1.setPWM(i, 0, 0);
        delay(50);
     }
        Serial.println("servos detached");////////////////stopall the servos
}

void servocallibration()
{
  for(int i=0;i<16;i++)
{
  pwm1.setPWM(i, 0, pulseWidth(iniposarray[i]+5));
  
  delay(500);
  int p=analogRead(i);
  Serial.print("Servo ");
  Serial.print(i);
  Serial.print(" - ");
  Serial.print(p);
  Serial.print(" , ");
  pwm1.setPWM(i, 0, pulseWidth(iniposarray[i]-5));
  
  delay(500);
  int q=analogRead(i);
  Serial.print(q);
  changeperdegree[i] = (double(p-q))/10.0;
  pwm1.setPWM(i, 0, pulseWidth(iniposarray[i]));
  Serial.print("--change per degree->");
  Serial.print(changeperdegree[i]);
  Serial.print("--angle->");
  Serial.println(iniposarray[i]);
}

}


void saveinitialpos()//////////////////saves the angles as initial position
{

  tempinputpos = tempinputpos + ";";
  Serial.println("saving initial pos");
  int len = tempinputpos.length();
  char charBuf[len];
  tempinputpos.toCharArray(charBuf,len+1);
  for(int i = 0 ;i<=len;i++)
  {
    Serial.print(tempinputpos[i]);
    EEPROM.write(i,tempinputpos[i]);
  }
  EEPROM.write(len+1,'\0');
  //EEPROM.commit();
  inipos = tempinputpos;
  tempinputpos = "";









}

void getinitialpos()
{
  int i = 0;
  inipos = "";
  while(true)
  {
    if(EEPROM.read(i)!='\0')
    {
      byte z = EEPROM.read(i);
      inipos+= char(z);
      //Serial.print(char(z));
    }
    else
    {
      break;
    }
    i++;
  }


  int a=0;
     int p=0;
     int comma = 0;
     for(int i=0;i<inipos.length();i++)
     {
      if(inipos[i]==',')
     {
     comma++ ;
     }
     }
     if(comma==15)
     {
       for(int i=0;i<inipos.length();i++)
     {
     if(inipos[i]==',')
     {
     iniposarray[a]=(inipos.substring(p,i)).toInt();
     a++;
     p=i+1;}
     }
     iniposarray[a]=(inipos.substring(p,inipos.length())).toInt();
     }


}

double pulseWidth(double angle)
{
double pulse_wide, analog_value;
pulse_wide = map(angle, 0, 180, MIN_PULSE_WIDTH, MAX_PULSE_WIDTH);
//analog_value = int(float(pulse_wide) / 1000000 * FREQUENCY * 4096);
//Serial.println(analog_value);
return pulse_wide;
}
void bend()
{
  for(int i = 0;i<=40 ;i++)
  {
    pwm1.setPWM(3, 0, pulseWidth(ang[3]--));
    pwm1.setPWM(8, 0, pulseWidth(ang[8]++));
    delay(50);
  }
  prevangle[0] = -1;
  for(int i = 0;i<=40 ;i++)
  {
    pwm1.setPWM(3, 0, pulseWidth(ang[3]++));
    pwm1.setPWM(8, 0, pulseWidth(ang[8]--));
    delay(50);
  }
  resetInput();

}
void mirror()
{
  for(int i = 0 ; i<16 ; i++)
  {
    if(i == 0||i == 1|| i == 2||i == 3||i == 4||i == 10||i == 12||i == 15)
    {
      ang[i] = 180-ang[i];
    }
  }
}
void pushup()
{
  int pushmax[16] = {84,100,84,128,92,93,88,93,119,97,84,100,87,94,77,85};
  int pushmin[16] = {84,100,84,120,92,93,88,93,111,97,84,100,87,94,33,41};
  int mintmax = 1000;
  int movespeed = 100;
  int times = 5;
  unsigned int diff[16];
   for(int i = 0;i<16; i++)
  {
    ang[i] = pushmin[i];
    diff[i] = pushmax[i]-pushmin[i];
  }
  mirror();

  inputservo(100);
  for(int p = 0 ;p<=times;p++)
  {

    Serial.print("pushup no - ");
    Serial.println(p);
  for(int i = 0;i<10;i++)
  {
       for(int z = 0 ; z<16;z++)
      {
        if(pushmax[z] != pushmin[z])
    {
        double a = diff[z]/10;
       // mirror();
        if(pushmin[z]>pushmax[z]||z == 0||z == 1|| z == 2||z == 3||z == 4||z == 10||z == 12||z == 15)
        {
          ang[z]=ang[z]-a;
          pwm1.setPWM(z, 0, pulseWidth(ang[z]));
        }
        else
        {
          ang[z]=ang[z]+a;
          pwm1.setPWM(z, 0, pulseWidth(ang[z]));
        }
        delay(10);

    }
      }

  delay(10);

}


for(int i = 0;i<10;i++)
  {
       for(int z = 0 ; z<16;z++)
      {
        if(pushmax[z] != pushmin[z])
    {
        double a = diff[z]/10;
        //mirror();
        if(pushmin[z]>pushmax[z]||z == 0||z == 1|| z == 2||z == 3||z == 4||z == 10||z == 12||z == 15)
        {
          ang[z]+=a;
          pwm1.setPWM(z, 0, pulseWidth(ang[z]));
        }
        else
        {
          ang[z]-=a;
          pwm1.setPWM(z, 0, pulseWidth(ang[z]));
        }
        delay(10);

    }
      }

  delay(10);

}


  }
resetInput();
Serial.println("pushup done");

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
       Serial.println(b);
       if(b.equals("getservoread"))
     {
       getservoread();
       resetInput();
     }
       else if(b.equals("calib"))
     {
         serialread(inipos);
         servocallibration();
         inputservo(0);
         for(int i = 0;i<16;i++)
                 {
                  inianalogread[i] = analogRead(analogPins[i]);
                  delay(100);
                 }
         resetInput();
     }
       else if(b.equals("pushup"))
     {
        pushup();
     }
       else if(b.equals("bend"))
     {
       bend();
       Serial.println("bending");
     }
       else if(b.equals("start"))
     {
       startup();
       Serial.println("start up done");
     }

       else if(b.equals("detach"))
     {
        prevangle[0]=-1;
        for(int i=0;i<16;i++)
     {
        pwm1.setPWM(i, 0, 0);
        delay(50);
     }
        Serial.println("servos detached");////////////////stopall the servos
        resetInput();
     }
        else if(b.equals("saveinit"))
      {
        saveinitialpos();////////////////////save thr initial position
        resetInput();
      }
      else{
     Serial.println("Servo Input Recieved");
    tempinputpos = b;
    serialread(b);
    resetInput();//////////////////////servo angle set
    inputservo(0);
    }
    }
  }







