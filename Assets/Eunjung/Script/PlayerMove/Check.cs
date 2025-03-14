using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class Check : MonoBehaviour
    {
        public float groundDistance;
        public LayerMask groundMask;
        public bool isGround
        {
            get
            {
                RaycastHit2D Hit = Physics2D.Raycast(transform.position, Vector2.down, groundDistance, groundMask.value);

                return Hit.transform != null;
            }
        }
    }
}
