using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

	public GameObject cameraToFollow;
	private Vector3 follow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (cameraToFollow != null) {
            follow = transform.position;
            follow.x = cameraToFollow.transform.position.x/3;
            follow.z = cameraToFollow.transform.position.z/3;
            transform.position = follow;
        }
	}
}
