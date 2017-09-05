using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody rb;
	Transform position;
	Transform position2;
	// rb
	void Start () {
		rb = GetComponent<Rigidbody>();
		position = position2;
	}
}
