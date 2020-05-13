using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;


	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

	}

	void FixedUpdate ()
	{

	}
}
