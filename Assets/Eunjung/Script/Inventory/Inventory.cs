using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Eunjung
{
    public class Inventory : MonoBehaviour
    {
        public GameObject slotPrefab;
        public GameObject itemPrefab;
        public Transform slotPosition1;
        public Transform slotPosition2;
        public Transform slotPosition3;
        public Transform slotPosition4;

        public int itemsCount = -1;
        // Start is called before the first frame update
        void Start()
        {
            Instantiate(slotPrefab, slotPosition1);
            Instantiate(slotPrefab, slotPosition2);
            Instantiate(slotPrefab, slotPosition3);
            Instantiate(slotPrefab, slotPosition4);
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Item()
        {
            Items(itemsCount);            
            itemsCount++;
        }
        public void Items(int itemCount)
        {
            switch (itemCount)
            {
                case 0:
                    {
                        Instantiate(itemPrefab, slotPosition1);
                    }
                    break;
                case 1:
                    {
                        Instantiate(itemPrefab, slotPosition2);
                    }
                    break;
                case 2:
                    {
                        Instantiate(itemPrefab, slotPosition3);
                    }
                    break;
                case 3:
                    {
                        Instantiate(itemPrefab, slotPosition4);
                    }
                    break;
            }
        }
    }
}
