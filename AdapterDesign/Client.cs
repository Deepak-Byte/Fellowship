using System;
using System.Collections.Generic;
using System.Text;

namespace Structural_Design_Patterns.AdapterDesign
{
    public class Client:IAdapter
    {
        //public List<string> GetProductDetails()
        //{
           
        //}
        public List<string> Getproductdetails()
        {
            //// Create Instance of an AdapterClass classs
            Adapter adapter = new Adapter();
            return adapter.ListOfProductDetails();
        }
    }
}
