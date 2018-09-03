using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionCatalogue_2
{
    class Checklist
    {
        //create a list to store the available items in the checklist
        private List<string> availableItems = new List<string>();
        public List<string> AvailableItems {
            get { return availableItems; }
            set { availableItems = value; }
        }

        //create a method to allow the user to add items to their checklist
        public void ChecklistAdd(string itemName)
        {
            AvailableItems.Add(itemName);
        }

        //create a method to allow the user to remove items from their checklist
        public void ChecklistRemove(string itemName)
        {
            AvailableItems.Remove(itemName);
        }
    }
}
