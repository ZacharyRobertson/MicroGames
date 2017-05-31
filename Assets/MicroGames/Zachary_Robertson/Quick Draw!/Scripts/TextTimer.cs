using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StirlingMulvey;

namespace Zachary_Robertson
{
    public class TextTimer : MonoBehaviour
    {
        public Text drawSignal;
        public Text winText;
        public float delay;
        bool started = false;
        public GameObject drawSign;
        public GameObject enemy;

        // Use this for initialization
        void Start()
        {
            //GlobalGameManager.ActivateSelectedScene();
            GlobalGameManager.verb = "SHOOT!";
            delay = Random.Range(1f, 3);
            print(GlobalGameManager.gameActive);
            
        }

        // Update is called once per frame
        void Update()
        {
            if (enemy.activeInHierarchy == false)
            {
                GlobalGameManager.gameWon = true;
                winText.text = ("YOU WIN!");
            }
            
            if (GlobalGameManager.gameActive == true && !started)
            {
                started = true;
                StartCoroutine(DrawText());
            }

        }
        IEnumerator DrawText()
        {
            yield return new WaitForSeconds(delay);
            drawSign.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            drawSign.SetActive(false);
        }
    }
}