using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    public class Autoscroll : MonoBehaviour
    {   
        //GameObject player;

        // Start is called before the first frame update
        void Start()
        {
            //player = GameObject.FindWithTag("Player");
        }

        void OnTriggerEnter2D() {
            Camera.main.gameObject.AddComponent<CameraScript>();
            //player.AddComponent<NoClipperton>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
