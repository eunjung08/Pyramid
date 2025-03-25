using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using Unity.Plastic.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Eunjung
{
    public class Player : MonoBehaviour
    {
        public float moveSpeed;
        Vector3 look;
        public float jumpPower;
        Rigidbody rigid; 
        public GameManager gameManager;
        public int currentHP = 5;
        public int maxHP = 5;
        bool canJump = true;
        public Slider HPSilder;
        public Transform spawn;

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
                    canJump = false;
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Death"))
            {
                canJump = true;
                currentHP--;
                this.transform.position = spawn.position;
                if (currentHP <= 0)
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
                currentHP--;
                if (currentHP <= 0)
                {
                    gameManager.GameOver();
                }
            }
            if (other.CompareTag("Ground"))
            {
                canJump = true;
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
