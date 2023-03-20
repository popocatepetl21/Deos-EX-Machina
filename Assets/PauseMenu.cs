using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject Pause;
    bool paused;
    void Start()
    {
        Pause.active = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        pausing();
    }

    void pausing()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused == false)
            {
                Pause.active = true;
                Time.timeScale = 0f;
                paused = true;
            }
            else if(paused == true)
            {
                Time.timeScale = 1f;
                Pause.active = false;
                paused = false;
            }
        }
            
    }

    public void resume()
    {
        paused = false;
        Time.timeScale = 1f;
        Pause.active = false;
    }
}
