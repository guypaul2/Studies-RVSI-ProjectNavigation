using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class DeclancherEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject palyer;
    public GameObject objEvent;
    public float distanceAffichage = 5;
    public GameObject questionPanel;
    public Light directLight;

    private float pasColor = 35.0f;
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
        Color bc = directLight.color;
        float bi = directLight.intensity;

        if (nbChoix == "1")
        {//Mauvais
            button1.enabled = false;
            button2.interactable = false;
            impactCarbon = imapctMauvaisChoix;
            directLight.DOColor(new Color(bc.r - (pasColor*2.0f)/255.0f, bc.g - (pasColor) / 255.0f, bc.b - (pasColor * 2.0f) / 255.0f, bc.a), 2.0f);
            directLight.DOIntensity(bi - 0.2f, 2.0f);
        }
        else
        {//Bon
            button2.enabled = false;
            button1.interactable = false;
            impactCarbon = imapctBonChoix;

            if(bc.r != 1.0f)
            {
                directLight.DOColor(new Color(bc.r + (pasColor * 2.0f) / 255.0f, bc.g + (pasColor) / 255.0f, bc.b + (pasColor * 2.0f) / 255.0f, bc.a), 2.0f);
                directLight.DOIntensity(bi + 0.2f, 2.0f);
            }
        }

        this.gameObject.transform.GetChild(0).DOScale(new Vector3(0, 0, 0), 1.0f);
    }
}
