using UnityEngine;
using System.Collections;

public class PlayerMovementSingleAxis : MonoBehaviour 
{
	public string horizontalAxis = ("Horizontal");
	public string verticalAxis = ("Vertical");

	public float moveSpeed = 3.0f;
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += (Vector3.right * Input.GetAxis (horizontalAxis) + Vector3.forward * Input.GetAxis (verticalAxis)).normalized 
								* moveSpeed * Time.deltaTime;

		Vector3 turnDirection = Vector3.right * Input.GetAxis (horizontalAxis) + Vector3.forward * Input.GetAxis (verticalAxis);
		if (turnDirection.sqrMagnitude > 0.0f) 
		{
			transform.rotation = Quaternion.LookRotation (turnDirection, Vector3.up);
		}

	}
}
