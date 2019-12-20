using System;
using System.Collections;
using System.Collections.Generic;

namespace RPSMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoveData rockPaper = new MoveData("Rock", "Paper", 0);
            //Hashtable ht = new Hashtable();
            //double[,] scores = new double[3, 3] { { 0.0, -1.0, 1.0 }, { -1.0, 0.0, 1.0 }, { 1.0, -1.0, 0.0 } };
            double[,] scores = new double[3, 3] { { 0.0, 0.0, 0.0 }, { 0.0, 0.0, 0.0 }, { 0.0, 0.0, 0.0 } };


            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.WriteLine(scores[i, 0] + " " + scores[i, 1] + " " + scores[i, 2]);
            }

            for (int i = 0; i < 100; i++)
            {
                practice(scores);

                //for (int j = 0; j < scores.GetLength(0); j++)
                //{
                //    Console.WriteLine(scores[j, 0] + " " + scores[j, 1] + " " + scores[j, 2]);
                //}
            }
            for (int j = 0; j < scores.GetLength(0); j++)
            {
                Console.WriteLine(scores[j, 0] + " " + scores[j, 1] + " " + scores[j, 2]);
            }

            for (int i = 0; i < 10; i++)
            {
                play(scores);

                for (int j = 0; j < scores.GetLength(0); j++)
                {
                    Console.WriteLine(scores[j, 0] + " " + scores[j, 1] + " " + scores[j, 2]);
                }
            }
        }
        public static void practice(double[,] scrs)
        {
            Random rnd = new Random();

            //Console.WriteLine("\n");

            //Console.WriteLine("Enter player move, Rock(0), Paper(1), or Scissors(2)");

            int pMove = rnd.Next(0,3);
            //Console.WriteLine("Enter computer move, Rock(0), Paper(1), or Scissors(2)");

            int cMove = rnd.Next(0,3);

            //Console.WriteLine("\n");
            switch (pMove)
            {
                //Rock
                case 0:
                    //Rock
                    if (cMove == 0)
                    {
                        //Console.WriteLine("Its a draw");
                    }
                    //Paper
                    else if (cMove == 1)
                    {
                        //Console.WriteLine("Computer wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] += 0.1;
                        }
                    }
                    //Scissors
                    else
                    {
                        //Console.WriteLine("Player wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] -= 0.1;
                        }
                    }
                    break;
                //Paper
                case 1:
                    //Rock
                    if (cMove == 0)
                    {
                        //Console.WriteLine("Player wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] -= 0.1;
                        }
                    }
                    //Paper
                    else if (cMove == 1)
                    {
                        //Console.WriteLine("Its a draw");
                    }
                    //Scissors
                    else
                    {
                        //Console.WriteLine("Computer wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] += 0.1;
                        }
                    }
                    break;
                //Scissors
                case 2:
                    //Rock
                    if (cMove == 0)
                    {
                        //Console.WriteLine("Computer wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] += 0.1;
                        }
                    }
                    //Paper
                    else if (cMove == 1)
                    {
                        //Console.WriteLine("Player wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] -= 0.1;
                        }
                    }
                    //Scissors
                    else
                    {
                        //Console.WriteLine("Its a draw");
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }

        }
        public static void play(double[,] scrs)
        {
            Console.WriteLine("\n");

            Console.WriteLine("Enter player move, Rock(0), Paper(1), or Scissors(2)");

            int pMove = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter computer move, Rock(0), Paper(1), or Scissors(2)");
            int cMove = getCMove(scrs, pMove);
            Console.WriteLine("Computer plays {0}", cMove);

            Console.WriteLine("\n");
            switch (pMove)
            {
                //Rock
                case 0:
                    //Rock
                    if (cMove == 0)
                    {
                        Console.WriteLine("Its a draw");
                    }
                    //Paper
                    else if (cMove == 1)
                    {
                        Console.WriteLine("Computer wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] += 0.1;
                        }
                    }
                    //Scissors
                    else
                    {
                        Console.WriteLine("Player wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] -= 0.1;
                        }
                    }
                    break;
                //Paper
                case 1:
                    //Rock
                    if (cMove == 0)
                    {
                        Console.WriteLine("Player wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] -= 0.1;
                        }
                    }
                    //Paper
                    else if (cMove == 1)
                    {
                        Console.WriteLine("Its a draw");
                    }
                    //Scissors
                    else
                    {
                        Console.WriteLine("Computer wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] += 0.1;
                        }
                    }
                    break;
                //Scissors
                case 2:
                    //Rock
                    if (cMove == 0)
                    {
                        Console.WriteLine("Computer wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] += 0.1;
                        }
                    }
                    //Paper
                    else if (cMove == 1)
                    {
                        Console.WriteLine("Player wins");
                        if (scrs[pMove, cMove] >= -1.0 && scrs[pMove, cMove] <= 1.0)
                        {
                            scrs[pMove, cMove] -= 0.1;
                        }
                    }
                    //Scissors
                    else
                    {
                        Console.WriteLine("Its a draw");
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }

        }
        public static int getCMove(double[,] scrs, int pM)
        {
            Random rnd = new Random();

            if (pM > 2)
            {
                Console.WriteLine("That choice is invalid, random move selected.");
                pM = rnd.Next(0, 3);
            }
            double arrMax = scrs[pM, 0];
            Console.WriteLine(arrMax);

            int mv = 0;


            for (int i = 2; i > 0; i--)
            {
                if(arrMax < scrs[pM, i])
                {
                    arrMax = scrs[pM, i];
                    Console.WriteLine(arrMax);
                    Console.WriteLine("i is " + i);
                    mv = i;
                }
                return mv;
            }
            return rnd.Next(0,3);
        }
    }
}
