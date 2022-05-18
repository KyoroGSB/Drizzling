using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _SceneChange : MonoBehaviour {


	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeScene(int j){
		if (j == 1) {  //Lobby
			anim.SetTrigger ("IsChangeScene");
			Invoke ("Delaychange1", 2.0f);
		}
		if (j == 2) {   //Well
			anim.SetTrigger ("IsChangeScene");
			Invoke ("Delaychange2", 2.0f);
		}
		if (j == 3) {   //Scale
			anim.SetTrigger ("IsChangeScene");
			Invoke ("Delaychange3", 2.0f);
		}
		if (j == 4) {  //Tiger
			anim.SetTrigger ("IsChangeScene");
			Invoke ("Delaychange4", 2.0f);
		}
		if (j == 5) {  //Light
			anim.SetTrigger ("IsChangeScene");
			Invoke ("Delaychange5", 2.0f);
		}

	}
	private void Delaychange1(){
		SceneManager.LoadScene (0);
		SceneManager.LoadScene (1, LoadSceneMode.Additive);
	}
	private void Delaychange2(){
		SceneManager.LoadScene (0);
		SceneManager.LoadScene (2, LoadSceneMode.Additive);
	}
	private void Delaychange3(){
		SceneManager.LoadScene (0);
		SceneManager.LoadScene (3, LoadSceneMode.Additive);
	}
	private void Delaychange4(){
		SceneManager.LoadScene (0);
		SceneManager.LoadScene (4, LoadSceneMode.Additive);
	}
	private void Delaychange5(){
		SceneManager.LoadScene (0);
		SceneManager.LoadScene (5, LoadSceneMode.Additive);
	}
}
