using System;


namespace MyPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Power pwr1;

            try
            {
                pwr1 = new Power();

                pwr1.PowerCalc(5, -3);
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a.Message);
                Console.Read();
                
            }
            
        }
    }
}
