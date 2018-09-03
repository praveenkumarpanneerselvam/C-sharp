using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        // Praveenkumar Panneerselvam
        // MS Business Analytics and Information Systems
        // Muma College of Business
        //University of South Florida
       static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int selection;
            //Getting input from user on desired action and assigning them 
            
                Console.WriteLine("Hi! Choose from the following options:\n" +
                    "1: Multiplication \n2: Division \n3: Factorial \n4: Power" +
                    "\n5: Taylor expansion of sine function \n6: Taylor expansion of cosine function" +
                    "\n7: Taylor expansion of exponential function \n8: Exit");
                 selection = Convert.ToInt32(Console.ReadLine());
           

            //Based on the selection, getting the input from the user

            if (selection == 1)  //Multiplication
            {
                Console.WriteLine("Enter multiplicand: ");
                a = Convert.ToInt32(Console.ReadLine()); //Getting input1

                Console.WriteLine("Enter multiplier: ");
                b = Convert.ToInt32(Console.ReadLine()); //Getting input2

                double result_mul = multiply(a, b); // Calling multiplication function
                Console.WriteLine("Multiplication result is: " + result_mul);
                Console.ReadKey();
            }
            if (selection == 2) //Division
            {
                Console.WriteLine("Enter number: ");
                a = Convert.ToInt32(Console.ReadLine()); //Getting input1
                Console.WriteLine("Enter divisor: ");
                b = Convert.ToInt32(Console.ReadLine()); //Getting input2

                double result_div = Divide(a, b); //Calling division function
                Console.WriteLine("Division result is: " + result_div);
                Console.ReadKey();

            }
            if (selection == 3) //Factorial
            {
                Console.WriteLine("Enter a number: ");
                a = Convert.ToInt32(Console.ReadLine()); //Checking if input is less than 13
                if (a > 13)
                {
                    Console.WriteLine("Please enter a number less than or equal to 13");
                    Console.ReadKey();

                }
                else
                {
                    double result_fact = Factorial(a); //Calling factorial function
                    Console.WriteLine("Factorial result is: " + result_fact);
                    Console.ReadKey();
                }
            }
            if (selection == 4) //Power
            {
                Console.WriteLine("Enter a number: ");
                a = Convert.ToInt32(Console.ReadLine()); //Getting input1
                Console.WriteLine("Enter the exponent: ");
                b = Convert.ToInt32(Console.ReadLine()); //Getting input2

                double result_power = Power(a, b); //Calling Power function
                Console.WriteLine("Result is: " + result_power);
                Console.ReadKey();

            }
            if (selection == 5) //Sine function using Taylor series
            {
                Console.WriteLine("Enter a number: ");
                a = Convert.ToInt32(Console.ReadLine()); //Getting input
                double result_sin = sin_function(a); //Calling Sine function
                Console.WriteLine("Result is: " + result_sin); 
                Console.ReadKey();
            }
            if (selection == 6) //Cosine function using Taylor series
            {
                Console.WriteLine("Enter a number: ");
                a = Convert.ToInt32(Console.ReadLine()); //Getting input

                double result_cos = cos_function(a);//Calling Cosine function
                Console.WriteLine("Result is: " + result_cos); 
                Console.ReadKey();
            }
            if (selection == 7) //Exponential function using Taylor series
            {
                Console.WriteLine("Enter a number: ");
                a = Convert.ToInt32(Console.ReadLine()); //Getting input
                double result_exp = Exponential(a); //Calling Exponential function
                Console.WriteLine("Result is: " + result_exp); 
                Console.ReadKey();
            }
            else
                Console.WriteLine("Chose other options");
                Console.ReadKey();
           
        }

//Methods definition        

//1.	Multiplication
public static double multiply(double multiplicand, double multiplier)
        {
            double z =0;
            double x = multiplicand;
            double y = multiplier;

            if (x > 0 && y > 0) // Checking if both inputs are postive
            {
                z = multiply_logic(x, y);
                return z;
            }
            else if (x < 0 && y < 0) // Checking if both inputs are negative
            {
                x = -x;
                y = -y;
                z = multiply_logic(x, y);
                return z;
            }
            else if (x < 0 && y > 0) // Checking if any one input is negative
            {
                x = -x;
                //y = -y;
                z = multiply_logic(x, y);
                return -z;
            }
            else if (x > 0 && y < 0)// Checking if any one input is negative
            {
                //x = -x;
                y = -y;
                z = multiply_logic(x, y);
                return -z;
            }
            else
                return 0;
        }

        public static double multiply_logic(double multiplicand, double multiplier)
        {
            double product = 0;
            double x = multiplicand;
            double y = multiplier;

            for (int i = 0; i < y; i++) //Adding the multiplicand, "multiplier" times repeatedly 
                {
                    product = product + x;

                }
                return product;
           
        }

//2. Division
        public static double Divide(double num, double divisor)
        {
            double z = 0;
            double x = num;
            double y = divisor;

            if (x > 0 && y > 0) //Checking if both inputs are positive
            {
                z = Divide_logic(x, y);
                return z;
            }
            else if (x < 0 && y < 0)//Checking if both inputs are positive
            {
                x = -x;
                y = -y;
                z = Divide_logic(x, y);
                return z;
            }
            else if (x < 0 && y > 0)// Checking if any one input is negative
            {
                x = -x;
                //y = -y;
                z = Divide_logic(x, y);
                return -z;
            }
            else if (x > 0 && y < 0)// Checking if any one input is negative
            {
                //x = -x;
                y = -y;
                z = Divide_logic(x, y);
                return -z;
            }
            else
                return 0;
        }
        public static double Divide_logic(double num, double divisor)
        {
            double whole_point = 0;
            //decimal_point, 
            int count = 0;
            double[] MultiplierArray = new double[] { 0.1, 0.01, 0.001 }; //Defining the array to calculate the decimal points

            while (num >= divisor)
            {

                num = num - divisor; //This iteration is for getting the whole number here 
                count = count + 1;

            }

            whole_point = count;

            for (int i = 0; i < 3; i++)
            {
                count = 0;
                num = multiply(num,10);
                while (num >= divisor)
                {
                    num = num - divisor; //This iteration is for getting the whole number here
                    count++;
                }
                whole_point = whole_point + multiply(MultiplierArray[i], Convert.ToDouble(count)); //Here, we will get the answer including decimal point

            }
            return whole_point;

        }

//3. Power
        public static double Power(int num, double pow)
        {
            double res_pow = 1;
            if (pow == 0)
                return res_pow; //Any number whose power = 0, returns 1
            else
            {
                for (int i = 1; i <= pow; i++)
                {
                    res_pow = multiply(res_pow, Convert.ToDouble(num)); //Calculating power by calling multiply function

                }

                return res_pow;
            }
        }
        
//4. Factorial
        public static double Factorial(double num)
        {
            double res_fac = 1;

            double dummy = num;


            if (num < 13) //Restricting the number to 13 becasue if the number is more than 13, it leads to strange results due to the datatype involved
            {
                for (int i = 0; i < num; i++)
                {
                    res_fac = multiply(res_fac, dummy); //Calculating factorial by calling multiply function
                    dummy--;
                }
                return res_fac;
            }
            else
                return 0;

        }
//5. Sine function
        public static double sin_function(int input)
        {
            double sin_ans = 0;
            double temp = 0;
            double temp1 = 0;
            double temp2 = 0;
            double temp3 = 0;
            //double temp4 = 0;
            double numer = 0;
            double denom = 0;
            for (int i = 0; i < 7; i++) //Have initialised 7 because the number of terms to be calculated in restricted to 7
            {
                //sine formula: Summation [(-1)^n (x)^(2n+1)] / [2n+1]!
                temp1 = Power(-1, i); //(-1)^n
                temp2 = multiply(2, i) + 1; //2n+1
                temp3 = Power(input, temp2);//x^(2n+1)
                numer = multiply(temp1, temp3);//[(-1)^n(x)^(2n+1)]

                denom = Factorial(temp2);//(2n+1)!

                temp = Divide(numer, denom);
                sin_ans = sin_ans + temp;
            }
            return sin_ans;
        }

//6. Cosine function
        public static double cos_function(int input)
        {
            //cosine formula: Summation [(-1)^n (x)^2n] / 2n!
            double cos_ans = 0;
            double temp = 0;
            double temp1 = 0;
            double temp2 = 0;
            double temp3 = 0;
            
            double numer = 0;
            double denom = 0;
            for (int i = 0; i < 7; i++) //Have initialised 7 because the number of terms to be calculated in restricted to 7
            {

                temp1 = Power(-1, i); //(-1)^n
                temp2 = multiply(2, i);//2n
                temp3 = Power(input, temp2);//x^(2n)

                numer = multiply(temp1, temp3);//[(-1)^n(x)^2n]
                denom = Factorial(temp2); //2n!

                temp = Divide(numer, denom);

                cos_ans = cos_ans + temp;
            }
            return cos_ans;
        }
  
//7. Exponential function
        public static double Exponential(int input)
        {
            //exponential formula: Summation [x^n/n!]
            double taylor_exp_answer = 0;
            double temp = 0;
            double temp1 = 0;
            double temp2 = 0;
            for (int i = 0; i < 20; i++) //Have initialised 20 because the number of terms to be calculated in restricted to 20
            {
                temp1 = Power(input, i); //x^n
                temp2 = Factorial(i); //n!

                temp = Divide(temp1, temp2);
                taylor_exp_answer = taylor_exp_answer + temp;
            }
            return taylor_exp_answer;
        }
    }
}
