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
        BoxCollider2D boxCollider2D;

        // Start is called before the first frame update
        void Start()
        {
            boxCollider2D = GameObject.FindWithTag("Player").GetComponent<BoxCollider2D>();
            animator = GameObject.FindWithTag("Player").GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter2D() 
        {
            animator.runtimeAnimatorController = turtleController as RuntimeAnimatorController;
            boxCollider2D.size = new Vector2(1.25f, 0.625f);
        }
    }
}
