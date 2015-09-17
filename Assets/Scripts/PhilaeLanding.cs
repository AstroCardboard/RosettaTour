using UnityEngine;
using System.Collections;

public class PhilaeLanding : MonoBehaviour {
	
	private float   dt = 0.01f;
	private Vector3 vh = Vector3.zero;
	
	public Vector3 position {
		get { return gameObject.transform.position; }
		set { gameObject.transform.position = value; }
	}
	
	public Vector3 velocity {
		set { vh = value; }
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		position += dt * vh;
		if (position [0] >= -3.5)
			vh[0] = 0.0f;
	}
}
