#!/bin/sh

echo "Enter a Temperature:"
read T
echo "Enter a wind Speed:"
read V
if(( $T>1 || $V<120 || $V>3))
then
  Ws=$(echo "$T" "$V" | awk '{print 35.74+(0.6215*$1)+(0.4275*$1 - 35.75)*$2^0.16}')
echo $Ws
else
echo "Not in Range"
fi
