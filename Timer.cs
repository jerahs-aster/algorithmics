using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float minutes, seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;

        if(seconds < 0)
        {
            if(minutes > 0)
            {
                minutes -= 1;
                seconds = 60;
            }
        } 
        else
            {
            //Restart Scene
                //Gets the index of the current scene
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                //Loads scene with current scene's index as variable
            SceneManager.LoadScene(sceneIndex);
            }
    }
}
