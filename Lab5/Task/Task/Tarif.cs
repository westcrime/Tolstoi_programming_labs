using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Tarif
    {
        private uint price;
        private Places place;

        public Tarif(string name, uint Price)
        {
            place = GetPlaceByName(name);
            price = Price;
        }

        static public Places GetPlaceByName(string place)
        {
            if (place == "Paris")
            {
                return Places.Paris;
            }
            else
            {
                if (place == "Moscow")
                {
                    return Places.Moscow;
                }
                else
                {
                    if (place == "Washington")
                    {
                        return Places.Washington;
                    }
                    else
                    {
                        if (place == "Minsk")
                        {
                            return Places.Minsk;
                        }
                        else
                        {
                            if (place == "Tokyo")
                            {
                                return Places.Tokyo;
                            }
                            else
                            {
                                return Places.Nowhere;
                            }
                        }
                    }
                }
            }
        }

        public uint Price
        {
            get { return price; }
            set { price = value; }
        }

        public Places Place
        {
            get { return place; }
            set { place = value; }
        }

    }
}
