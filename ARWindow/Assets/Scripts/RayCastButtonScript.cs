using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastButtonScript : MonoBehaviour
{
    string btnName; //The name of the button
    public GameObject mainScreenItems; //Collection of game objects for the Main Screen
    public GameObject map; //The map for the information about the class

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When a user taps/clicks on the screen, a raycast is use to check to see if they hit any buttons that are named and listed in the switch function
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                btnName = hit.transform.name;
                switch (btnName)
                {
                    //Case for if the user clicks on a button name InfoButton, then it will tell mainScreenItems to be inactive, map to be active,
                    //and tell the CanIncrease boolean from MapScaleScript to be true
                    case "InfoButton":
                        mainScreenItems.SetActive(false);
                        map.SetActive(true);
                        map.GetComponent<MapScaleScript>().canIncrease = true;
                        break;
                    
                    //Case for if the user clicks on a button name BackButton, then it will tell the CanIncrease boolean from MapScaleScript to be false
                    case "BackButton":
                        Debug.Log("Check");
                        map.GetComponent<MapScaleScript>().canIncrease = false;
                        break;
                }
            }
        }
    }
}
