using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ConstructionScript : MonoBehaviour
{
	// Use this for initialization
	public virtual void Start ()
    {
        if (Application.isPlaying)
        {
            this.enabled = false;
        }
    }
}
