/*
*(Christopher Green)
*(ChangeColorBehavior.cs)
* (Assignment 2)
* (This script is responsible for setting the color of the block to be changed when it is clicked)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWhite : ChangeColorBehavior
{
    public override void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}

public class ChangeColorBlue : ChangeColorBehavior
{
    public override void ChangeColor()
    {
        Debug.Log("Color Change blue");
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}

public class ChangeColorRed : ChangeColorBehavior
{
    public override void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

public class ChangeColorGreen : ChangeColorBehavior
{
    public override void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}

public class ChangeColorYellow : ChangeColorBehavior
{
    public override void ChangeColor()
    { 
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}

public class ChangeColorCyan : ChangeColorBehavior
{
    public override void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}

public class ChangeColorMagenta : ChangeColorBehavior
{
    public override void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.magenta;
    }
}

