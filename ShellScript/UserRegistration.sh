#!/bin/sh

FirstName()
{
echo "---------Enter your FirstName---------"
read first
	rFirst="^[A-Za-z]*$"
	if [[ $first =~ $rFirst ]];
	then
		echo "Valid Name"
	else
		echo "Invalid Name"
		FirstName
	fi
}
FirstName

LastName()
{
echo "---------Enter your LastName----------"
read Last
	rlast="^[A-Za-z]*$"
	if [[ $Last =~ $rlast ]];
	then
        	echo "Valid Name"
	else
        	echo "Invalid Name"
		LastName
	fi
}
LastName

Email()
{
echo "-------Enter your Email Address-------"
read email
	remail="^([A-Za-z0-9_\-\+]+)@"
	if [[ $email =~ $remail ]];
	then
        	echo "Valid Email Id"
	else
        	echo "Invalid Email Id"
		Email
	fi
}
Email

Password()
{
echo "---------Enter your Password----------"
read password
	rpass="^([A-Za-z0-9_\-\.\+]+)"
	if [[ $password =~ $rpass ]];
	then
        	echo "Valid Password"
	else
        	echo "Invalid password"
		Password
	fi
}
Password

MobileNo()
{
echo "--------Enter Your Mobile No.---------"
read Num
	rNo="^[0-9]{10}$"
	if [[ $Num =~ $rNo ]];
	then
		echo "Valid Mobile No."
	else
		echo "InValid Mobile No."
		MobileNo
	fi
}
MobileNo
