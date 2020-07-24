using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButtonFin : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool Blue = true;
    public static bool BlueOff;
    public float Toggle;
    public Sprite ToggledSprite;
    public GameObject WinMenu;

    void Start()
    {
        Blue = true;
        BlueOff = false;
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
            BlueOff = true;
            Blue = false;
        }
    }
}
