using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsManager : MonoBehaviour
{
    public UnityEvent EventSpaceBar;
    // Start is called before the first frame update
    
    void Update() { 
    if(Input.GetKeyDown(KeyCode.Space))
        {
           EventSpaceBar.Invoke();
        }
        
    }
}
