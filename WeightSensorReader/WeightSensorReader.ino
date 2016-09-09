#include <HX711.h>

Hx711 scale(A2, A3);

void setup()
{
	Serial.begin(19200);
}

void loop()
{
	Serial.println(scale.getGram());
}