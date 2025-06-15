using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace DoersOfStuff.UCSSG.Linq
{
    [System.Serializable]
    public class Item
    {
        public string name;
        public int    id;
        public int    buff;
    }

    public class ItemCheck : MonoBehaviour
    {
        [SerializeField] private Item[] itemInventory;
        [SerializeField] private int itemIdToSearchFor  = 3;
        [SerializeField] private int minBuffToSearchFor = 20;

        void Start()
        {
            FindItem();
            FindGreaterBuff();
            FindAverageBuff();
        }

        void FindItem()
        {
            if (itemInventory.Any(i => i.id == itemIdToSearchFor))
            {
                Debug.Log("Item " + itemIdToSearchFor + " exists");
                foreach (var item in itemInventory.Where(i => i.id == itemIdToSearchFor)) { Debug.Log("Item: " + item.name); }
            }
            else
                Debug.Log("Item " + itemIdToSearchFor + " does NOT exist");
        }

        void FindGreaterBuff()
        {
            foreach (var item in itemInventory.Where(i => i.buff > minBuffToSearchFor)) { Debug.Log("Item: " + item.name + " Buff: " + item.buff); }
        }

        void FindAverageBuff()
        {
            Debug.Log("Average itme buff is: " + itemInventory.Average(i => i.buff));
        }

    }

}
