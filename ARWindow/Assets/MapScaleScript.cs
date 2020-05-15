using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScaleScript : MonoBehaviour
{
    public bool canIncrease;
    public GameObject mainScreenItems;

    private void OnEnable()
    {
        canIncrease = true;
       
    }

    private void OnDisable()
    {
        transform.localScale += new Vector3(0, 0, 0);
    }
    private void Update()
    {
        if(canIncrease)
        {
            if (transform.localScale.x < 0.5f && transform.localScale.y < 0.5f)
            {
                transform.localScale += new Vector3(0.05f, 0.05f, 0);
            }
        }

        if(!canIncrease)
        {
            transform.localScale += new Vector3(-0.05f, -0.05f, 0);

            if(transform.localScale.x < 0 && transform.localScale.y < 0)
            {
                mainScreenItems.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}
