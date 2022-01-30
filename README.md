# Characters-In-Order
A Windows Form App written in C# in .NET framework. An app written to check if a string input entered by the user is "in order". We define an input to be in order if the chars of the input: 

    1. are alphabetic letters, lower case or upper case. 
    2. any two neighboring letters (regardless of case) are in order, for example, ‘c’ and ‘k’ are in order but ‘s’ and ‘b’ is not in order   
       because ‘c’ is less than ‘k’ and ‘s’ is greater than ‘b’, considering their ASCII values. 
    3. if two neighboring letters are same, they are considered in order.
