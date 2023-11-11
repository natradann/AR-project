using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int dir = 0;
    public int isJump = 0;
    [SerializeField] GameObject move;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void left()
    {
        dir = -1;
    }
    public void right()
    {
        dir = 1;
    }
    public void rr()
    {
        dir = 0;
    }
    public void jump()
    {
        move mm = move.GetComponent<move>();
        isJump = 1;
        mm.tjump = 1;
    }
}
