using System;
class SalaryBonus {
  static void Main() {
      string retry;
      do 
      {
    Console.Write("Enter your salary: ");
    double salary = double.Parse(Console.ReadLine());
    Console.Write("Enter your years of experience: ");
    int yearsOfExperience = int.Parse(Console.ReadLine());

    double bonus;
    if (yearsOfExperience >= 10)
        bonus = salary * 0.2;
    else
        bonus = salary * 0.1;

    Console.WriteLine($"Your salary bonus is: " + bonus);
    
    Console.Write("Do you want to do it again?: ");
    retry = Console.ReadLine().ToLower();
    
      } while (retry == "yes");
      Console.WriteLine("Thank you! Have a Great Day!");
  }
}