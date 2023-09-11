using System;

class Program {
  public static void Main (string[] args) {
    const int BASE_RATE = 200;
    const int HOURLY_RATE = 150;
    const int PER_MILE = 2;

    Console.WriteLine ("Enter hours for the move: ");
    double hours = double.Parse(Console.ReadLine());

    Console.WriteLine ("Enter miles for the move: ");
    double miles = double.Parse(Console.ReadLine());

    double totalPrice = BASE_RATE + (HOURLY_RATE * hours) + (PER_MILE * miles);
    Console.WriteLine("$" + totalPrice); 
    
  }
}