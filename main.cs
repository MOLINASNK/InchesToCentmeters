using System;

class Program {
  
  const double CentimetersPerInch = 2.54;
  
  public static void Main (string[] args) {
    
    double inches = 15994 ;
    double centimeters = inches * CentimetersPerInch;
    Console.WriteLine("{0} inches is {1} centimeters", inches, centimeters);
  }
}
    
  
