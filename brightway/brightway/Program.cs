using System;  
namespace brightway
{
    class Program
    {
        static void Main(string[] args)
        { 

            var json = JsonControl.getJson();
            var listOftoppings = JsonControl.GetAllToppings(json);
            var orginizedList = JsonControl.GetListofToppingsWithCountAndSortIT(listOftoppings);
            for(int i = 0; i < Header.numberOfToppingsToDisplay && i < orginizedList.Count; i++)
            {
                Console.WriteLine("******************************************************************************************************");
                Console.WriteLine("{");
                Console.WriteLine("\tPopularity Rating: " + (i + 1));
                Console.WriteLine("\tToppings: " + string.Join(",", orginizedList[i].toppings) );
                Console.WriteLine("\tnumber of times a topping combination was used: " + orginizedList[i].timesUsed); 
                Console.WriteLine("}"); 
            }
        }


    }
}
