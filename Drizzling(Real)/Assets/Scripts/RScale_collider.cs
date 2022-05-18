using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RScale_collider : MonoBehaviour {

	// Use this for initialization
	ScaleEvent SE;


	public Transform MonoR = null;
	public Transform R_Scp;
	void Start () {
		SE = FindObjectOfType<ScaleEvent> ();
		R_Scp = this.transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter(Collider a){
		
		if (a.gameObject.name == "meat") {
			SE.consequ = 1;
			MonoR = a.gameObject.transform.parent;
			a.gameObject.transform.SetParent (R_Scp);
		}else if (a.gameObject.name == "fish") {
			SE.consequ = 2;
			MonoR = a.gameObject.transform.parent;
			a.gameObject.transform.SetParent (R_Scp);
		}else if(a.gameObject.name == "chicken"){
			SE.consequ = 5;
			MonoR = a.gameObject.transform.parent;
			a.gameObject.transform.SetParent (R_Scp);
		}

	}


	void OnTriggerExit(Collider a){
		SE.consequ = 0;
		a.gameObject.transform.SetParent (MonoR);
	}



}
