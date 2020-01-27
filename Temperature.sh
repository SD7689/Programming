#!/bin/sh

echo "Enter a temperature in Celcius:"
read C

Celsius=$((C*9/5+32))
echo "Tempetaure in Fahrenheit :"$Celsius

echo "Enter a temperature in Fahrenheit:"
read F

Fahrenheit=$(($((F-32))*5/9))
echo "Temperature in Celcius :"$Fahrenheit
