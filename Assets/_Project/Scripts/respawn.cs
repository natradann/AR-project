using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platformer
{
    public class respawn : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private Transform pos;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (player.transform.position.y <= -15)
            {
                print("tok");
                player.transform.position = new Vector3 (151, 3, -4);
                player.transform.rotation = Quaternion.EulerRotation(0,0,0);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Finish")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
