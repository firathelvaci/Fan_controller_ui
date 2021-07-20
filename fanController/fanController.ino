#include <RBDdimmer.h>
#include <Modbusino.h>
#include <EEPROM.h>

ModbusinoSlave modbusino_slave(1);
int16_t tab_reg[18];

dimmerLamp fan1(3);
dimmerLamp fan2(4);

#define  fan1_Start_Stop 0
#define fan1_manual_oto 1
#define fan2_Start_Stop 2
#define fan2_manual_oto 3
#define sensor1_set 4
#define sensor2_set 5
#define sensor1_voltaj  6
#define sensor2_voltaj  7
#define fan1_yuzde  8
#define fan2_yuzde  9
#define y1_sensor1_output 10
#define y2_sensor2_output 11
#define fan1_p  12
#define fan1_i  13
#define fan1_d  14
#define fan2_p  15
#define fan2_i  16
#define fan2_d  17



#define a0 0
#define a1 0.05
#define a2 0
#define a3 0
#define a4 0
#define a5 0

#define b0 0
#define b1 0.05
#define b2 0
#define b3 0
#define b4 0
#define b5 0

#define dt 0.01
float kp1=0;
float ki1=0;
float kd1=0;
float kp2=0;
float ki2=0;
float kd2=0;
float set_point1=0;
float set_point2=0;
float error1,total_error1=0;
float error2,total_error2=0;
float prev_error1=0, prev_error2=0;
float fan1_Otospeed=0,fan2_Otospeed=0;
float fan1_Manspeed=0,fan2_Manspeed=0;
float pidOut1,pidOut2;

float sensorValue1,sensorValue2;
double sen1,sen2;
void setup() {
    modbusino_slave.setup(115200);    
    //Serial.begin(115200);
    fan1.begin(NORMAL_MODE, OFF); 
    fan2.begin(NORMAL_MODE, OFF);
}

void loop(){
    modbusino_slave.loop(tab_reg, 18);
    if(tab_reg[fan1_Start_Stop]==0)   {
       Stop1();
      }
    else if(tab_reg[fan1_Start_Stop]==1)  {
      Start1();
    }   
	
	if(tab_reg[fan2_Start_Stop]==0){
       Stop2();
      }
    else if(tab_reg[fan2_Start_Stop]==1)  {
      Start2();
    }
	
	sensorValue1=analogRead(A0);
	sensorValue2=analogRead(A2);
  tab_reg[sensor1_voltaj]=sensorValue1;
  tab_reg[sensor2_voltaj]=sensorValue2;
  sen1=a5*pow(sensorValue1,5)+a4*pow(sensorValue1,4)+a3*pow(sensorValue1,3)+a2*pow(sensorValue1,2)+a1*sensorValue1+a0;
  sen2=b5*pow(sensorValue2,5)+b4*pow(sensorValue2,4)+b3*pow(sensorValue2,3)+b2*pow(sensorValue2,2)+b1*sensorValue2+b0;
  tab_reg[y1_sensor1_output]=sen1*10;
  tab_reg[y2_sensor2_output]=sen2*10;
 // Serial.println(sen1);
}
    

void Start1(){
  fan1.setState(ON);
      if(tab_reg[fan1_manual_oto]==0)
      {
       Manual1();
      }
    else if(tab_reg[fan1_manual_oto]==1)
    {
      Automatic1();
    }
  }
  
void Start2(){
  fan2.setState(ON);
      if(tab_reg[fan2_manual_oto]==0)
      {
       Manual2();
      }
    else if(tab_reg[fan2_manual_oto]==1)
    {
      Automatic2();
    }
  }

void Stop1(){
  fan1.setState(OFF);
  total_error1=0;
  prev_error1=0;
    fan1_Otospeed=0;
   fan1_Manspeed=tab_reg[fan1_yuzde]/10.0f;
  
  if(fan1_Manspeed>100){ fan1_Manspeed=100;  }
  if (fan1_Manspeed<0){ fan1_Manspeed=0; }
  tab_reg[fan1_yuzde]=fan1_Manspeed*10.0f;
  }
  
void Stop2(){
 fan2.setState(OFF);
 total_error2=0;
 prev_error2=0;
 fan2_Manspeed=tab_reg[fan2_yuzde]/10.0f;
  if(fan2_Manspeed>100){ fan2_Manspeed=100;  }
  else if (fan2_Manspeed<0){ fan2_Manspeed=0; }
  tab_reg[fan2_yuzde]=fan2_Manspeed*10.0f;
  fan2_Otospeed=0;
  }
  
void Manual1(){
  fan1_Manspeed=tab_reg[fan1_yuzde]/10.0f;
  
  if(fan1_Manspeed>100){ fan1_Manspeed=100;  }
  if (fan1_Manspeed<0){ fan1_Manspeed=0; }
  tab_reg[fan1_yuzde]=fan1_Manspeed*10.0f;
  fan1.setPower(fan1_Manspeed);
  }
  
void Manual2(){
  fan2_Manspeed=tab_reg[fan2_yuzde]/10.0f;
  
  if(fan2_Manspeed>100){ fan2_Manspeed=100;  }
  else if (fan2_Manspeed<0){ fan2_Manspeed=0; }
  tab_reg[fan2_yuzde]=fan2_Manspeed*10.0f;
  fan2.setPower(fan2_Manspeed);
  }

void Automatic1(){
  kp1=(float)tab_reg[fan1_p]/100.0f;
  ki1=(float)tab_reg[fan1_i]/100.0f;
  kd1=(float)tab_reg[fan1_d]/100.0f;
	set_point1=(float)tab_reg[sensor1_set]/10.0f;
	set_point2=(float)tab_reg[sensor2_set]/10.0f;
	

 
	 error1= set_point1-sen1;
      total_error1=total_error1+error1*dt;
         if(total_error1>1000){total_error1=1000;}
    if(total_error1<-1000){total_error1=-1000;}
      pidOut1=kp1*(error1)+(total_error1)*(ki1)+(prev_error1-error1)*(1/dt)*kd1;
      prev_error1=error1;
	fan1_Otospeed=fan1_Otospeed+pidOut1*dt;
  
  if(fan1_Otospeed>100){ fan1_Otospeed=100;  }
  else if (fan1_Otospeed<0){ fan1_Otospeed=0; }
  tab_reg[fan1_yuzde]=fan1_Otospeed*10.0f;
	fan1.setPower(tab_reg[fan1_yuzde]);
 
  }
  void Automatic2(){
  kp2=(float)tab_reg[fan2_p]/100.0f;
  ki2=(float)tab_reg[fan2_i]/100.0f;
  kd2=(float)tab_reg[fan2_d]/100.0f;
  set_point2=(float)tab_reg[sensor2_set]/10.0f;
	
		
	 error2= set_point2-sen2;
      total_error2=total_error2+error2*dt;
         if(total_error2>1000){total_error2=1000;}
    if(total_error2<-1000){total_error2=-1000;}
      pidOut2=kp2*(error2)+(total_error2)*(ki2)+(prev_error2-error2)*(1/dt)*kd2;
      prev_error2=error2;
      
	fan2_Otospeed=fan2_Otospeed+pidOut2*dt;
  
  if(fan2_Otospeed>100){ fan2_Otospeed=100;  }
  else if (fan2_Otospeed<0){ fan2_Otospeed=0; }
    tab_reg[fan2_yuzde]=fan2_Otospeed*10.0f;
  
	fan2.setPower(tab_reg[fan2_yuzde]);
 
  }

long EEPROMReadlong(long address) {
  long four = EEPROM.read(address);
  long three = EEPROM.read(address + 1);
  long two = EEPROM.read(address + 2);
  long one = EEPROM.read(address + 3);
 
  return ((four << 0) & 0xFF) + ((three << 8) & 0xFFFF) + ((two << 16) & 0xFFFFFF) + ((one << 24) & 0xFFFFFFFF);
}

void EEPROMWritelong(int address, long value) {
  byte four = (value & 0xFF);
  byte three = ((value >> 8) & 0xFF);
  byte two = ((value >> 16) & 0xFF);
  byte one = ((value >> 24) & 0xFF);
 
  EEPROM.write(address, four);
  EEPROM.write(address + 1, three);
  EEPROM.write(address + 2, two);
  EEPROM.write(address + 3, one);
}
