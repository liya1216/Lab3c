using System;

class MainClass {
  public static void Main (string[] args) {
    int i =1;
    var primenum = true;
    Console.WriteLine ("Enter the number you would like to check "); // Checking prime number or not
    int n = Convert.ToInt32(Console.ReadLine());
  for (i=2; i <= n/2; i++)
  {
    if (n%i==0) 
    {
     primenum= false;
     break;
    }
  }
  if(primenum)
  {
    Console.WriteLine ("The number is prime number");
  }
  else 
  {
   Console.WriteLine("The number is not prime number");
  }
  }
}