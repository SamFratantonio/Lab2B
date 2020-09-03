using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter A Number: ");
    int intA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Another Number: ");
    int intB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Sum = " + (intA + intB));
    Console.WriteLine("Difference = " + (intA - intB));
    Console.WriteLine("Product = " + (intA * intB));
    Console.WriteLine("Quotient = " + (intA / intB));
    Console.WriteLine("Remainder = " + (intA % intB));
  }
}