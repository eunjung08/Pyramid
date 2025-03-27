using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Eunjung
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public GameObject itemsprefab;
        public Transform itemPosition;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

            Instantiate(itemsprefab, itemPosition);
        }
        
        public void GameOver()
        {
            SceneManager.LoadScene("Lobby");
        }

        public void stage1Clear()
        {
            SceneManager.LoadScene(1);
        }
    }
}
