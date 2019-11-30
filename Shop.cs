using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_project
{
    public class Shop
    {
        private string name;
        private int weight;
        private int price;
        /*********************************************For rice***************************************/
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }
        /*********************************************For pulses***************************************/
        /// <summary>
        /// Gets the weight.
        /// </summary>
        /// <returns></returns>
        public int GetWeight()
        {
            return weight;
        }

        public void SetWeight(int value)
        {
            weight = value;
        }
         /*********************************************For wheat***************************************/
        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns></returns>
        public int GetPrice()
        {
            return price;
        }

        public void SetPrice(int value)
        {
            price = value;
        }
    }
}
