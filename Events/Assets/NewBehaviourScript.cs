using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed;
    
    void Start()
    {
        moveSpeed = 1f;  
    }

    // Update is called once per frame
    void Update()
    {
        
         transform.Translate(moveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
