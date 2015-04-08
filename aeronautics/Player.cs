using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace aeronautics
{
    class Player
    {
        // Initilization Section
        Hashtable PlayerHashtable = new Hashtable();
        List<InventoryObject> PlayerInventory = new List<InventoryObject>();




        /// <summary>
        /// HashTable Methods
        /// </summary>
        /// <param name="x"></param>
        public void HashTableAdd(int index, string text)
        {
            PlayerHashtable.Add(index, text);
        }
        public int HashTableGetCount()
        {
            return PlayerHashtable.Count;
        }
        public string HashTableGetText(int index)
        {
            return PlayerHashtable[index].ToString();
        }




        /// <summary>
        /// Inventory Methods
        /// </summary>
        /// <param name="x"></param>
        public void newInventoryObject(InventoryObject x)
        {
            PlayerInventory.Add(x);
        }
        public void removeInventoryObject(InventoryObject x)
        {
            PlayerInventory.Remove(x);
        }
        public void checkInventoryObject(int index)
        {
            PlayerInventory[index].ToString();
        }

        // TO ADD: Tree Path hashtable checks
    }

    class InventoryObject
    {
        string PicturePath = null;
        int ObjectID;

        public void SetPicturePath(string s)
        {
            PicturePath = s;
        }

        public void SetObjectID(int x)
        {
            ObjectID = x;
        }
    }
}
