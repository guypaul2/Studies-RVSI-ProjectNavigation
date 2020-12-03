using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclancherEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject palyer;
    public GameObject objEvent;
    public float distanceAffichage = 10;
    public GameObject questionPanel;

    private bool isShowing;

    void Start()
    {
        isShowing = false;
        questionPanel.SetActive(isShowing);
    }
    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(palyer.transform.position, objEvent.transform.position) < distanceAffichage && !isShowing)
        {
            isShowing = !isShowing;
            questionPanel.SetActive(isShowing);
        }

        if (Vector3.Distance(palyer.transform.position, objEvent.transform.position) > distanceAffichage && isShowing)
        {
            isShowing = !isShowing;
            questionPanel.SetActive(isShowing);
        }
    }
}
