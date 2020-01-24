#!/bin/sh

string="Hello Username, How are you?"
echo Enter a name to replace
read replace
echo ${string//Username/$replace} 
