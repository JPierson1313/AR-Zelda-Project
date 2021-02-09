using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSystem : MonoBehaviour
{
    public SpriteRenderer sr; //The Sprite Renderer of the object this script is attach to
    public float increaseAlpha; //Float use to increase the opaqueness of the sprite
    Color color; //Use to get the color of the sprtie


    private void OnEnable()
    {
        //When this script is enabled, allow the color to get the color material from the sprite renderer and set the color alpha to zero
        color = sr.GetComponent<SpriteRenderer>().material.color;
        color.a = 0;
    }

    private void OnDisable()
    {
        //When this script is disabled, set the color alpha to zero and set the sprite renderer's color to color
        color.a = 0;
        sr.color = color;
    }
    // Update is called once per frame
    void Update()
    {
        //This is for when the script is enabled by having the color alpha increase from full transparency to full opaqueness by using the increaseAlpha float
        //While also setting the sprite renderer's color to color
        color.a += increaseAlpha;
        sr.color = color;
    }
}
