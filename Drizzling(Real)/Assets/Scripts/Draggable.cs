using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

	public Transform parentToReturnTo = null;

	/*void Start(){
		CtrlParent = this.transform.parent;//Props_panel
		this.transform.SetParent (this.transform.parent.parent);
		this.gameObject.SetActive (false);
	}*/

	//public enum Slot{WEAPON, HEAD, CHEST, LEGS, FEET, INVENTORY};
	//public Slot typeOfItem = Slot.WEAPON;

	public void OnBeginDrag(PointerEventData eventdata){
		Debug.Log ("OnBeginDrag");

		parentToReturnTo = this.transform.parent;
        
		this.transform.SetParent (this.transform.parent.parent);
       
		GetComponent<CanvasGroup> ().blocksRaycasts = false;

		//DropZone[] zones = GameObject.FindObjectOfType<DropZone> ();
	}
	public void OnDrag(PointerEventData eventdata){
		//Debug.Log ("OnDrag");

		this.transform.position = eventdata.position;
	}

	public void OnEndDrag(PointerEventData eventdata){
		Debug.Log ("OnExitDrag");
		this.transform.SetParent (parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;

		//EventSystem.current.RaycastAll (eventdata);
	}
}
