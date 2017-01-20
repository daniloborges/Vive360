using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

	public GameObject camera;
	private Vector3 follow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		follow = transform.position;
		follow.x = camera.transform.position.x;
		follow.z = camera.transform.position.z;
		transform.position = follow;
	}
}
