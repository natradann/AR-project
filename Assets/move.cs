using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KBCore.Refs;


    public class move : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] float movespeed = 7;
        [SerializeField] float turnspeed = 7;
        [SerializeField] float jumpF = 3;
        [SerializeField] float grav = 7;
        [SerializeField] GameObject GG;
        [SerializeField] public float tjump= 100;



    private void Start()
    {
        Control crl = gameObject.GetComponent<Control>();
        GroundChecker gg = GG.GetComponent<GroundChecker>();
    }
    // Update is called once per frame
    void Update()
        {
        Control crl = gameObject.GetComponent<Control>();
        GroundChecker gg = GG.GetComponent<GroundChecker>();
        gameObject.transform.Translate(0, 0, movespeed * Time.deltaTime);
            if (crl.dir == -1)
            {
                gameObject.transform.Translate(-1 * turnspeed * Time.deltaTime, 0, 0);
            }
            if (crl.dir == 1)
            {
                gameObject.transform.Translate(turnspeed * Time.deltaTime, 0, 0);
            }
            if (crl.isJump == 1)
            {
            gameObject.transform.Translate(0, jumpF * Time.deltaTime, 0);
            if (tjump >= 0)
            {
                tjump -= Time.deltaTime;
                
            }
            else if(tjump <= 0)
            {
                crl.isJump = 0;
            }
            }
            if (!gg.IsGrounded && crl.isJump!= 1)
            {
                gameObject.transform.Translate(0, -grav * Time.deltaTime, 0);
            }
            
        }
    }
