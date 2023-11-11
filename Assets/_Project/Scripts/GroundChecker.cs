using UnityEngine;


    public class GroundChecker : MonoBehaviour {
        [SerializeField] float groundDistance = 0.08f;
        [SerializeField] LayerMask groundLayers;
        //[SerializeField] float grav = 9;


    public bool IsGrounded;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground")
        {
            IsGrounded = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            IsGrounded = false;
        }
    }
}

