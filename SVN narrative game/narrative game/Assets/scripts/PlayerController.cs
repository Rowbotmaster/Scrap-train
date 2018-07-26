using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

	// a serialized field shows up in inspector
	//[SerializedField]
	public float speed = 3f;

	public float TurnSpeed = 3f;

	private PlayerMotor motor;

	// Use this for initialization
	void Start () 
	{
		motor = GetComponent<PlayerMotor> ();
	}

	// Update is called once per frame
	void Update () 
	{
		float _xMove = Input.GetAxisRaw ("Horizontal");
		float _zMove = Input.GetAxisRaw ("Vertical");

		Vector3 _moveHorizontal = transform.right * _xMove;
		Vector3 _moveVertical = transform.forward * _zMove;

		Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * speed;

		motor.Move (_velocity);

		float _yRotate = Input.GetAxisRaw ("Mouse X");

		Vector3 _rotation = new Vector3 (0f, _yRotate, 0f) * TurnSpeed;

		motor.Rotate (_rotation);

		float _xRotate = Input.GetAxisRaw ("Mouse Y");

		Vector3 _cameraRotation = new Vector3 (0f, _xRotate, 0f) * TurnSpeed;

		motor.RotateCamera (_cameraRotation);
	}

}
