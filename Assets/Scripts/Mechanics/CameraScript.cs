using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class CameraScript : MonoBehaviour
    {
        public float speed = 0.009f;

        // Start is called before the first frame update
        void Start()
        {
            Destroy(GetComponent("CinemachineBrain"));
            transform.position = transform.position + new Vector3(0, 2.5f, 0);
        }

        // Update is called once per frame
        void Update()
        {   
            transform.Translate(speed, 0, 0);
        }
    }
}
