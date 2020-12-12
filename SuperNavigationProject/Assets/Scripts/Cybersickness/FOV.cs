using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOV : MonoBehaviour
{
    public float maxCamDistance = 10f;
    public float minCamFOV = 60f;
    public float fovSpeed = 1f;


    public Transform target;
    public Camera myCam;

    float initialFOV;

    void Start()
    {
        //myCam = this.GetComponent<Camera>();

        initialFOV = myCam.fieldOfView;
    }

    void ResetFOV()
    {
        myCam.fieldOfView = initialFOV;
    }
    // Update is called once per frame
    void Update()
    {
        myCam.fieldOfView = minCamFOV;

        //Debug.Log("CAM FOV + " + myCam.fieldOfView);

        /*
        if (target == null)
        {
            ResetFOV();
        }
        else
        {
            myCam.transform.LookAt(target);
            if (Vector3.Distance(transform.position, target.position) > maxCamDistance)
            {
                if (myCam.fieldOfView <= minCamFOV)
                {
                    myCam.fieldOfView = minCamFOV;
                }
                else
                {
                    myCam.fieldOfView -= fovSpeed;
                }

            }
            else if (Vector3.Distance(transform.position, target.position) < maxCamDistance)
            {
                myCam.fieldOfView += fovSpeed;
                if (myCam.fieldOfView >= initialFOV)
                {
                    ResetFOV();

                }
            }
        }
        */
    }
}
