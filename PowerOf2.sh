#!/bin/sh

echo "Enter a No:"
read N
r=1
echo "The power of till $N is: "
	for((i=1; i<=$N; i++))
do
	r=$(( 2*r ))
	echo "2*$i =$r"
done
