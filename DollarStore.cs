using System.Collections.Generic;

namespace TheMall
{
    public class DollarStore
    {
        private Dictionary<string, DollarItem> _inventory = new Dictionary<string, DollarItem>();

        private double _price = 1.00;
    }
}