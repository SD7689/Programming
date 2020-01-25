#!/bin/sh

declare -A matrix
echo "Enter number of rows"
read row
echo "Enter number of cols"
read col
L=$(($row*$col))
echo "Enter $L Values of the array:"
for((i=0; i<$row; i++))
do
	for((j=0; j<$col; j++))
	do
		read value
		matrix[$i,$j]=$value
	done
done
for((i=0; i<$row; i++))
do
	for((j=0; j<$col; j++))
	do
		printf $((matrix[$i,$j]))" "
	done
	echo " "
done
