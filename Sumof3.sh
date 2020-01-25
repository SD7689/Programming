#!/bin/bash
declare -A arr
echo "Enter Length of array"
read len
echo "Enter value of integers:"
for((i=0;i<len;i++))
do
	read val
	arr[$i]=$val
done
for((i=0;i<len-2;i++))
do
	for((j=i+1;j<len-1;j++))
	do
		for((k=i+2; k<len; k++))
		do
			if(($((arr[$i]+arr[$j]+arr[$k]))==0))
			then
				echo "$((arr[$i])) $((arr[$j])) $((arr[$k]))"
			fi
		done
	done
done 
	
