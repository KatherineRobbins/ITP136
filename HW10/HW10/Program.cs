using static System.Console;
namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            food food1 = new food();
            food food2 = new food();


            food1.FoodId = 1234;
            food1.FoodName = "Pear";
            food1.FoodDescription = "Fruit";
            food1.FoodCost = 1.00;

            food2.FoodId = 5678;
            food2.FoodName = "Okra";
            food2.FoodDescription = "Vegetable";
            food2.FoodCost = 1.25;



            WriteLine("{0,10}{1,17}{2,20}{3,15}", "Food Id", "Food Name", "Food Description", "Food Cost");
            WriteLine("{0,10}{1,17}{2,20}{3,15}", food1.FoodId, food1.FoodName, food1.FoodDescription, food1.FoodCost);
            WriteLine("{0,10}{1,17}{2,20}{3,15}", food2.FoodId, food2.FoodName, food2.FoodDescription, food2.FoodCost);
        }
    }
}