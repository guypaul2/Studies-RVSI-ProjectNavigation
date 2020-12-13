using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    public Camera myCam;


    // Start is called before the first frame update
    void Start()
    {

        screenBounds = myCam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, myCam.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 1;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 1;

    }
    // Update is called once per frame

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objectWidth, screenBounds.x * -1 - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y * -1 - objectWidth);
        transform.position = viewPos;
    }
}
