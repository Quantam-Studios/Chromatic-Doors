using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteFinishButton : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool White = true;
    public static bool WhiteOff;
    public float Toggle;
    public Sprite ToggledSprite;
    public GameObject EndMenu;

    void Start()
    {
        White = true;
        WhiteOff = false;
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
            Time.timeScale = 0;
            EndMenu.SetActive(true);
            Time.timeScale = 1;
        }
    }
}
