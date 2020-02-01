/*
*(Christopher Green)
*(ColorBlock.cs)
* (Assignment 2)
* (This script the general functionality of the bolcks that the player can color on the wall.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ColorBlock : MonoBehaviour
{
    public ChangeColorBehavior ChangeColorBehavior { get; set; }

    private Text colorText;

    private string color;

    public virtual void DoChangeColor() { ChangeColorBehavior.ChangeColor(); }

    public void Start()
    {
        colorText = GameObject.Find("Canvas").transform.GetChild(0).GetChild(0).GetComponent<Text>();

        colorText.text = "Color: Blue";

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            color = "None";

            Destroy(GetComponent<ChangeColorBehavior>());
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorWhite>();
            DoChangeColor();

            colorText.text = "Color: " + color;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            color = "Red";

            Destroy(GetComponent<ChangeColorBehavior>());
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorRed>();

            colorText.text = "Color: " + color;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            color = "Blue";

            Destroy(GetComponent<ChangeColorBehavior>());
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorBlue>();

            colorText.text = "Color: " + color;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            color = "Green";

            Destroy(GetComponent<ChangeColorBehavior>());
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorGreen>();

            colorText.text = "Color: " + color;
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            color = "Yellow";

            Destroy(GetComponent<ChangeColorBehavior>());
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorYellow>();

            colorText.text = "Color: " + color;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            color = "Cyan";

            Destroy(GetComponent<ChangeColorBehavior>());
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorCyan>();

            colorText.text = "Color: " + color;
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            color = "Magenta";

            Destroy(GetComponent<ChangeColorBehavior>());
            ChangeColorBehavior = gameObject.AddComponent<ChangeColorMagenta>();

            colorText.text = "Color: " + color;
        }
    }
}

