/*
*(Christopher Green)
*(ColorYellow.cs)
* (Assignment 2)
* (This script is a class of block that sets ChangeColorBehavior to the corresponding color as identified by the class name.)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorYellow : ColorBlock
{

    private void Awake()
    {
        ChangeColorBehavior = gameObject.AddComponent<ChangeColorYellow>();
    }
}
