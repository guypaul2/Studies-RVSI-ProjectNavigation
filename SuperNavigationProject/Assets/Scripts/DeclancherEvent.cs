﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeclancherEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject palyer;
    public GameObject objEvent;
    public float distanceAffichage = 5;
    public GameObject questionPanel;

    public Button button1;
    public Button button2;
    [HideInInspector] public float impactCarbon = 0.0f;
    public float imapctBonChoix;
    public float imapctMauvaisChoix;

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
            //myCam.fieldOfView = 60f;
        }

        if (Vector3.Distance(palyer.transform.position, objEvent.transform.position) > distanceAffichage && isShowing)
        {
            isShowing = !isShowing;
            questionPanel.SetActive(isShowing);
            //myCam.fieldOfView = 90f;
        }
    }

    public void ButtonAnswer(string nbChoix)
    {

        if (nbChoix == "1")
        {//Mauvais
            button1.enabled = false;
            button2.interactable = false;
            impactCarbon = imapctMauvaisChoix;
        }
        else
        {//Bon
            button2.enabled = false;
            button1.interactable = false;
            impactCarbon = imapctBonChoix;
        }
    }
}
