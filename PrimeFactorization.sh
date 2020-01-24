#!/bin/sh
echo "Enter a no:"
read num
for(( i=2; i<=num; i++));do
while [ $((num%$i)) == 0 ];do
	echo "Prime factor are: "$i
	num=$((num/$i))
	done
done
