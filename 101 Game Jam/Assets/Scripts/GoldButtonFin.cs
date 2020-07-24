using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldButtonFin : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool Gold = true;
    public static bool GoldOff;
    public float Toggle;
    public Sprite ToggledSprite;
    public GameObject WinMenu;

    void Start()
    {
        Gold = true;
        GoldOff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Toggle % 2 == 0)
        {
            ToggledSprite = off;
            Gold = false;
        }
        else
        {
            ToggledSprite = on;
            Gold = true;
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
            GoldOff = true;
            Debug.Log("Gold");
        }
    }
}
