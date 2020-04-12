using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {


	public Transform lookAt;

	public float distance = 10.0f;
	private float currentX = 0.0f;
	public float currentY = 30.0f;

	private void Start() {
		distance = lookAt.position.z- gameObject.transform.position.z;
	}

	// Update is called once per frame
	void LateUpdate () {
		Vector3 dir = new Vector3 (0, 0, -(distance));
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		transform.position = lookAt.position +  dir;
	}
}
