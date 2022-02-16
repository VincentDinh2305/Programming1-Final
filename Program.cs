using System;
/*
 ********************************************************************************
 * Programming I -  Test 3 (Version E)
 * Name: DINH HOANG VIET PHUONG
 * Date: April 10, 2021
 * Student #: 301123263
 * Test 3 - 25% of final grade
 * 
 ******************************************************************************** 
 */
namespace VersionE
{
    internal class VerE
    {
        public VerE()
        {
        }
        #region Question 1
        private static void DisplayMenu()
        {
            Console.WriteLine(">---------- DINH - HOANG - VIET - PHUONG ------------<");
            Console.WriteLine("|------------------Programming I---------------------|");
            Console.WriteLine("|           1. Working with array of doubles         |");
            Console.WriteLine("|           2. Working with Hyperbolic functions     |");
            Console.WriteLine("|           3. Calculate Kinetic Energy              |");
            Console.WriteLine("|           4. Calculate Federal Tax                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           X. To exit the program                   |");
            Console.WriteLine("|----------------------------------------------------|");
            Console.Write("Press the number corresponding to your choice-> ");
        }
        #endregion
        #region Question 2
        private static void Main(string[] args)
        {
            string choice;
            do
            {
                VerE.DisplayMenu();
                choice = Console.ReadLine();
                string upper = choice.ToUpper();
                if (upper == "1")
                {
                    VerE.DemoQuestion3();
                }
                else if (upper == "2")
                {
                    VerE.DemoQuestion4();
                }
                else if (upper == "3")
                {
                    VerE.DemoQuestion5();
                }
                else if (upper == "4")
                {
                    VerE.DemoQuestion6();
                }
                else if (upper != "X")
                {
                    Console.WriteLine("Error: Invalid input.");
                }
            }
            while (choice.ToUpper() != "X");
        }
        #endregion
        #region Question 3
        private static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            Console.WriteLine();
            double[] num3 = VerE.GenerateDoubleArray(32);
            VerE.DisplayDoubleArray(num3);
            Console.WriteLine();
            VerE.DisplayLargeDoublesOnly(num3);
            Console.WriteLine();
            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        private static void DisplayLargeDoublesOnly(double[] threeA)
        {
            for (int x = 0; x < threeA.Length; x++)
            {
                if (threeA[x] > 0.6)
                {
                    Console.Write(string.Format($"{threeA[x],6:f2}"));
                }               
            }
        }
        private static void DisplayDoubleArray(double[] threeB)
        {
            foreach (var x in threeB)
            {
                Console.Write(string.Format($"{x,6:f2}"));
            }
        }
        private static double[] GenerateDoubleArray(int threeC)
        {
            Random randomAlp = new Random();
            double[] num = new double[threeC];
            for (int x = 0; x < threeC; x++)
            {
                num[x] = randomAlp.NextDouble();
            }
            return num;
        }
        #endregion
        #region Question 4
        private static void DemoQuestion4()
        {
            double sinG, cosH, tanH, anG = 0, num = 0.15;
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            Console.WriteLine("  angle     sinh     cosh     tanh");
            for (int x = 0; x < 5; x++)
            {
                VerE.HyperBolic(anG, out sinG, out cosH, out tanH);
                Console.WriteLine($"{anG,8:f4} {sinG,9:f4} {cosH,8:f4} {tanH,8:f4}");
                anG += num;
            }
            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        private static void HyperBolic(double angle, out double sinh, out double cosh, out double tanh)
        {
            sinh = Math.Sinh(angle);
            cosh = Math.Cosh(angle);
            tanh = Math.Tanh(angle);
        }
        #endregion
        #region Question 5
        private static double CalculateKineticEnergy(double mass, double speed)
        {
            return mass * speed * speed / 2;
        }
        private static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            Console.WriteLine();
            double massS = 1, speedD = 1;
            Console.WriteLine(string.Format($"A body of mass {massS:f1} (kg) " +
                $"moving at {speedD:f1} (mps) will have kinetic energy of " +
                $"{VerE.CalculateKineticEnergy(massS, speedD):f1} (J)"));
            massS = 5; speedD = 3;
            Console.WriteLine(string.Format($"A body of mass {massS:f1} (kg) " +
                $"moving at {speedD:f1} (mps) will have kinetic energy of " +
                $"{VerE.CalculateKineticEnergy(massS, speedD):f1} (J)"));
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        #endregion
        #region Question 6
        private static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            Console.WriteLine(string.Format($"Your federal tax will be  " +
                $"{VerE.CalculateFederalTax(45000):c} if your income is  {45000:c}"));
            Console.WriteLine(string.Format($"Your federal tax will be " +
                $"{VerE.CalculateFederalTax(75000):c} if your income is  {75000:c}"));
            Console.WriteLine(string.Format($"Your federal tax will be " +
                $"{VerE.CalculateFederalTax(115000):c} if your income is {115000:c}"));
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }
        private static double CalculateFederalTax(double income)
        {
            double tax;           
            if (income > 45282 || income < 90563)
            {
                tax = ((income - 45281) * 0.205) + 6792.3;
            }
            else if (income >= 90563)
            {
                tax = (income - 90563) * 0.33 + ((90563 - 45282) * 0.205) + 45282 * 0.15;
                //in your result, I thought you were wrong right here. I've checked many times, still the same result.
            }
            else
            {
                tax = income * 0.15;
            }
            return tax;
        }
        #endregion
    }
}
