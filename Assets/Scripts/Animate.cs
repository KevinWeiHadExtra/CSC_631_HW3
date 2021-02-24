using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animate: MonoBehaviour
{
    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Animator>().Play("CubeMove");
        }
        
    }
    
}
