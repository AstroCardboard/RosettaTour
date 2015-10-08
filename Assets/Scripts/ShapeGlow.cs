// This is a collection of Effects that modify the behavior of Rosetta and Philae
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class ShapeGlow : MonoBehaviour {

	private Vector3 startingScale;
	
	void Start () {
		startingScale = transform.localScale;
		SetGazedAt(false);
	}
	
	public void SetGazedAt(bool gazedAt) {
		/// Enlarge
		//GetComponent<Transform>().localScale = gazedAt ? 3*startingScale : startingScale;

		/// Glow
		((Behaviour)GetComponent ("Halo")).enabled = gazedAt;

		/// Allow Click Button to Animate
		//ShowText
	}
}
