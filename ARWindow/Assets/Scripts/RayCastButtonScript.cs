using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastButtonScript : MonoBehaviour
{
    string btnName;
    public GameObject mainScreenItems;
    public GameObject map;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                btnName = hit.transform.name;
                switch (btnName)
                {
                    case "InfoButton":
                        mainScreenItems.SetActive(false);
                        map.SetActive(true);
                        break;

                    case "BackButton":
                        Debug.Log("Check");
                        map.GetComponent<MapScaleScript>().canIncrease = false;
                        break;
                }
            }
        }
    }
}
