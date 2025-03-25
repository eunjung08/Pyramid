using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Eunjung
{
    public class InGameUI : MonoBehaviour
    {
        public static InGameUI instance;

        public Slider hpSlider;
        public Slider OxSlider;

        public Player player;
        public GameManager gameManager;

        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            Invoke("StartTimer", 0.5f);
        }
        void StartTimer()
        {
            StartCoroutine(Timer());
        }
        private void Update()
        {
            if (hpSlider.gameObject.activeSelf)
            {
                hpSlider.value = (float)player.currentHP / player.maxHP;
            }
            Invoke("Timer", 1f);
        }
        IEnumerator Timer()
        {
            OxSlider.value -= 1 / 180f;
            if (OxSlider.value <= 0)
            {
                OxSlider.value = 0;
                gameManager.GameOver();
                yield return null;
            }
            yield return new WaitForSeconds(1f);
            StartCoroutine(Timer());
        }
    }
}
