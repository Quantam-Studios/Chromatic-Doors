using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverButtonFin : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool Silver = true;
    public static bool SilverOff;
    public float Toggle;
    public Sprite ToggledSprite;
    public GameObject WinMenu;

    void Start()
    {
        Silver = true;
        SilverOff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Toggle % 2 == 0)
        {
            ToggledSprite = off;
            Silver = false;
        }
        else
        {
            ToggledSprite = on;
            Silver = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ToggledSprite;
            FindObjectOfType<AudioManager>().Play("Win");
            SilverOff = true;
        }
    }
}
