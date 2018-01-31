

int lkasInPin = A0;    // select the input pin for LKAS
int cruiseInPin = A1;   // select the input pin for cruise
int lkasValue = 0;  // variables to store the values
int cruiseValue = 0;
byte lkasID = 0x10;
byte cruiseID = 0x20;
byte cruiseCode;
byte lkasCode;
byte startByte = 0xFF;
byte sendData1;
byte sendData2;
byte sendData3;
int outCheck;

void setup() {
pinMode(lkasInPin, INPUT);
pinMode(cruiseInPin, INPUT);  
Serial.begin(4800);
while(!Serial);
}

void loop() {
  
  while(!Serial);
  // read the value from the inputs:
  lkasValue = analogRead(lkasInPin);
  cruiseValue = analogRead(cruiseInPin);
  
  if (lkasValue >= 870)
  {
   lkasCode = 0x00;
   outCheck = 0;
  }
  else if (lkasValue >= 717 && lkasValue < 870)
  {
    lkasCode = 0x01;
    outCheck = 1;
  } 
  else if (lkasValue >= 512 && lkasValue < 717)
  {
   lkasCode = 0x02;
   outCheck = 2;
  }
  else if (lkasValue >= 256 && lkasValue < 512)
  {
   lkasCode = 0x03;
   outCheck = 3;
  }
  else
  {
   lkasCode = 0x04;
   outCheck = 4;  
  }
  
  if (cruiseValue >= 800)
  {
    cruiseCode = 0x00;
    
  }
  else if (cruiseValue >= 350 && cruiseValue < 880)
  {
    cruiseCode = 0x01;
  }
  else 
  {
    cruiseCode = 0x02;
  }
  sendData1 = startByte;
  sendData2 = lkasCode;
  sendData3 = cruiseCode; 
 Serial.write(sendData1);
 Serial.write(sendData2);
 Serial.write(sendData3);
 
 //Serial.println(sendData[0]);
  //Serial.println(sendData[1]);
  // Serial.println(sendData[2]);  
}
