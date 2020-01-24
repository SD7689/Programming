#!/bin/sh

echo "Enter a Year:"
read Y
if(($Y%400== 0 || $Y%4 == 0 && $Y%100 == 0))
then
	echo "Is a Leap Year"
else
	echo "Is not a Leap Year"
fi
