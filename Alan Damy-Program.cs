using System;

namespace Major_Assignment_1
// Alan Damy
// April 5, 2023
// Major Assignment 1
// Due: April 13, 2023
{
    public class Program
    {
        public static void Damy_Displayarray(int[,] num)
        {
            Console.WriteLine("--------------------------------------------------------------");
            //to have some lines between each set
            //to make it look more aesthetic

            Console.WriteLine("\t\tReviewers/Movies/Ratings");
            Console.WriteLine(); // Move to the next row

            double rows = num.GetLength(0); // Get the number of rows in the 2D array
            double columns = num.GetLength(1); // Get the number of columns in the 2D array

            // Display the matrix
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Ratings from Reviewer #{i + 1}: ");
                Console.WriteLine(""); //to have some space between each set //to make it look more aesthetic

                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Movie #{j + 1} Rating: ");
                    Console.Write(num[i, j]); // Display each element of the matrix 
                    Console.WriteLine(""); //to have some space between each set 
                                           //to make it look more aesthetic
                }
                Console.WriteLine(""); //to have some space between each set
                                       //to make it look more aesthetic
            }
            return;
        }

        public static int[,] Damy__printHighestLowestReviewerRating(int[,] num)//this method will allow the program to find the highest and lowest
                                                                               //rating from each reviewer
        {
            Console.WriteLine("--------------------------------------------------------------");
            //to have some lines between each set
            //to make it look more aesthetic

            Console.WriteLine("\t\tThe Highest and Lowest Review");
            Console.WriteLine(); // Move to the next row

            for (int i = 0; i < num.GetLength(0); i++)
            {
                double high = num[i, 0];//assumption: the first review is the highest
                double low = num[i, 0]; //Assumption: the first review is the lowest

                // inner loop
                for (int j = 0; j < num.GetLength(1); j++) // go through 2nd dimension
                {
                    if (num[i, j] > high)//finds the highest rating
                    {
                        high = num[i, j];
                    }
                    if (num[i, j] < low)//finds the lowest rating
                    {
                        low = num[i, j];
                    }
                }

                Console.WriteLine($"The highest rating for reviewer #{i + 1} is {high} and the lowest is {low}");
                //prints the highest and lowest review for each reviewer

                Console.WriteLine(""); //to have some space between each set //to make it look more aesthetic
            }

            return num;
        }

        public static int[,] Damy_printAverageMovieRating(int[,] num)//This method will allow the program to find
                                                                     //the average rating for each movie
        {
            Console.WriteLine("--------------------------------------------------------------");
            //to have some lines between each set
            //to make it look more aesthetic

            Console.WriteLine("\t\tAverage Rating Per Movie");
            Console.WriteLine(); // Move to the next row

            double[] movierating = new double[num.GetLength(1)]; // declaring an array with specific size


            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    movierating[j] += num[i, j];
                }
            }

            for (int i = 0; i < movierating.Length; i++)
            {
                double sum = movierating[i];//sums up all the movie ratings
                double avg = sum / num.GetLength(0);//finds average

                Console.WriteLine($"The average rating for Movie # {i + 1} is {avg:N2}");
                Console.WriteLine(""); //to have some space between each set //to make it look more aesthetic

            }

            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Reviewers: ");
            int reviewers = Convert.ToInt32(Console.ReadLine()); // inputs how many reviewers

            Console.WriteLine("Enter the number of movies: ");
            int movies = Convert.ToInt32(Console.ReadLine()); // inputs how many movies

            Console.WriteLine(""); //to have some space between each set //to make it look more aesthetic


            int[,] num = new int[reviewers, movies]; // declaring an empty array with specific size


            for (int i = 0; i < reviewers; i++)
            {
                Console.WriteLine($"Reviewer # {i + 1} : ");//this orders the reviewers

                for (int j = 0; j < movies; j++)
                {
                    Console.WriteLine($"Enter the movie rating: ");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine(""); //to have some space between each set //to make it look more aesthetic

            }

            Damy_Displayarray(num);

            Damy__printHighestLowestReviewerRating(num); // will display this method

            Damy_printAverageMovieRating(num); // will display this method
        }
    }
}
