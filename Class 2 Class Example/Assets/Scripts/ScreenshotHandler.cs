/*****************************************************************************
// File Name : ScreenshotHandler.cs
// Author : ADD AUTHOR HERE
// Creation Date : ADD DATE HERE
//
// Brief Description : ADD DESCRIPTION HERE
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotHandler : MonoBehaviour
{

    private static ScreenshotHandler instance;

    private Camera myCamera;

    private bool takeScreenshotOnNextframe;

    private void Awake()
    {
        instance = this;
        myCamera = gameObject.GetComponent<Camera>();
    }

    private void OnPostRender()
    {
     if(takeScreenshotOnNextframe)
        {
            takeScreenshotOnNextframe = false;
            RenderTexture renderTexture = myCamera.targetTexture;

            Texture2D renderResult = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
            Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
            renderResult.ReadPixels(rect, 0, 0);
        }
    }
    private void TakeScreenshot(int width, int height)
    {
        myCamera.targetTexture = RenderTexture.GetTemporary(width, height, 16);
        takeScreenshotOnNextframe = true;
    }


}
