using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LScale_collider : MonoBehaviour {


	ScaleEvent SE;
	public Transform Mono = null;

	public Transform L_Scp;
	void Start () {
		SE = FindObjectOfType<ScaleEvent> ();
		L_Scp = this.transform.parent;
	}
	

	void Update () {
		
	}


	void OnTriggerEnter(Collider a){
		if (a.gameObject.name == "weight_1kg") {
			SE.weight = 1;
			Mono = a.gameObject.transform.parent;
			a.gameObject.transform.SetParent (L_Scp);

		}else if (a.gameObject.name == "weight_2kg") {
			SE.weight = 2;
			Mono = a.gameObject.transform.parent;
			a.gameObject.transform.SetParent (L_Scp);
		}else if(a.gameObject.name == "weight_5kg"){
			SE.weight = 5;
			Mono = a.gameObject.transform.parent;
			a.gameObject.transform.SetParent (L_Scp);
		}
	}
	void OnTriggerExit(Collider a){
		SE.weight = 0;
		a.gameObject.transform.SetParent (Mono);

	}

}
