using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public GameObject LevelSelectMenu;

    public void GoToLevels()
    {
        LevelSelectMenu.SetActive(true);
        Time.timeScale = 0;
    }


}
