using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eunjung
{
    public class FollowCamera : MonoBehaviour
    {
        public Transform target;
        public float smoothSpeed = 0.125f;
        public Vector3 offset;

        public GameObject player;

        private void Awake()
        {
            target = GameObject.Find("Target").transform;
            //player = GameObject.Find("Player");
        }

        private void LateUpdate()
        {
            Vector3 pos = target.position + offset;
            Vector3 smoothPos = Vector3.Lerp(transform.position, pos, smoothSpeed);
            this.transform.position = smoothPos;
            this.transform.LookAt(target);

        }
    }
}
