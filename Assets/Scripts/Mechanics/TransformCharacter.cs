using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class TransformCharacter : MonoBehaviour
    {
        public RuntimeAnimatorController previousController;
        public RuntimeAnimatorController newController;
        Animator animator;
        BoxCollider2D boxCollider2D;

        // Start is called before the first frame update
        void Start()
        {
            animator = GameObject.FindWithTag("Player").GetComponent<Animator>();
            boxCollider2D = GameObject.FindWithTag("Player").GetComponent<BoxCollider2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter2D() 
        {
            animator.runtimeAnimatorController = newController as RuntimeAnimatorController;
   
            if (previousController.name == "Player") 
            {
                boxCollider2D.size = new Vector2(1.25f, 0.625f);
            }
            else if (previousController.name == "Turtle")
            {
                boxCollider2D.size = new Vector2(1.0f, 2.375f);
            }
        }
    }
}
