using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class TransformScript : MonoBehaviour
    {
        public RuntimeAnimatorController diverController;
        public RuntimeAnimatorController turtleController;
        Animator animator;

        // Start is called before the first frame update
        void Start()
        {
            animator = GameObject.FindWithTag("Player").GetComponent<Animator>();   
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter2D() 
        {
            animator.runtimeAnimatorController = turtleController as RuntimeAnimatorController;
        }
    }
}
