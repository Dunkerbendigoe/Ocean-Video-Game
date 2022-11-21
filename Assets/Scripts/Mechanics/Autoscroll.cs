using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoscroll : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D() {
        Camera.main.gameObject.AddComponent<CameraScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
