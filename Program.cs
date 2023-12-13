namespace ATMCalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** ATM Calculator ***");
        var option = 1;
        while (option > 0) {
            Console.WriteLine("> Select an option to see payout combinations: (0: EXIT)");
            for (int i = 0; i < Atm.payouts.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Payout: " + Atm.payouts[i]);
            }
            option = Convert.ToInt32(Console.ReadLine());
            var result = Atm.GetCombinations(option);
            Console.WriteLine(result);
        }
    }    
}
