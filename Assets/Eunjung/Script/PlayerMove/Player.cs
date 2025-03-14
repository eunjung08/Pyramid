using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class Player : MonoBehaviour
    {
        public float moveSpeed;
        Vector3 look;
        public float jumpPower;
        Rigidbody rigid;
        bool isGround = true;
        public GameManager gameManager;
        public int HP = 5;
        bool canJump = true;

        private void Awake()
        {
            rigid = GetComponent<Rigidbody>();
        }
        void Update()
        {
            Move();
        }

        void Move()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");
                look = v * Vector3.forward + h * Vector3.right;

                this.transform.rotation = Quaternion.LookRotation(look);
                this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

                if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
                {
                    rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Death"))
            {
                HP--;
                if (HP <= 0)
                {
                    gameManager.GameOver();
                }
            }
            if (other.CompareTag("Next"))
            {
                gameManager.stage1Clear();
            }
            if (other.CompareTag("Snake"))
            {
                HP--;
                if (HP <= 0)
                {
                    gameManager.GameOver();
                }
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("NoJump"))
            {
                canJump = false;
            }
        }
    }
}
