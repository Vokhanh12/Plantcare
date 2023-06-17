#include <SoftwareSerial.h>
SoftwareSerial ArduinoUno(3,2);

void setup(){
	
	Serial.begin(9600);
	ArduinoUno.begin(4800);

}

void loop(){
	
	while(ArduinoUno.available()>0){
	float val = ArduinoUno.parseFloat();
	if(ArduinoUno.read()== '\n'){
	Serial.println(val);
	}
}
delay(30);
}