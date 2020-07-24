using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleButtonFin : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool Purple = true;
    public static bool PurpleOff;
    public float Toggle;
    public Sprite ToggledSprite;
    public GameObject WinMenu;

    void Start()
    {
        Purple = true;
        PurpleOff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Toggle % 2 == 0)
        {
            ToggledSprite = off;
            Purple = false;
        }
        else
        {
            ToggledSprite = on;
            Purple = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ToggledSprite;
            FindObjectOfType<AudioManager>().Play("Win");
            Time.timeScale = 0;
            WinMenu.SetActive(true);
            PurpleOff = true;
            Debug.Log("Purple");
        }
    }
}
