using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleButton : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool onOrOff7 = true;
    public float Toggle;
    public Sprite ToggledSprite;

    void Start()
    {
        onOrOff7 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Toggle % 2 == 0)
        {
            ToggledSprite = off;
            onOrOff7 = false;
        }
        else
        {
            ToggledSprite = on;
            onOrOff7 = true;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ToggledSprite;
            FindObjectOfType<AudioManager>().Play("Button");
            Toggle += 1;
        }
    }
}
