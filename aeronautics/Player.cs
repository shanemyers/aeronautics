using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace aeronautics
{
    class Player
    {
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
        public void HashTableClear()
        {
            for (int i = 0; i < HashTableGetCount(); i++)
            {
                PlayerHashtable.Remove(i);
            }

            PlayerHashtable = new Hashtable();
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
        public int inventoryObjectCount()
        {
            return PlayerInventory.Count();
        }
        public void removeInventoryAll()
        {
            for (int i = 0; i < PlayerInventory.Count; i++)
            {
                PlayerInventory.Remove(PlayerInventory[i]);
            }
        }
        public int checkInventoryObject(int index)
        {
            return PlayerInventory[index].GetObjectID();
        }
        // TO ADD: Tree Path hashtable
        // TO ADD: Inventory array
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
        public int GetObjectID()
        {
            return ObjectID;

        }
    }
}
