using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Zachary_Robertson
{
    public class Player : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform firePoint;

        public TextTimer textChange;
        public TextTimer timer;
        public Animator anim;

        private bool hasShot = false;


        // Use this for initialization
        void Start()
        {
            textChange = GetComponent<TextTimer>();

        }

        // Update is called once per frame
        void Update()
        {
            if (hasShot == false)
            {
                Shoot();
            }
        }

        public void SpawnBullet()
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }

        void Shoot()
        {
            if (timer.drawSign.activeInHierarchy == true)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    anim.SetTrigger("Shoot");
                    hasShot = true;

                }
            }
            if (timer.drawSign.activeInHierarchy == false)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    hasShot = true;
                    textChange.winText.text = ("YOU LOSE!");

                }
            }
        }
    }
}
