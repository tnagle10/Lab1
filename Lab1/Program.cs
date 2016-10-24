using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {

        private static void calcAreaPerimeter(int [] input)
        {
            int length = input[0];
            int width = input[1];
            int area = length * width;
            int perimeter = 2 * (length * width);
            Console.WriteLine("Area: "+area);
            Console.WriteLine("Perimter: "+perimeter);

        }

        private static int convToIntWithErrorCheck(string Input)
        {
            // This method converts a string to decimal using Convert.ToDecimal().
            // It uses System error checking to make sure the input valid.
            // If the input is valid, it returns the input converted to decimal.
            // If the input is invalid, it returns a 0  

            try
            {
                // Verify user input is in correct format 
                Int32 Output = Convert.ToInt32(Input);
                return Output;
            }
            catch (System.OverflowException)
            {
                System.Console.WriteLine(
                    "The conversion from string to number overflowed.\n");
                return 0;
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine(
                    "The string is not formatted as a number.\n");
                return 0;
            }
            catch (System.ArgumentNullException)
            {
                System.Console.WriteLine(
                    "The string is null.");
                return 0;
            }
        }
  
        private static int keepGoing()
        {
            // If user enters "q", execute exit procedure
            Console.WriteLine("Continue (y/n):");
            string input = Console.ReadLine();

            if (input == "n")
            {
                Console.WriteLine("You entered n\n");
                Console.WriteLine("Are you sure you want to exit? (Type y to confirm)");
                input = Console.ReadLine();
                if (input == "y")
                {
                    return 0;
                }

            }
            
                return 1;
         
        }


        private static int [] getLengthWidth()
        {
           // Get length and width from user in string format
           Console.WriteLine("Enter Length:");
           string lengthS = Console.ReadLine();
           Console.WriteLine("Enter Width:");
           string widthS = Console.ReadLine();

            //Convert length and width to integer
            int lengthI = convToIntWithErrorCheck(lengthS);
            int widthI = convToIntWithErrorCheck(widthS);

            // Output length and width as integer array
            int[] lengthwidth = { lengthI, widthI };
            return lengthwidth;
         }

    
    static void Main(string[] args)
        {

            do
            {
                int [] classroomLW =  getLengthWidth();
                calcAreaPerimeter(classroomLW);

            }
            while (keepGoing() != 0);
        }
    }
}
