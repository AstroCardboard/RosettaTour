using UnityEngine;
using System.Collections;

public class Landing : MonoBehaviour {

	public GameObject target = null;
	public float      speed  = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target && speed > 0.0f) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
		}
	}
	
	public void StartLanding() {
		speed = 1.0f;
	}
}
