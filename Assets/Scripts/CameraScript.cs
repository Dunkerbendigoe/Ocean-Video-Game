using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public float speed;

    public Transform player;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        //this line is for autoscroller
        transform.Translate(speed, 0, 0);

        //this line is for tracking the character
        //transform.position = new Vector3(player.position.x + 6, 0, -10);
    }
}
