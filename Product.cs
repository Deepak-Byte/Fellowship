using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_S
{
    public class Product
    {
        private string type;
        private string name;
        private int weight;
        private int price;
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }


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


        /**************************************Return fromat rom JSON file*****************************************/
        //public string ToString()
        //{
        //    return string.Format("Name: {0}\n weight: {1}\n price{2}", name, weight, price);
        //}
    }
}
