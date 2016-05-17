using UnityEngine;
using System.Collections;

public class Spinning : MonoBehaviour {

	const   float speed   = 10.0f;
	private bool  running = true;

	// Update is called once per frame
	void Update () {
		if (running)
			transform.Rotate (-speed * Time.deltaTime * Vector3.right);
	}

	public void Pause () {
		running = !running;
	}
}
