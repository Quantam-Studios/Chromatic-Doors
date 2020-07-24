using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLvl : MonoBehaviour
{
    public int level;
    public int LevelLoad;

    public void Start()
    {
        LevelLoad = SceneManager.GetActiveScene().buildIndex + level;
    }

    public void GoToLevelX()
    {
        SceneManager.LoadScene(LevelLoad);
    }
}
