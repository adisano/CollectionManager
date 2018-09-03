using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionCatalogue_2
{
    class Collections
    {
        //create two lists to hold the user's collected and not-yet-collected items
        private List<string> collectedItems = new List<string>();
        public List<string> CollectedItems {
            get { return collectedItems; }
            set { collectedItems = value; }
        }

        private List<string> notCollectedItems = new List<string>();
        public List<string> NotCollectedItems {
            get { return notCollectedItems; }
            set { notCollectedItems = value; }
        }

        //create a method to add one of the user's collected items to the list CollectedItems
        //then remove it from NotCollectedItems
        public void AddCollectedItem(string itemName)
        {
            CollectedItems.Add(itemName);
            NotCollectedItems.Remove(itemName);
        }

        //create a method allowing the user to remove an item previously on the list CollectedItems
        //then add it to NotCollectedItems
        public void RemoveCollectedItem(string itemName)
        {
            CollectedItems.Remove(itemName);
            NotCollectedItems.Add(itemName);
        }


    }
}
