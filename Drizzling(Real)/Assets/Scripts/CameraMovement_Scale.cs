using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement_Scale : MonoBehaviour {
	public Camera cam;
	_SceneChange SC;
	ScaleEvent SE;
    DontDestroy DD;
    PropManager PM;

	public int deep = 0;
	public Collider Meat;
	public Collider Fish;
	public Collider Chicken;
	public Collider W_1kg;
	public Collider W_2kg;
	public Collider W_5kg;
	public Collider Safe;
	public Collider Scale;
	public Collider Locks;

	public GameObject meat;
	public GameObject fish;
	public GameObject chicken;
	public GameObject weight_1kg;
	public GameObject weight_2kg;
	public GameObject weight_5kg;
	public GameObject Scale_pos;
	public GameObject Safe_pos;
	public GameObject Lock_pos;
	public GameObject Cam_pos;
	public GameObject LScale_pos;
	public GameObject RScale_pos;
	public GameObject Btn_Back_Scene;
	public GameObject Btn_Back_Quest;
	public GameObject[] Codes;
	public GameObject ruyi;

	private Vector3 meatBase_pos;
	private Vector3 fishBase_pos;
	private Vector3 chickenBase_pos;
	private Vector3 Base_1kg;
	private Vector3 Base_2kg;
	private Vector3 Base_5kg;
	//public bool IsPut_L = false;
	//public bool IsPut_R = false;

	//Quaternion quate_safe = Quaternion.identity;
	void Start()
	{
		cam = GetComponent<Camera>();
		SC = FindObjectOfType<_SceneChange> ();
		SE = FindObjectOfType<ScaleEvent> ();
        DD = FindObjectOfType<DontDestroy>();
        PM = FindObjectOfType<PropManager>();

		meatBase_pos = meat.GetComponent<Transform> ().position;
		fishBase_pos = fish.GetComponent<Transform> ().position;
		chickenBase_pos = chicken.GetComponent<Transform> ().position;
		Base_1kg = weight_1kg.GetComponent<Transform> ().position;
		Base_2kg = weight_2kg.GetComponent<Transform> ().position;
		Base_5kg = weight_5kg.GetComponent<Transform> ().position;

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{

			Vector3 vec = Input.mousePosition;
			Ray ray = cam.ScreenPointToRay(vec);
			RaycastHit hitInfo;
			if (Physics.Raycast(ray, out hitInfo))
			{
				//Debug.Log(hitInfo.collider.gameObject.name);
				if (hitInfo.collider.gameObject.name == "ScaleToTiger") {
					SC.changeScene (4);
				}
				if (hitInfo.collider.gameObject.name == "safe") {
					deep += 1;
					Debug.Log (deep);
					this.transform.position = Safe_pos.transform.position;
					this.transform.rotation= Quaternion.Euler(new Vector3 (8, 50, 0));
					Locks.enabled = true;
					Safe.enabled = false;
					Btn_Back_Scene.SetActive (false);
					if (deep > 0) {
						Btn_Back_Quest.SetActive (true);
						Btn_Back_Scene.SetActive (false);
					}

				}
				if (hitInfo.collider.gameObject.name == "Locks") {
					deep += 1;
					Debug.Log (deep);
					this.transform.position = Lock_pos.transform.position;
					Locks.enabled = false;
					Codes [0].SetActive (true);
					Codes [1].SetActive (true);
					Codes [2].SetActive (true);
					if (deep > 0) {
						Btn_Back_Quest.SetActive (true);
						Btn_Back_Scene.SetActive (false);
					}
				}
				if (hitInfo.collider.gameObject.name == "ScaleQuest") {
					deep += 1;
					Debug.Log (deep);
					this.transform.position = Scale_pos.transform.position;
					cam.transform.rotation= Quaternion.Euler(new Vector3 (30, 127, 0));
					Scale.enabled = false;
					Meat.enabled = true;
					Fish.enabled = true;
					Chicken.enabled = true;
					W_1kg.enabled = true;
					W_2kg.enabled = true;
					W_5kg.enabled = true;
					if (deep > 0) {
						Btn_Back_Quest.SetActive (true);
						Btn_Back_Scene.SetActive (false);
					}
				}
				if (hitInfo.collider.gameObject.name == "meat") {

					if (SE.IsPut_R == false) {
						meat.transform.position = RScale_pos.transform.position;
						SE.IsPut_R = true;
						Fish.enabled = false;
						Chicken.enabled = false;
					} else if (SE.IsPut_R == true) {
						meat.transform.position = meatBase_pos;
						SE.IsPut_R = false;
						Fish.enabled = true;
						Chicken.enabled = true;
					}

				}
				if (hitInfo.collider.gameObject.name == "fish") {

					if (SE.IsPut_R == false) {
						fish.transform.position = RScale_pos.transform.position;
						SE.IsPut_R = true;
						Meat.enabled = false;
						Chicken.enabled = false;
					} else if (SE.IsPut_R == true) {
						fish.transform.position = fishBase_pos;
						SE.IsPut_R = false;
						Meat.enabled = true;
						Chicken.enabled = true;
					}

				}
				if (hitInfo.collider.gameObject.name == "chicken") {
					if (SE.IsPut_R == false) {
						chicken.transform.position = RScale_pos.transform.position;
						SE.IsPut_R = true;
						Meat.enabled = false;
						Fish.enabled = false;
					} else if (SE.IsPut_R == true) {
						chicken.transform.position = chickenBase_pos;
						SE.IsPut_R = false;
						Meat.enabled = true;
						Fish.enabled = true;
					}

				}
				if (hitInfo.collider.gameObject.name == "weight_1kg") {
					if (SE.IsPut_L == false) {
						weight_1kg.transform.position = LScale_pos.transform.position;
						SE.IsPut_L = true;

						W_2kg.enabled = false;
						W_5kg.enabled = false;
					} else if (SE.IsPut_L == true) {
						weight_1kg.transform.position = Base_1kg;
						SE.IsPut_L = false;

						W_2kg.enabled = true;
						W_5kg.enabled = true;
					}

				}
				if (hitInfo.collider.gameObject.name == "weight_2kg") {
					if (SE.IsPut_L == false) {
						weight_2kg.transform.position = LScale_pos.transform.position;
						SE.IsPut_L = true;
						W_1kg.enabled = false;

						W_5kg.enabled = false;
					} else if (SE.IsPut_L == true) {
						weight_2kg.transform.position = Base_2kg;
						SE.IsPut_L = false;
						W_1kg.enabled = true;

						W_5kg.enabled = true;
					}

				}
				if (hitInfo.collider.gameObject.name == "weight_5kg") {
					if (SE.IsPut_L == false) {
						weight_5kg.transform.position = LScale_pos.transform.position;
						SE.IsPut_L = true;
						W_1kg.enabled = false;
						W_2kg.enabled = false;

					} else if (SE.IsPut_L == true) {
						weight_5kg.transform.position = Base_5kg;
						SE.IsPut_L = false;
						W_1kg.enabled = true;
						W_2kg.enabled = true;

					}

				}

				if (hitInfo.collider.gameObject.name == "ruyi") {
					Destroy (hitInfo.collider.gameObject);
                    DD.Props[0] = true;
                    PM.ChangeArea();
				}
			}
		}
	}

	public void SceneBackMove(){
		SC.changeScene (2);
	}
	public void QuestBackMove(){
		if (deep == 1) {
			cam.transform.position = Cam_pos.transform.position;
			cam.transform.rotation= Quaternion.Euler(new Vector3 (5, 100, 0));
			deep -= 1;
		} else if (deep == 2) {
			cam.transform.position = Safe_pos.transform.position;
			Codes [0].SetActive (false);
			Codes [1].SetActive (false);
			Codes [2].SetActive (false);
			Locks.enabled = true;
			deep -= 1;
		}

		if (deep == 0) {
			Btn_Back_Scene.SetActive (true);
			Btn_Back_Quest.SetActive (false);
			Locks.enabled = false;
			Safe.enabled = true;
			Scale.enabled = true;
			Meat.enabled = false;
			Fish.enabled = false;
			Chicken.enabled = false;
			W_1kg.enabled = false;
			W_2kg.enabled = false;
			W_5kg.enabled = false;

		}
	}



}
