using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlCodes : MonoBehaviour {


	CameraMovement_Scale CS;

	public GameObject[] Codes;
	public int[] Nums;
	private AudioSource audi;
	public AudioClip Roll;
	public AudioClip Open;

	public GameObject cam;
	public GameObject Safe_pos;
	private bool isOpen;
	// Update is called once per frame
	void Start(){
		audi = GetComponent<AudioSource> ();
		CS = FindObjectOfType<CameraMovement_Scale> ();
		isOpen = false;
	}

	void Update () {
		
		if (Nums [0] == 5 && Nums [1] == 2 && Nums [2] == 1&& isOpen==false) {
			audi.PlayOneShot (Open);
			isOpen = true;
            CS.Codes[0].SetActive(false);
            CS.Codes[1].SetActive(false);
            CS.Codes[2].SetActive(false);
			Invoke ("Delayopen", 1.0f);
            
		}
	}

	public void TurnCode1(){
		if (Nums [0]==9)
			Nums [0] -= 9;
		else
			Nums [0] += 1;
		audi.PlayOneShot (Roll);
		Codes [0].transform.Rotate (new Vector3 (0, 36, 0));

	} 
	public void TurnCode2(){
		if (Nums [1]==9)
			Nums [1] -= 9;
		else
			Nums [1] += 1;
		Codes [1].transform.Rotate (new Vector3 (0, 36, 0));
		audi.PlayOneShot (Roll);
	} 
	public void TurnCode3(){
		if (Nums [2]==9)
			Nums [2] -= 9;
		else
			Nums [2] += 1;
		Codes [2].transform.Rotate (new Vector3 (0, 36, 0));
		audi.PlayOneShot (Roll);
	} 

	private void Delayopen(){
		//Debug.Log ("D");
		CS.deep -= 1;

		CS.Codes [0].SetActive (false);
		CS.Codes [1].SetActive (false);
		CS.Codes [2].SetActive (false);
		this.transform.Rotate (new Vector3 (0, -90, 0));
		cam.transform.position = Safe_pos.transform.position;
	}

}
