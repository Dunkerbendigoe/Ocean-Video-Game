using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseGame : MonoBehaviour
{
    public KeyCode pauseKey = KeyCode.Escape;
    public MonoBehaviour script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            if (Time.timeScale > 0)
            {   
                Debug.Log("Paused Game");
                Time.timeScale = 0;
                transform.Translate(0, 0, 0);
                script.enabled = false;
            }
            else
            {
                Debug.Log("Unpaused Game");
                Time.timeScale = 1;
                transform.Translate(1.0f, 0, 0);
                script.enabled = true;
            }
        }
    }
}
