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
		// Enlarge
		GetComponent<Transform>().localScale = gazedAt ? 3*startingScale : startingScale;
		// Glow
		Behaviour h = (Behaviour)GetComponent("Halo");
		h.enabled = gazedAt ? true : false;
		// Allow Click Button to Animate
		// ShowText
	}

	public void StartLanding() {
		GameObject camera = GameObject.Find("CardboardMain");
		TriggerMotion camera_trigger = camera.GetComponent<TriggerMotion> ();
		camera_trigger.orbitY = false;
		PhilaeLanding philae_land = GetComponent<PhilaeLanding> ();
		//GameObject camera = GameObject.FindGameObjectsWithTag ("CardboardMain");
		//GameObject comet = GameObject.Find("67P");
		//TriggerMotion comet_trigger = comet.GetComponent<TriggerMotion> ();
		//comet.transform.localPosition = new Vector3(0f, 0f, 0f);
		//comet.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		//comet_trigger.enabled = false;
		philae_land.position = new Vector3(-11.7f, 3.59f, -2.49f);
		philae_land.velocity = new Vector3 (+2f, 0f, 0f);
		philae_land.enabled = true;
	}
}
