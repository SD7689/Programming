
#!/bin/sh

start=$SECONDS
echo "Enter your name!! Time Start = "$start 
read name;


duration=$(( SECONDS - start ))
echo "Time taken is: "$duration
