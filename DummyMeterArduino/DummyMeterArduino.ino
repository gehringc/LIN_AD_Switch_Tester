/*This program reads two AD inputs from the Steering Switch and 
* then sends the switch state data on serial for the Windows
* Form application to process and the user to access.
*/

int lkasInPin = A0;    // select the input pin for LKAS switch
int cruiseInPin = A1;   // select the input pin for cruise switch
int lkasValue = 0;  // variables to store the values
int cruiseValue = 0;
byte cruiseCode;
byte lkasCode;
byte startByte = 0xFF;
byte sendData1;
byte sendData2;
byte sendData3;

void setup() {
pinMode(lkasInPin, INPUT);
pinMode(cruiseInPin, INPUT);  
Serial.begin(4800);
while(!Serial); //wait for serial to initialie
}

void loop() {
  
  while(!Serial);
  // read the value from the inputs:
  lkasValue = analogRead(lkasInPin);
  cruiseValue = analogRead(cruiseInPin);
  
  if (lkasValue >= 870)
  {
   lkasCode = 0x00;
  }
  else if (lkasValue >= 717 && lkasValue < 870)
  {
    lkasCode = 0x01;
  } 
  else if (lkasValue >= 512 && lkasValue < 717)
  {
   lkasCode = 0x02;
  }
  else if (lkasValue >= 256 && lkasValue < 512)
  {
   lkasCode = 0x03;
  }
  else
  {
   lkasCode = 0x04;
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
  //output the data in a stream
  Serial.write(sendData1);
  Serial.write(sendData2);
  Serial.write(sendData3);
  
}
