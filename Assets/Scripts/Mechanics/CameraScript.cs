using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speed = 0.003f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(GetComponent("CinemachineBrain"));

        // Move camera to fit autoscroll section
        transform.position = transform.position + new Vector3(0, 2.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(speed, 0, 0);
    }
}
