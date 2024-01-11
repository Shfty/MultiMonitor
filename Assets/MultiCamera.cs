using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiCamera : ConstructionScript
{
    public float LeftMonitorAngle = -40.0f;
    public float RightMonitorAngle = 40.0f;

    private MonitorCamera LeftCamera;
    private MonitorCamera CenterCamera;
    private MonitorCamera RightCamera;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        LeftCamera = transform.Find("LeftCamera").GetComponent<MonitorCamera>();
        CenterCamera = transform.Find("CenterCamera").GetComponent<MonitorCamera>();
        RightCamera = transform.Find("RightCamera").GetComponent<MonitorCamera>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        LeftCamera.transform.localRotation = Quaternion.AngleAxis(LeftMonitorAngle, Vector3.up);
        RightCamera.transform.localRotation = Quaternion.AngleAxis(RightMonitorAngle, Vector3.up);
    }
}
