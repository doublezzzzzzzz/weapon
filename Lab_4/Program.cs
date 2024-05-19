using ConsoleManager;
using logic;

//запускающий проект

class Program
{
    static void Main(string[] args)
    {

        ColculatePrinterFactory
            .CreateColculatePrinter()
            .Print(DivisionPrizeColculatorFactory.CreateDivisionPrizeColculator(DivisionFactory.CreateDivision()));
    }
}
