using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement_Tiger : MonoBehaviour {

	public Camera cam;
	_SceneChange SC;
	void Start()
	{
		cam = GetComponent<Camera>();
		SC = FindObjectOfType<_SceneChange> ();
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
				Debug.Log(hitInfo.collider.gameObject.name);
				if (hitInfo.collider.gameObject.name == "TigerToLight") {
					SC.changeScene (5);
				}
			}
		}
	}
	public void SceneBackMove(){
		SC.changeScene (2);
	}
}
