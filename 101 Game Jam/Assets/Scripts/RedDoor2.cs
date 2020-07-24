using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDoor2 : MonoBehaviour
{
    public GameObject Doors;

    void Start()
    {
        Doors.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (RedButton2.onOrOff5 == false)
        {
            Doors.SetActive(true);
        }
        else
        {
            Doors.SetActive(false);
        }
    }
}
