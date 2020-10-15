using System;

class MainClass {
  public static void Main (string[] args) {
    PromptUser();
  }

  public static void PromptUser() {
    Console.WriteLine ("Input the hours parked for the customer.");
    int hours = Int32.Parse(Console.ReadLine());
    Console.WriteLine("$" + CalculateCharges(hours));

    Console.WriteLine("Are there any more customers to input? (Y/N)");
    string answer = Console.ReadLine();

    if (answer.Equals("y", StringComparison.InvariantCultureIgnoreCase)) {
      PromptUser();
    } else if (answer.Equals("n", StringComparison.InvariantCultureIgnoreCase)) {
      return;
    } else {
      Console.WriteLine("Answer is not valid, cancelling operation.");
    }
  }

  public static double CalculateCharges(int hours) {
    if (hours <= 3) {
      return 2.00;
    }
    if (hours > 3 & hours < 24) {
      double d = ((hours - 3) * 0.50);
      return d;
    }
    if (hours >= 24) {
      return 10.00;
    }

    return 0.0;

  }
}