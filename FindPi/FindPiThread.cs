using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Danny Lillard
 * Date: 3/11/2020
 * Description: This class contains the logic to find pi using the 
 *              Monte Carlo method.
 */
namespace FindPi
{
    class FindPiThread
    {
        //An int holding the number of darts it needs to throw
        int numToThrow;
        //An int holding the count of darts that lands inside your dartboard(quarter)
        public int numSuccess { get; set; }
        //A Random - this will be used to generate throws!
        Random rnd;

        /*
         * Paramertized constructor, sets numToThrow to userInput to control loops 
         * later in the class.
         */
        public FindPiThread(int userInput)
        {
            rnd = new Random();
            numToThrow = userInput;
            numSuccess = 0;
        }

        /*
         * This function is used to calculate pi. It randomly selects two doubles from
         * 0 to 1 and finds the hypotenuse between them, if the hypotenuse is equal to,
         * or 1 then the point falls in the circle.
         */
        public void throwDarts()
        {
            double x;
            double y;
            double hypo;
            for(int i = 0; i < numToThrow; i++)
            {
                x = rnd.NextDouble();
                y = rnd.NextDouble();

                hypo = Math.Sqrt(x * x + y * y);
                if(hypo <= 1)
                {
                    numSuccess++;
                }
            }
        }
    }
}
