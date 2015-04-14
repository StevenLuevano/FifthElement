using UnityEngine;
using System.Collections;

public class PlayerMoveSingleAxis : MonoBehaviour 
{
	public string horizontalAxis = ("Horizontal");
	public string verticalAxis = ("Vertical");
	
	public float moveSpeed = 6.0f;
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += (Vector3.right * Input.GetAxisRaw(horizontalAxis) + Vector3.forward * Input.GetAxisRaw(verticalAxis)).normalized 
			* moveSpeed * Time.deltaTime;
		
		Vector3 turnDirection = Vector3.right * Input.GetAxisRaw(horizontalAxis) + Vector3.forward * Input.GetAxisRaw(verticalAxis);
		if (turnDirection.sqrMagnitude > 0.0f) 
		{
			transform.rotation = Quaternion.LookRotation (turnDirection, Vector3.up);
		}
		
	}
}
