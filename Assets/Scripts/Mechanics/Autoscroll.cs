using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class Autoscroll : MonoBehaviour
    {   
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter2D() {
            Camera.main.gameObject.AddComponent<CameraScript>();
        }
    }
}
