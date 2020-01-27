#!/bin/sh 


echo "Enter value of a, b , c = "
read a
read b
read c
if((a != 0))
then 	
	D=$(( ($b)*($b)-4*($a)*($c)))
echo $D
else
	echo "Quadratic equation not possible"
fi
	if(($D >= 0))
	then
	T=$(awk -v x=$D 'BEGIN{print sqrt(x)}')	
	X1=$(( (-b+$T)/(2*$a) ))
	X2=$(($((-$b-$T))/$((2*$a))))
	echo $X1
	echo $X2
else
	echo "Roots are not possible" 
fi        
