using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float PlayerSpeed = 4f; //how fast the player will move

	Vector3 moving; // Creates a vector for player's movement path
	Rigidbody robot; // the robot



	// Use this for initialization before game start
	void Awake () 
	{
		robot = GetComponent <Rigidbody> (); //intializing robot with RigidBody component
	}
	
	// Update is called once per frame for physics
	void FixedUpdate () 
	{
		float h = Input.GetAxisRaw ("Horizontal"); // Initializing horizontal movement from player input.
		float v = Input.GetAxisRaw ("Vertical"); // Initializing vertical movement from player input.

		Move (h, v);
	
	}

	void Move (float hor, float vert)
	{
		moving.Set (hor, 0f, vert); //setting the vector to the players input

		moving = moving.normalized * PlayerSpeed * Time.deltaTime; //initializes vector with new set position

		robot.MovePosition (transform.position + moving); //moves the character to the set position of the new vector.
	}
}
