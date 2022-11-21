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
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
    }
}
