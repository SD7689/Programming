#!/bin/sh

echo "Enter a Harmonic no:"
read N
for((i=2; i<=$N; i++))
do
    c=$c" + "1/$i
done
echo 1/1$c
