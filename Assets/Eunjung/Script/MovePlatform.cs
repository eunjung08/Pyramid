using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class MovePlatform : MonoBehaviour
    {
        public float moveSpeed_b = 3f;

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            this.transform.Translate(Vector3.right * moveSpeed_b * Time.deltaTime);

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Wall_R"))
            {
                this.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            if (other.CompareTag("Turn"))
            {
                this.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
        }
    }
}
