using UnityEngine;

namespace Platformer
{
    public class MoveCam : MonoBehaviour
    {
        [SerializeField] private Transform playerfw;
        [SerializeField] private float speed;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if(this.transform.position.z < playerfw.position.z)
            {
                this.transform.Translate(0, 0, speed * Time.deltaTime);
            }
            
        }
    }
}
