using UnityEngine;
using System.Collections;

public class ucAnimation : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", v);
		anim.SetFloat ("Direction", h);
		anim.SetBool("Jump", Input.GetButtonDown ("Jump"));
	}
}
