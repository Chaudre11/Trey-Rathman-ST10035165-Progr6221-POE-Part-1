//Trey Rathman ST10035165 Progr6221 POE Part 1

using System;

namespace ST10035165_Prog6221_POE
{
    class Program //class created
    {
        static void Main(String[] args) //applications entry point
        {

            Recipe();//method is called

            Console.WriteLine("Would You like to enter a new recipe");// asks user for input
            String newEntry = Console.ReadLine();

            if (newEntry == "Yes" || newEntry == "yes" || newEntry == "YES")// checks if the newEntry option is true  )
            {
                Recipe();//method is called
            }
            else
            {
                Environment.Exit(1);//closes console
            }

                Console.ReadKey();

        }

        public static void Recipe()
        {
            string recipeName = ""; //string variable declared to hold recipe name
            int numberOfIngredients = 0;// integer varible delcared to hold number of ingredients


            Console.WriteLine("Enter the name for this recipe.");// asks user for input
            recipeName = Console.ReadLine();//assigns value to variable

            Console.WriteLine("Enter the amount of ingredients for this recipe.");// asks user for input
            numberOfIngredients = Convert.ToInt32(Console.ReadLine());//assigns value to variable

            string[] ingredients = new string[numberOfIngredients];// array vairiable declared to hold ingredients name
            int[] quantityOfIngredients = new int[numberOfIngredients];// array vairiable declared to hold the quantity of the ingredient
            string[] unitOfMeasurement = new string[numberOfIngredients];// array vairiable declared to hold unit of meausrement

            Console.Clear();//clears the console display
            for (int i = 0; i < ingredients.Length; i++)// for loop to assign vaules in the arrays
            {
                Console.WriteLine("Enter the name of ingredient for this recipe.");// asks user for input
                ingredients[i] = Console.ReadLine();//assigns value to variable
                Console.WriteLine("Enter quantity for this ingredient for this recipe.");// asks user for input
                quantityOfIngredients[i] = Convert.ToInt32(Console.ReadLine());//assigns value to variable
                Console.WriteLine("Enter the unit of measurement of the ingredient for this recipe.");// asks user for input
                unitOfMeasurement[i] = Console.ReadLine();//assigns value to variable

                Console.Clear();//clears the console display
            }

            Console.Clear();//clears the console display
            Console.WriteLine(recipeName);



            for (int i = 0; i < ingredients.Length; i++)//for loop display arrays data
            {
                Console.WriteLine(quantityOfIngredients[i] + " " + unitOfMeasurement[i] + " of " + ingredients[i]);
            }

            string scaled = "";//string variable declared to hold scale value

            Console.WriteLine("Do you want to scale the recipe");// asks user for input
            scaled = Console.ReadLine();//assigns value to variable

            if (scaled == "Yes" || scaled == "yes" || scaled == "YES")// checks if the scale option is true 
            {
                Console.WriteLine("How much do you want to scale the recipe");// asks user for input
                int scale = Convert.ToInt32(Console.ReadLine());//assigns value to variable

                Console.Clear();//clears the console display

                for (int i = 0; i < ingredients.Length; i++)//for loop to update the arrays values and dsiaplay arrays data
                {
                    Console.WriteLine(quantityOfIngredients[i] * scale + " " + unitOfMeasurement[i] + " of " + ingredients[i]);
                }
            }
            

            Console.WriteLine("Do you want to clear data and entre new recipe");// asks user for input
            string Option = Console.ReadLine();//assigns value to variable

            if (Option == "Yes" || scaled == "yes" || scaled == "YES")
            {
                recipeName = "";// clears variable
                numberOfIngredients = 0;// clears variable
                scaled = "";// clears variable
                Array.Clear(ingredients);// clears variable
                Array.Clear(quantityOfIngredients);// clears variable
                Array.Clear(unitOfMeasurement);// clears variable
            }

            

        }

    }
}
            

         