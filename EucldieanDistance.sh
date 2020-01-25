#!/bin/sh
echo "Enter a Value of X"
read x
echo "Enter value of Y"
read y
x1=$((x*x))
y1=$((y*y))
dist=$(($x1+$y1))
a=$(awk -v x=$dist 'BEGIN{print sqrt(x)}')
echo $a

