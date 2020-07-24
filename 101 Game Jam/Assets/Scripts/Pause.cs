using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject Pausemenu;

    // Start is called before the first frame update
    void Start()
    {
        GameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void Resume()
    {
        Pausemenu.SetActive(false);

        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void Paused()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
