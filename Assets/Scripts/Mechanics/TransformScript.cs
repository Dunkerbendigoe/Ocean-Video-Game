using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public RuntimeAnimatorController diverController;
    public RuntimeAnimatorController turtleController;
    Animator animatora;

    // Start is called before the first frame update
    void Start()
    {
        animatora = GameObject.FindWithTag("Player").GetComponent<Animator>();   
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            animator.runtimeAnimatorController = turtleController as RuntimeAnimatorController;
        }
    }
    */

    void OnTriggerEnter2D() 
    {
        animatora.runtimeAnimatorController = turtleController as RuntimeAnimatorController;
    }
}
