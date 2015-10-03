using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

	public Cardboard  Handle = null;
	public GameObject Screen = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Handle.Triggered && Screen) {
			Destroy (Screen);
			Screen = null;
		}
	}
}
