using UnityEngine;
using System.Collections;

public class Orbiting : MonoBehaviour {

	public  GameObject center  = null;
	const   float      step    = 0.3f;
	private bool       running = true;

	void Update () {
		if (center && running)
			transform.RotateAround (center.transform.position, Vector3.up, step);
	}

	public void Pause () {
		running = !running;
	}
}
