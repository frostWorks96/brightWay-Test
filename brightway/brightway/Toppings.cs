
using System.Collections.Generic;
using System.Linq; 




namespace brightway
{
    public class Toppings
    {

        public List<string> toppings { get; set; }
        public int timesUsed { get; set; }

        public Toppings(List<string> toppings)
        { 
            this.toppings = sort(toppings);
        }

        /*************************************************************************************
         * sort(List<string> toppings)
         * Date: 3/30/2022
         * By: Matthew Frost
         * Info: sorts a list using linq
         * Peram: list of strings
         * Returns: returns a sorted list of Topings
         *************************************************************************************/
        private List<string> sort(List<string> toppings)
        {
            return toppings.OrderBy(q => q).ToList();
        }
    }
}
