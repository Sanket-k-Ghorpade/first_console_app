using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace first_console_app.D1Assignments
{
    public class FeesDiscountCalculator
    {
        public static void Run()
        {
            // taking user input
            Console.WriteLine("-------------Students Fees Calculator-------------------\n");
            double[] fees = new double[5];
            double[] result = new double[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter fees for student {0}: ", i + 1);
                double tempFees = Convert.ToDouble(Console.ReadLine());
                while(tempFees < 5000 ||  tempFees > 10000)
                {
                    Console.WriteLine("Error!! Fees should be in the range 5000 to 10000.");
                    Console.WriteLine("Enter fees for student {0}: ", i + 1);
                    tempFees = Convert.ToDouble(Console.ReadLine());
                    if(tempFees > 5000 && tempFees < 10000)
                    {
                        break;
                    }
                }
                fees[i] = tempFees;
            }

            // Calling method
            result = FeesCalculator(fees);

            //printing output
            Console.WriteLine("\n---------------Fees of students after discounts-----------\n");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student {i+1} fees: {result[i]}");
            }
        }
        public static double[] FeesCalculator(double[] fees)
        {
            double[] result = new double[5];

            for(int i = 0; i < 5; i++)
            {
                if (fees[i] > 7000) 
                {
                    double discount = fees[i] * 0.05;
                    result[i] = fees[i] - discount;
                } else
                {
                    result[i] = fees[i];
                }
            }
            return result;
        }
    }
}
