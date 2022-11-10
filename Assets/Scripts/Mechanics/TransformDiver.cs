using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDiver : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite Turtle;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() 
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            spriteRenderer.sprite = Turtle;
        }
    }
}
