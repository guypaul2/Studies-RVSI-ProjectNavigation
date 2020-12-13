using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

public class MakeFummeSpawn : MonoBehaviour
{
    ExposedProperty m_MyProperty_Size;
    ExposedProperty m_MyProperty_Velocity_Y;

    VisualEffect m_VFX;

    void Start()
    {
        m_VFX = GetComponent<VisualEffect>();
        m_MyProperty_Size = "Size"; // Assign A string
        m_MyProperty_Velocity_Y = "Velocity_Y"; // Assign A string
    }


    public void SetFumeePose(string nbChoix)
    {

        if (nbChoix == "1")
        {//Mauvais
            m_VFX.SetFloat(m_MyProperty_Velocity_Y, 2.5f);
            m_VFX.SetFloat(m_MyProperty_Size, 3.5f);
        }
        else
        {//Bon
            m_VFX.SetFloat(m_MyProperty_Velocity_Y, 0.5f);
            m_VFX.SetFloat(m_MyProperty_Size, 1.5f);
        }
    }
}
