using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowButton : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool Yellow = true;
    public static bool YellowOff;
    public float Toggle;
    public Sprite ToggledSprite;
    public GameObject WinMenu;
    
    void Start()
    {
        Yellow = true;
        YellowOff = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Toggle % 2 == 0)
        {
            ToggledSprite = off;
        }
        else
        {
            ToggledSprite = on;
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
            Yellow = false;
            YellowOff = true;
        }
    }

}
