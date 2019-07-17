using System.Collections.Generic;

namespace TheMall
{
    public class FoodStore : IStore<FoodItem>
    {
        private Dictionary<string, FoodItem> _inventory = new Dictionary<string, FoodItem>();
        public void AddToInventory(string name, FoodItem item)
        {
            _inventory.Add(name, item);
        }

        public FoodItem GetFromInventory(string name)
        {
            return _inventory[name];
        }
    }
}