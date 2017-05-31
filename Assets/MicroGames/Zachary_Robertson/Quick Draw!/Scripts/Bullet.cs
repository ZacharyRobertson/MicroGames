using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Zachary_Robertson
{
    public class Bullet : MonoBehaviour
    {
        public GameObject enemy;
        public Transform target;

        public float distanceToTarget;
        public float moveSpeed = 30f;
        // Use this for initialization
        void Start()
        {
            //Set the references so that our bullet travels towards our enemy
            enemy = GameObject.FindWithTag("Enemy");
            target = enemy.transform;

            distanceToTarget = moveSpeed * Time.deltaTime;
            Destroy(gameObject, .5f);
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, distanceToTarget);
        }

        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "Enemy")
            {
                enemy.gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}