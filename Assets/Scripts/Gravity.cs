using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {
	
	private float   dt = 0.01f;
	private Vector3 vh = Vector3.zero;
	
	public Vector3 position {
		get { return gameObject.transform.position; }
		set { gameObject.transform.position = value; }
	}
	
	public Vector3 velocity {
		set { vh = value + 0.5f * dt * force; }
	}
	
	public Vector3 force {
		get {
			Vector3 r = this.position;
			return -r / Mathf.Pow (r.x * r.x + r.y * r.y + r.z * r.z, 1.5f);
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		position += dt * vh;
		vh += dt * force;
	}
}
