#!/bin/sh
echo Enter value of N
read N
CN=""
for((i=0;i<N;i++))
do
	s=$((RANDOM%10))
	if [[ $CN != *"$s"* ]]
	then
		CN=$CN$s
	else
		i=$((i-1))
	fi
done
echo Coupon Number is:
echo -e $CN
