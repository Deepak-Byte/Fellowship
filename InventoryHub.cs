using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_project
{
    public class InventoryHub
    {
        List<Shop> AuthorList = new List<Shop>();
        /// <summary>
        /// The rice
        /// </summary>
        private List<Shop> rice;

        private List<Shop> GetRice()
        {
            return rice;
        }

        private void SetRice(List<Shop> value)
        {
            rice = value;
        }
        /// <summary>
        /// The pulses.
        /// </summary>
        private List<Shop> pulses;

        private List<Shop> GetPulses()
        {
            return pulses;
        }

        private void SetPulses(List<Shop> value)
        {
            pulses = value;
        }
        /// <summary>
        /// The wheat
        /// </summary>
        private List<Shop> wheat;

        private List<Shop> GetWheat()
        {
            return wheat;
        }

        private void SetWheat(List<Shop> value)
        {
            wheat = value;
        }
    }
}
