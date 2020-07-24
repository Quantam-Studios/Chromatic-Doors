using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    public static bool onOrOff3 = true;
    public float Toggle;
    public Sprite ToggledSprite;

    void Start()
    {
        onOrOff3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Toggle % 2 == 0)
        {
            ToggledSprite = off;
            onOrOff3 = false;
        }
        else
        {
            ToggledSprite = on;
            onOrOff3 = true;
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
