using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TestVirtualButton : MonoBehaviour
{
    public Material m_VirtualButtonDefault;
    public Material m_VirtualButtonPressed;

    VirtualButtonBehaviour[] virtualButtonBehaviours;

    // Start is called before the first frame update
    void Awake()
    {
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < virtualButtonBehaviours.Length; ++i)
        {
            virtualButtonBehaviours[i].RegisterOnButtonPressed(OnButtonPressed);
            virtualButtonBehaviours[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);

        //SetVirtualButtonMaterial(m_VirtualButtonDefault);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);

        //SetVirtualButtonMaterial(m_VirtualButtonDefault);        
    }

    void SetVirtualButtonMaterial(Material material)
    {
        // Set the Virtual Button material
        for (int i = 0; i < virtualButtonBehaviours.Length; ++i)
        {
            if (material != null)
            {
                virtualButtonBehaviours[i].GetComponent<MeshRenderer>().sharedMaterial = material;
            }
        }
    }
}
