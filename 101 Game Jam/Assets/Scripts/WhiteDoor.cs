using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteDoor : MonoBehaviour
{
    public GameObject WinMenu;
    // Start is called before the first frame update
    void Start()
    {
        WinMenu.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("Win");
            WinMenu.SetActive(true);
        }
    }
}
