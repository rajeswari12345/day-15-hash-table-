using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15_hash_table
{
    internal class MyMapNode
    {
        private readonly int size;
        private readonly LinkedList<KeyValuePair<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValuePair<K, V>>[size];
        }
        protected int GetArrayPosition(KeyValuePair key)
        {

            int position = KeyValuePair.GetHashCode() % sizeof;

            return Math.Abs(position);
        }
        public v Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> Linkedlist = GetLinkedList(position);
            foreach (KeyValuePair<K, V> item in Linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;

                }
            }
            return default(v);


        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedlist
                = GetlinkedList(position)
                keyvalue < k v > items = new KeyValuePair<K, V>() { Key = key, Value = value }
                linkedlist.AddLast(item);
        }
        public void Remove(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<K, V>> linkedlist
                = GetlinkedList(position)
              bool itemFound = false;
            keyvalue < k v > founditems = default(KeyValue<k, v>);
            linkedlist.AddLast(item);
            foreach (KeyValuePair<K, V> item in Linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    Founditem = item;
                }
                if (itemFound)
                {
                    linkedlist.Remove(founditem);
                }
            }


        protected LinkedList<KeyValuePair<K, V>> linkedlist
        {
            LinkedList<KeyValuePair<K, V>> linkedlist = items 
            if(LinkedList == null)
            {
               linkedlist = new LinkedList<keyvalue<k, V>>();
                items[position] = LinkedList;
               }
                return linkedlist;
        }
}

       public struct KeyValue<k, v>
       {
       public k key { get; set; }
        public v value { get; set; }
}
}
        
