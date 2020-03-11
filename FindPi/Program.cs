using System;
using System.Collections.Generic;
using System.Threading;

/*
 * Author: Danny Lillard
 * Date: 3/11/2020
 * Description: This class runs the FindPiThread.cs class. It is responsible for
 *              asking the user how many times to run the simulation, threading instances
 *              of the class, and running those threads. It then calculates the pi value
 *              for the experiment.
 */
namespace FindPi
{
    class Program
    {
        static void Main(string[] args)
        {
            //This number is all threads successful darts added together.
            int totalNumSuccess = 0;
            Console.WriteLine("Please enter how many darts you would like to throw.");
            string userInput = Console.ReadLine();
            Console.WriteLine("Please enter how many threads you would like to run.");
            string threadNumInput = Console.ReadLine();

            List<Thread> threads =  new List<Thread>();
            List<FindPiThread> piThreads = new List<FindPiThread>();


            for (int i = 0; i < Convert.ToInt32(threadNumInput); i++)
            {
                piThreads.Add(new FindPiThread(Int32.Parse(userInput)));

                threads.Add(new Thread(new ThreadStart(piThreads[i].throwDarts)));

                threads[i].Start();

                Thread.Sleep(16);
            }
            for(int i = 0; i < Convert.ToInt32(threadNumInput); i++)
            {
                threads[i].Join();
            }
            for(int i = 0; i < Convert.ToInt32(threadNumInput); i++)
            {
                totalNumSuccess = piThreads[i].numSuccess;
            }
            Console.WriteLine(4.0 * (totalNumSuccess) / (Convert.ToInt32(userInput)));
            Console.ReadKey();
        }
    }
}
