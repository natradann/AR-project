using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platformer
{
    public class OpButton : MonoBehaviour
    {
       public void Restart()
        {
            SceneManager.LoadScene(1);
        }

        public void Quit()
        {
            Debug.Log("QUIT!");
            Application.Quit();
        }
    }
}
