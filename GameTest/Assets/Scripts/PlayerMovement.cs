using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody rb;

	// rb
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
}
