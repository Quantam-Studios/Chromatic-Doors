using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeButtonFin : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool Orange = true;
    public static bool OrangeOff;
    public float Toggle;
    public Sprite ToggledSprite;
    public GameObject WinMenu;

    void Start()
    {
        Orange = true;
        OrangeOff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Toggle % 2 == 0)
        {
            ToggledSprite = off;
            Orange = false;
        }
        else
        {
            ToggledSprite = on;
            Orange = true;
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
            OrangeOff = true;
        }
    }
}
