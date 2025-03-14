using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Eunjung
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

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
        }
        
        public void GameOver()
        {
            SceneManager.LoadScene(0);
        }

        public void stage1Clear()
        {
            SceneManager.LoadScene(1);
        }
    }
}
