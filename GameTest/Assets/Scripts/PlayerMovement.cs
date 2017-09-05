using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody rb;
	Transform position;

	// rb
	void Start () {
		rb = GetComponent<Rigidbody>();

		position = this.Transform;

		//positiondelposition...
	}
}
