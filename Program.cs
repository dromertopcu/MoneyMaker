using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter amount of money: ");
      double amount = Math.Ceiling(Convert.ToDouble(Console.ReadLine()));
      Console.WriteLine($"{amount} cents is equal to...");
      double gold = 10;
      double silver = 5;
      double goldCoins = Math.Floor(amount/gold);
      double silverCoins = Math.Floor((amount % gold)/silver);
      double remainder = Math.Floor(amount%silver);
      Console.WriteLine($"Gold coins: {goldCoins}\nSilver coins: {silverCoins}\nBronze coins: {remainder}");


      
    }
  }
}
