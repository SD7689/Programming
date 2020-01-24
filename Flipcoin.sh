#!/bin/sh
echo "Enter no. of times to flip a coin"
read F
H=0
T=0

for ((i=0; i<$F; i++))
do
	f=$(($((RANDOM%10))%2))
	if(($f == 1))
then
	T=$(($T+1))
else
	H=$(($H+1))
fi
done
	headPercentage=$(($(($H*100))/$F))
	tailPercentage=$(($(($T*100))/$F))
	echo "head Percentage is $headPercentage%"
	echo "tail Percentage is $tailPercentage%"
