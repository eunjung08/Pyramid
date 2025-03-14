using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static PlasticPipe.PlasticProtocol.Messages.Serialization.ItemHandlerMessagesSerialization;

namespace Eunjung
{
    public class Snake : MonoBehaviour
    {
        public float moveSpeed = 3f;

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            this.transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Wall_L"))
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (other.CompareTag("Wall_R"))
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
}
