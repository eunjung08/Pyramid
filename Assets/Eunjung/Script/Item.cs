using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class Item : MonoBehaviour
    {
        public Inventory inventory;
        // Start is called before the first frame update
        void Start()
        {
            inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        private void OnTriggerEnter(Collider other)
        { 
            if (other.CompareTag("Player"))
            {
                inventory.Item();
                Destroy(this.gameObject);
            }
        }
    }
}
