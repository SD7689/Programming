
#!/bin/sh

echo "Enter no. of times to play:"
read N
echo "Enter amount of Money You have:"
read Stake
echo "Enter a Desired Goal:"
read Goal

bets=0
wins=0


for((i=0; i<$N; i++))
do	
        cash=$Stake
	while (( $cash>0 && $cash<$Goal))
	do
        bets=$(($bets+1))
	f=$(($RANDOM%2))
	if(($f<1))
	then
	cash=$((cash+1))
        #wins=$(($wins+1))
	else
	cash=$((cash-1))
	fi
        done
		if(($cash==$Goal))
		then
		wins=$((wins+1))
	fi
done
echo " "
echo  $wins "wins out of:"$N
echo "Percentage of game won = " $((100*(wins)/N))
echo "Total no of bets: " $N "Games = " $bets

