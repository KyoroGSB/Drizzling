using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleEvent : MonoBehaviour {

	public bool IsPut_L ;
	public bool IsPut_R ;
	public int consequ; //  1<  2>  3==
	public int weight;
	public GameObject Stick;
	public GameObject Lplate;
	public GameObject Rplate;
	RScale_collider RS;
	LScale_collider LS;

	Animator anim;
	// Use this for initialization
	void Start () {
		IsPut_R = false;
		IsPut_L = false;
		consequ = 0;
		weight = 0;
		anim = GetComponent<Animator> ();
		RS = FindObjectOfType<RScale_collider> ();
		LS = FindObjectOfType<LScale_collider> ();
	}

	void Update(){
		
		if (weight == consequ) {
			if (weight != 0 || consequ != 0) {
			anim.SetBool ("W=P", true);
			}
		}

		if (weight > consequ) {
			anim.SetBool ("W>P", true);

		} else {
			anim.SetBool ("W>P", false);
		}

		if (weight < consequ) {
				anim.SetBool ("W<P",true);
		}else {
			anim.SetBool ("W<P", false);
		}

		
	}





}
