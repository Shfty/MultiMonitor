using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorCamera : ConstructionScript
{
    public float MonitorDistance = 1.0f;
    public float MonitorSizeInches = 27.0f;
    public float MonitorAspectRatio = 16.0f / 9.0f;
    public float MonitorAngle = 0.0f;

    private float InchesToMeters = 0.0254f;
    
    // Update is called once per frame
    void Update()
    {
        float h = Mathf.Sqrt(Mathf.Pow(MonitorSizeInches * InchesToMeters, 2) / (Mathf.Pow(MonitorAspectRatio, 2) + 1));
        float w = MonitorAspectRatio * h;
        Vector3 foo = new Vector3(0.0f, h * 0.5f, MonitorDistance).normalized;
        float VFOV = 2.0f * Mathf.Rad2Deg * Mathf.Acos(Vector3.Dot(foo, Vector3.forward));
        float HFOV = VFOV * MonitorAspectRatio;
        Debug.Log(HFOV);

        GetComponent<Camera>().fieldOfView = VFOV;
        GetComponent<Camera>().nearClipPlane = MonitorDistance;
        GetComponent<Camera>().transform.localRotation = Quaternion.AngleAxis(MonitorAngle, Vector3.up);
    }
}
