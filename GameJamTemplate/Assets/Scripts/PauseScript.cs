using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public GameObject pauseText;
    public GameObject resumeButton;
    public GameObject quitButton;

    // Start is called before the first frame update
    void Start()
    {
        // AJANHALLINTA SCENEEN
        //Time.timeScale = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if(Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            pauseText.SetActive(true);
            resumeButton.SetActive(true);
            quitButton.SetActive(true);
        }

        else
        {
            Time.timeScale = 1f;
            pauseText.SetActive(false);
            resumeButton.SetActive(false);
            quitButton.SetActive(false);
        }
    }
}
