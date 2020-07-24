using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDoors : MonoBehaviour
{

    public GameObject[] Doors;
    public GameObject[] InactiveDoors;


    void Start()
    {
        foreach (GameObject obj1 in Doors)
        {
            obj1.SetActive(true);
        }

        foreach (GameObject obj in InactiveDoors)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (RedButton.onOrOff2 == false)
        {
            foreach (GameObject obj1 in Doors)
            {
                obj1.SetActive(true);
            }

            foreach (GameObject obj in InactiveDoors)
            {
                obj.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject obj1 in Doors)
            {
                obj1.SetActive(false);
            }

            foreach (GameObject obj in InactiveDoors)
            {
                obj.SetActive(true);
            }
        }
    }
}
