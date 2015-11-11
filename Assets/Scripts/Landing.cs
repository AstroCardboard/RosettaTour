using UnityEngine;
using System.Collections;

public class Landing : MonoBehaviour {

	public  GameObject target  = null;
	const   float      speed   = 1.0f;
	private bool       running = true;
	private bool       landing = false;

	void Update () {
		if (target && running && landing) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
		}
	}

	public void Pause () {
		running = !running;
	}

	public void Land () {
		landing = true;
	}
}
