using System;

namespace PracticeTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aliceScore = {1, 2, 3, 5, 6};
            int[] bobScore = {3, 3, 1, 2, 2};

            Defais(aliceScore, bobScore);
            Console.ReadKey();
        }

        public static void Defais(int[] alice, int[] bob)
        {
            int bobPoints = 0;
            int alicePoints = 0;
            int[] scores = new int[2];

            if (alice.Length == bob.Length)
            {
                for(int i = 0; i < alice.Length; i++)
                {
                    if (alice[i] > bob[i])
                    {
                        alicePoints++;
                    }
                    else if (alice[i] < bob[i])
                    {
                        bobPoints++;
                    }
                }
                scores[0] = alicePoints;
                scores[1] = bobPoints;

                Console.WriteLine($"The result: Alice: {scores[0]} - Bob: {scores[1]}");
            }
            else
            {
                Console.WriteLine("Arrays must be equals!");
            }
        }
    }
}
