using System;
using System.Collections.Generic;
using System.Text;

namespace FindPi
{
    class FindPiThread
    {
        //An int holding the number of darts it needs to throw
        int numThrown;
        //An int holding the count of darts that lands inside your dartboard(quarter)
        public int numSuccess { get; set; }
        //A Random - this will be used to generate throws!
        Random rnd;

        FindPiThread(int numToThrow)
        {
            rnd = new Random();
            numThrown = 0;
            numSuccess = 0;
        }
    }
}
