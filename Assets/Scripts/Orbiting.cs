using UnityEngine;
using System.Collections;

public class Orbiting : MonoBehaviour {

	public  GameObject center  = null;
	const   float      speed   = 10.0f;
	private bool       running = true;

	void Update () {
		if (center && running) {
			float step = speed * Time.deltaTime;
			transform.RotateAround (center.transform.position, Vector3.up, step);
		}
	}

	public void Pause () {
		running = !running;
	}
}
