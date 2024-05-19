using loger;
using logic;
using System;


namespace ConsoleManager
{
    public class ColculatePrinter
    {
        public void Print(DivisionPrizeColculator colculator) {

            LoggerFactory.CreateFileLogger().Log("The message was displayed successfully");
            LoggerFactory.CreateConsoleLogger().Log("The message was displayed successfully");

            Console.WriteLine("Стоимость = " + colculator.Colculate());
        }
    }

    public class ColculatePrinterFactory
    {
        public static ColculatePrinter CreateColculatePrinter()
        {
            ColculatePrinter colculatePrinter = new ColculatePrinter();
            return colculatePrinter;
        }
    }
}