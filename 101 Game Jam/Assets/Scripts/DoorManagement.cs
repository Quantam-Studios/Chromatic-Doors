using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManagement : MonoBehaviour
{
    public GameObject YButton;
    public GameObject RButton;
    public GameObject PButton;
    public GameObject BButton;
    public GameObject TButton;
    public GameObject GButton;
    public GameObject OButton;
    public GameObject PurpleButton;
    public GameObject SButton;
    public GameObject GoldButton;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (YellowButton.Yellow == false)
        {
            YButton.SetActive(false);
        }

        if (RedButtonFin.Red == false)
        {
            RButton.SetActive(false);
        }

        if (PinkButtonFin.Pink == false)
        {
            PButton.SetActive(false);
        }

        if (BlueButtonFin.Blue == false)
        {
            BButton.SetActive(false);
        }

        if (TealButtonFin.Teal == false)
        {
            TButton.SetActive(false);
        }

        if (GreenButtonFin.Green == false)
        {
            GButton.SetActive(false);
        }

        if (OrangeButtonFin.Orange == false)
        {
            OButton.SetActive(false);
        }

        if (PurpleButtonFin.Purple == false)
        {
            PurpleButton.SetActive(false);
        }

        if (SilverButtonFin.Silver == false)
        {
            SButton.SetActive(false);
        }

        if (GoldButtonFin.Gold == false)
        {
            GoldButton.SetActive(false);
        }
    }
}
