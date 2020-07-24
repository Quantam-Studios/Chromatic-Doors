using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArrow : MonoBehaviour
{
    public GameObject Page;
    public GameObject Page2;

    public void GoToPage()
    {
        Page.SetActive(true);
        Page2.SetActive(false);
        Time.timeScale = 0;
    }
}
