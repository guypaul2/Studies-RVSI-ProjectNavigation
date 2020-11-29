using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappingViewPoint : MonoBehaviour
{
    /// <summary>
    /// Threshold for snapping invocation in degrees by seconds
    /// </summary>
    [Tooltip("Threshold for snapping invocation in degrees by second")]
    public float snappingThreshold = 15.0f;

    public GameObject snappingSphere;

    private Vector3 previousEuler;
    private float updateInterval = 0.1f;
    private bool stopCheckRotation;

    // Start is called before the first frame update
    void Start()
    {
        previousEuler = transform.rotation.eulerAngles;
        stopCheckRotation = false;
        InvokeRepeating("UpdateInterval", updateInterval, updateInterval);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateInterval()
    {
        Vector3 euler = transform.rotation.eulerAngles;

        float diffAngle = Mathf.Abs(euler.y - previousEuler.y);

        //Handle 360 to 0 step
        if (diffAngle > 300)
        {
            diffAngle = Mathf.Abs(diffAngle - 360);
        }


        if ((diffAngle * 60) * Time.deltaTime >= snappingThreshold)
        {
            ActivateSnapping();
            Debug.Log("ActivateSnapping");
        }
        previousEuler = transform.rotation.eulerAngles;
    }

    void ActivateSnapping()
    {
        if (!stopCheckRotation)
        {
            snappingSphere.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
            stopCheckRotation = true;
            Invoke("DesactivateSnapping", 2.0f);
        }

    }

    void DesactivateSnapping()
    {
        snappingSphere.transform.localScale = new Vector3(-0.01f, -0.01f, -0.01f);
        stopCheckRotation = false;

    }

}
