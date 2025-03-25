using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Eunjung
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public GameObject itemprefab;
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

            Instantiate(itemprefab, itemPosition);
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
