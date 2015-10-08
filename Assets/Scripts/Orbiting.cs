using UnityEngine;
using System.Collections;

public class Orbiting : MonoBehaviour {

	public GameObject center = null;
	const  float      speed  = 10.0f;

	void Update () {
		if(center)
			transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime);
	}
}
