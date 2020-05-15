using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSystem : MonoBehaviour
{
    public SpriteRenderer sr;
    public float increaseAlpha;
    Color color;


    private void OnEnable()
    {
        color = sr.GetComponent<SpriteRenderer>().material.color;
        color.a = 0;
    }

    private void OnDisable()
    {
        color.a = 0;
        sr.color = color;
    }
    // Update is called once per frame
    void Update()
    {
        color.a += increaseAlpha;
        sr.color = color;
    }
}
