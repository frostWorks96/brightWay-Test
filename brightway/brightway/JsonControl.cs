using System.Collections.Generic;
using System.Linq; 
using System.Text.Json; 

namespace brightway
{
    public static class JsonControl
    {


        /*************************************************************************************
         * GetListofToppingsWithCountAndSortIT(List<Toppings> toppings)
         * Date: 3/30/2022
         * By: Matthew Frost
         * Info: groups a list into a dictionary and increments each time a list appears
         * Peram: a list of Toppings
         * Returns: returns a dictinary version  of a grouped list with the 
         *          number of times each object appeared
         *************************************************************************************/
        private static Dictionary<string, Toppings> createDictinaryOfTopings(List<Toppings> toppings)
        {
            Dictionary<string, Toppings> toppingsDict = new Dictionary<string, Toppings>();
            foreach(Toppings top in toppings)
            {
                string combinedString = string.Join(",", top.toppings);//converts list to string
                combinedString = combinedString.ToLower().Trim();//makes sure the string is not affected by case, or special charates 
                if (!toppingsDict.ContainsKey(combinedString))
                {
                    toppingsDict.Add(combinedString, top);
                    toppingsDict[combinedString].timesUsed = 0;
                } 
                toppingsDict[combinedString].timesUsed++; 
            }
            return toppingsDict;
        }

        /*************************************************************************************
         * GetListofToppingsWithCountAndSortIT(List<Toppings> toppings)
         * Date: 3/30/2022
         * By: Matthew Frost
         * Info: sortes a grouped list of topping combinations with the count of 
         *       how many times they were used.
         * Peram: a list of Toppings
         * Returns: returns a sorted grouped list of topping combinations with the count 
         *          of how many times they were used.
         *************************************************************************************/
        public static List<Toppings> GetListofToppingsWithCountAndSortIT(List<Toppings> toppings)
        {
            Dictionary<string, Toppings> toppingsDict = createDictinaryOfTopings(toppings);
            List<Toppings> newList = new List<Toppings>();
            foreach (string key in toppingsDict.Keys)
            {
                newList.Add(toppingsDict[key]);
            }
            return newList.OrderByDescending(o => o.timesUsed).ToList();  
        } 
        /*************************************************************************************
         * GetAllToppings(string json)
         * Date: 3/30/2022
         * By: Matthew Frost
         * Info: returns a string of json code
         * Peram: a string containg JSON
         * Returns: list of Toppings
         *************************************************************************************/
        public static List<Toppings> GetAllToppings(string json)
        {
            return JsonSerializer.Deserialize<List<Toppings>>(json);
        }

        /*************************************************************************************
         * getJson()
         * Date: 3/30/2022
         * By: Matthew Frost
         * Info: returns a string of json code
         * Returns: string containg json code
         *************************************************************************************/
        public static string getJson()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            var json = wc.DownloadString(Header.jsonWebLink);
            return json;
        }


    }
}
