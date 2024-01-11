using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public CharacterController Controller;
    public Transform PitchWrapper;
    public float MoveSpeed = 4.0f;
    public float TurnSpeed = 45.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * TurnSpeed, 0);
        PitchWrapper.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * -TurnSpeed, 0, 0);

        Vector3 MoveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        MoveDirection = transform.TransformDirection(MoveDirection);
        MoveDirection *= MoveSpeed;
        Controller.SimpleMove(MoveDirection);
	}
}
