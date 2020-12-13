using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    public DeclancherEvent[] questions;
    public GameObject endPanel;
    public GameObject txt;

    private bool gameEnded = false;
    private float totalCarbon;
    // Start is called before the first frame update
    void Start()
    {
        endPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        gameEnded = true;
        totalCarbon = 0.0f;

        foreach (DeclancherEvent q in questions)
        {
            if(q.impactCarbon == 0.0f)
            {
                gameEnded = false;
            }
            else
            {
                totalCarbon += q.impactCarbon;
            }
        }

        if (gameEnded)
        {
            displayEndPanel(totalCarbon);
        }

    }

    public void displayEndPanel(float totalCarbon)
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = "Félicitation vous venez de terminer cette simulation. " +
            "Sur un maximum de 7380g de CO2 votre impact carbon de la journée a été de " + totalCarbon +"g de C02. " +
            "Ce qui est égale à l'emmission d'un trajet de " + (int)((totalCarbon * 19.0f) / 1441.0f) + "km d'une voiture roulant à l'essence." ;

        endPanel.SetActive(true);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Cyb", LoadSceneMode.Single);
    }
}
