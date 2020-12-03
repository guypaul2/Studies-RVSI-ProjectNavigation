using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
    }
    private Color m_oldColor = Color.white;
    void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        m_oldColor = render.material.color;
        render.material.color = Color.green;

    }
    void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldColor;
    }

}

