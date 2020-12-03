using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

public class MakeFummeSpawn : MonoBehaviour
{
    ExposedProperty m_MyProperty;
    VisualEffect m_VFX;
    public Vector3 placeToPose;
    void Start()
    {
        m_VFX = GetComponent<VisualEffect>();
        m_MyProperty = "Pos"; // Assign A string
    }


    public void SetFumeePose(string nbChoix)
    {
        placeToPose = new Vector3(-10.0f, 0.0f, 35.0f);

        if (nbChoix == "1")
        {
            placeToPose = new Vector3(10.0f, 0.0f, 35.0f);
            Debug.Log("new Vector3(10.0f, 0.0f, 35.0f)");


        }
        else
        {
            placeToPose = new Vector3(0.0f, 0.0f, 35.0f);
            Debug.Log("new Vector3(0.0f, 0.0f, 35.0f)");

        }
        m_VFX.SetVector3(m_MyProperty, placeToPose);
        m_VFX.transform.position = placeToPose;
    }
}
