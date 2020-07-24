using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetCurrentLvlScript : MonoBehaviour
{
    Text Lvl;

    // Start is called before the first frame update
    void Start()
    {

        Lvl = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            Lvl.text = "You unlocked the Yellow door on the main menu!";
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Lvl.text = "You unlocked the Red door on the main menu!";
        }

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Lvl.text = "You unlocked the Pink door on the main menu!";
        }

        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Lvl.text = "You unlocked the Blue door on the main menu!";
        }

        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            Lvl.text = "You unlocked the Green door on the main menu!";
        }

        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            Lvl.text = "You unlocked the Purple door on the main menu!";
        }

    }
}
