// This is a collection of Effects that modify the behavior of Rosetta and Philae
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class ShapeGlow : MonoBehaviour {
	private Vector3 startingPosition;
	private Vector3 startingScale;
	
	void Start () {
		startingPosition = transform.localPosition;
		startingScale = transform.localScale;
		SetGazedAt(false);
	}
	
	public void SetGazedAt(bool gazedAt) {
		/// Enlarge
		//GetComponent<Transform>().localScale = gazedAt ? 3*startingScale : startingScale;
		/// Glow
		Behaviour h = (Behaviour)GetComponent("Halo");
		h.enabled = gazedAt ? true : false;
		/// Allow Click Button to Animate
		//ShowText
	}

	public void StartLanding() {
		Landing philae_landing = GetComponent<Landing> ();
		philae_landing.speed = 1.0f;
	}
}
