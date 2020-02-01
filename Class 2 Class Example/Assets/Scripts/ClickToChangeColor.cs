/*
*(Christopher Green)
*(ClickToChangeColor.cs)
* (Assignment 2)
* (This script is responsible for changing the color of the colorable blocks on the way when they are clicked)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToChangeColor : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                ColorBlock objectHit = hitInfo.collider.GetComponent<ColorBlock>();

                if (objectHit != null)
                {
                    objectHit.DoChangeColor();

                }
            }
        }


    }
}

