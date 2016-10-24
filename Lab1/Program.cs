using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {

        private static int[] getAreaPerimeter(int [] input)
        {   
            /* Name: getAreaPerimeter
             * Description: This method takes a length and width as input, and output area and perimeter
             * Input: integer array - Length and Width
             * Output: integer array - Area and Perimeter
             */
             
            int length = input[0];
            int width = input[1];
            int area = length * width;
            int perimeter = 2 * (length * width);
            int[] outAreaPerimiter = { area, perimeter };
            return outAreaPerimiter;

        }

        private static int convToIntWithErrorCheck(string Input)
        {

            /* Name: convToIntWithErrorCheck
             * Description:  This method converts a string to integer using Convert.ToInt32().  
             *               It also implements try and catch error checking
             * Input: String that needs to be converted to integer
             * Output: If input string is valid,   returns integer value of string
             *         If input string is invalid, returns 0
             */
           

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
            /* Name: keepGoing
            * Description:  This method implements a loop to determine if users wants to continue
            * Input:  None
            * Output: Returns 0 if user doesn't want to continue.  Otherwise returns 1.
            *         Outputs values to Console
            */


            // If user enters "q", execute exit procedure
            Console.WriteLine("Continue? (y/n):");
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
            /* Name: getLengthWidth
            * Description:  This method takes an input Length and Width in integer and 
            *               returns Area and Permiter integers.  
            * Input: No input.  Get Length and Width from user input
            * Output: Integer array of Length and Width
            */


            // Get length and width from user
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
                // Get Length and Width from user and output results in integer array
                int [] classroomLW =  getLengthWidth();

                // Get Area and Perimeter and output results in integer array
                int [] classroomAP =  getAreaPerimeter(classroomLW);

                // Output Area and Perimiter
                Console.WriteLine("Area: \n" + classroomAP[0]);
                Console.WriteLine("Perimeter: \n" + classroomAP[1]);
                Console.WriteLine("\n");

            }
            while (keepGoing() != 0);
        }
    }
}
