using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{

    public GameObject LevelSelectMenu;

    public void GoToMenu()
    {
        LevelSelectMenu.SetActive(false);
        Time.timeScale = 1;
    }


}
