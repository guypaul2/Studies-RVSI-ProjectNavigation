using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyberSicknessController : MonoBehaviour
{
    // Start is called before the first frame update
    private int methodeToUse;

    void Start()
    {
        methodeToUse = 1;
        //1 for viewpointSnapping
        //2 for FOV
    }

    // Update is called once per frame
    void Update()
    {   
        OVRInput.Update();
        if(OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {//Si A press on manette gauche
            Debug.Log("A pressed");
            if (methodeToUse == 1)
            {
                methodeToUse = 2;
            }
            else
            {
                methodeToUse = 1;
            }

            scriptActivation(methodeToUse);
        }
            
    }

    void scriptActivation(int methodeToUse)
    {
        if(methodeToUse == 1)
        {
            gameObject.GetComponent<SnappingViewPoint>().enabled = true;
            gameObject.GetComponent<FOV>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<SnappingViewPoint>().enabled = false;
            gameObject.GetComponent<FOV>().enabled = true;
        }


    }

}
