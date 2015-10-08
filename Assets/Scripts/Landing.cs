using UnityEngine;
using System.Collections;

public class Landing : MonoBehaviour {

	public GameObject target = null;
	public float      speed  = 0.0f;

	void Update () {
		if (target && speed > 0.0f) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
		}
	}
	
	public void Land() {
		speed = 1.0f;
	}
}
