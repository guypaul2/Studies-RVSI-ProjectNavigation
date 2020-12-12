using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateStar : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 100.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, rotationSpeed) * Time.deltaTime);
    }
}
