/*
Callen Thomason
9/12/2026
Mini Challenge #7 - Reverse it
I used a series of do while loops, while loops, and if statments to create a program that reverse strings and ints.
I was able to use a while loop and if statement combination to check if a user input a usable number. 
If they did not it prompts them to input a new value, and only breaks the loop once they input a number value. 
I tried figuring out TryParse and I somewhat understand how it works. 
I used for loops to reverse the words. You start at the end of the index and work packwords saving each letter onto a new variable. 

Peer Reviewer:
Review: 
*/ 

Console.Clear(); 
Console.WriteLine("Welcome to reverse simulator");
char complete = 'N'; 
do
{
Console.Write("Do you want to do int or string?"); 
String ans = Console.ReadLine().ToLower(); 

while(ans != "string" && ans != "int")
    {
        Console.Write("Wrong, Please input int or string: ");
        ans = Console.ReadLine().ToLower(); 
    }

    if(ans == "int")
    {
        Console.Write("Please enter a number: ");
        String num = Console.ReadLine(); 
      
       bool isNum = true;
       while(isNum){
       if(int.TryParse(num, out int intValue))
        {
            isNum = false; 
            break; 
        }
        Console.Write("Incorrect, please input a number: ");
            num = Console.ReadLine(); 
        
        }
        string newNum = ""; 
        for(int i = num.Length - 1; i >= 0; i--)
        {
             newNum += num[i]; 
        } 
        int realOg = Convert.ToInt32(num); 
        int realNew = Convert.ToInt32(newNum); 
        Console.WriteLine($" Your orignal number is:  {realOg}"); 
        Console.WriteLine($" Your reversed number is:  {realNew}"); 
    } //end if for numbers
    else
    {
        Console.Write("Please enter a word: ");
        string word = Console.ReadLine(); 
        string newWord = ""; 
         for(int i = word.Length - 1; i >= 0; i--)
        {
             newWord += word[i]; 
        } 
         Console.WriteLine($" Your orignal word is:  {word}"); 
        Console.WriteLine($" Your reversed number is:  {newWord}"); 


    }//end else

    Console.Write("Do you want to play again? Y / N"); 
    String ansTwo = Console.ReadLine().ToUpper(); 
    complete = ansTwo[0]; 

    while(complete != 'Y' && complete != 'N')
    {
        Console.Write("Please input Y or N: "); 
        ans = Console.ReadLine().ToUpper(); 
        complete = ansTwo[0];
    }//end while
   
    
}while(complete != 'N');

Console.Write("Thank you for playing"); 