using System;

class Program {
  public static void Main (string[] args) {
    const double CentimetersPerInch = 2.54;
    Console.WriteLine("Enter Number of Inches: ");
    double inches = Convert.ToDouble(Console.ReadLine());
    double centimeters = inches * CentimetersPerInch;
    Console.WriteLine ("{0} Inches is {1} centimeters", inches, centimeters);
  }
}