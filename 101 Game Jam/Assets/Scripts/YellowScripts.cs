using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScripts : MonoBehaviour
{
    public GameObject Doors;

    void Start()
    {
        Doors.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (NormYellowButton.onOrOff4 == false)
        {
            Doors.SetActive(true);
        }
        else
        {
            Doors.SetActive(false);
        }
    }
}
