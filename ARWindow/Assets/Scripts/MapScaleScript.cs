using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScaleScript : MonoBehaviour
{
    public bool canIncrease; //Boolean used to see if we can increase the size of the map or not
    public GameObject mainScreenItems; //Collection of game objects that are used for the Main Screen

    void Update()
    {
        //If canIncrease is true, then we add 0.05 to both the x and y local scale until they are greater than 0.5 in the x and y local scale
        if(canIncrease)
        {
            if (transform.localScale.x < 0.5f && transform.localScale.y < 0.5f)
            {
                transform.localScale += new Vector3(0.05f, 0.05f, 0);
            }
        }
        
        //If canIncrease is false, then we add -0.05 to both the x and y local scale until they are less than 0 in the x and y local scale
        //When the local scale of both x and y are less than 0, then the mainScreenItems game object will be active and the Map game object will be inactive
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
