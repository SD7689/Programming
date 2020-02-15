#!/bin/sh

FirstName()
{
echo "---------Enter your FirstName---------"
read first
re="^[A-Za-z]*$"
	if [[ $first =~ $re ]];
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
	re="^[A-Za-z]*$"
	if [[ $Last =~ $re ]];
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
	re="^([A-Za-z0-9_\-\+]+)@"
	if [[ $email =~ $re ]];
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
	e="^([A-Za-z0-9_\-\.\+]+)@"
	if [[ $password =~ $e ]];
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
	r="^[0-9]*$"
	if [[ $Num =~ $r ]];
	then
		echo "Valid Mobile No."
	else
		echo "InValid Mobile No."
		MobileNo
	fi
}
MobileNo
