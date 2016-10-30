using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {

        private static double calcArea(double length, double width)
        {   
            /* Name: calcArea
             * Description: This method takes a length and width as input, and outputs area
             * Input: float array - Length and Width
             * Output: float array - Area
             */
            double area = length * width;
            return area;
        }

        private static double calcPerimeter(double length, double width)
        {
            /* Name: calcArea
             * Description: This method takes a length and width as input, and outputs area
             * Input: float array - Length and Width
             * Output: float array - Area
             */

            double perimeter = 2 * (length + width);
            return perimeter;

        }

        private static double calcVolume(double length, double width, double height)
        {
            /* Name: calcArea
             * Description: This method takes a length and width as input, and outputs area
             * Input: float array - Length and Width
             * Output: float array - Area
             */

            // Calculate volu,e
            double volume = length*width*height;
            return volume;

        }

        private static double convToDoubleWithErrorCheck(string Input)
        {

            /* Name: convTofloatWithErrorCheck
             * Description:  This method converts a string to float using Convert.Tofloat().  
             *               It also implements try and catch error checking
             * Input: String that needs to be converted to float
             * Output: If input string is valid,   returns float value of string
             *         If input string is invalid, returns 0
             */



            // Verify user input is in correct format 
                double Output = 0;
                if (double.TryParse(Input,out Output))
                 {
                    
                    return Output;
                }
               
                else
                {
                    Console.WriteLine("Invalid Number");
                    return 0;
                }
           
        }
  
        private static bool keepGoing()
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
                    return false;
                }

            }
            
                return true;
         
        }
        
        private static void getLengthWidth(out double lengthD, out double widthD)
        {
            /* Name: getLengthWidth
            * Description:  This method takes an input Length and Width in double and 
            *               returns Area and Permiter in double.  
            * Input: No input.  Get Length and Width from user input
            * Output: Double array of Length and Width
            */


            // Get length and width from user
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("Enter Length:");
            string lengthS = Console.ReadLine();
            
            Console.WriteLine("Enter Width:");
            string widthS = Console.ReadLine();

            //Convert length and width to double
            lengthD = convToDoubleWithErrorCheck(lengthS);
            widthD = convToDoubleWithErrorCheck(widthS);
         
         }

        private static double getHeight()
        {
            /* Name: getLengthWidth
            * Description:  This method takes an input Height in double and 
            *               returns Permiter in double.  
            * Input: No input.  Get Length and Width from user input
            * Output: float array of Length and Width
            */


            // Get length and width from user
            Console.WriteLine("Enter Height ");
            string heightS = Console.ReadLine();

            //Convert length and width to double
            double heightD = convToDoubleWithErrorCheck(heightS);
            

            // Output height as double            
            return heightD;
        }


        static void Main(string[] args)
        {

            do
            {
                double length;
                double width;
                // Get Length and Width from user and output results in float array
                getLengthWidth(out length, out width);


                // Get Area and Perimeter and output results in float array
                double classroomArea = calcArea(length, width);
                double classroomPerimeter = calcPerimeter(length, width);

                // Output Area and Perimiter
                Console.WriteLine("Area: \n" + classroomArea);
                Console.WriteLine("Perimeter: \n" + classroomPerimeter);
                Console.WriteLine("\n");

                // Ask user if they also want to calculate volume
                Console.WriteLine("Would you also like to calculate volume?  (y/n)");
                // If they do, get the height of room and calculate volume
                if (Console.ReadLine() == "y")
                {
                    // Get height of the room
                    double height = getHeight();
                    // Calcualte volume of room
                    double classroomVolume = calcVolume(length, width, height);
                    // Output Volume
                    Console.WriteLine("Volume: \n" + classroomVolume);
                    Console.WriteLine("\n");
                }


            }
            while (keepGoing());
        }
    }
}
