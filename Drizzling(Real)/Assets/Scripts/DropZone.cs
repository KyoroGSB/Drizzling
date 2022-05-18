using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler,IPointerEnterHandler,IPointerExitHandler  {

	//public Draggable.Slot typeOfItem = Draggable.Slot.INVENTORY;


	public void OnPointerEnter(PointerEventData eventData){
		//Debug.Log ("OnPointerEnter");
	}
	public void OnPointerExit(PointerEventData eventData){
		//Debug.Log ("OnPinterExit");
	}

	public void OnDrop(PointerEventData eventData){
		Debug.Log (eventData.pointerDrag.name +"Drop on " + gameObject.name);


		Draggable d = eventData.pointerDrag.GetComponent<Draggable> ();
		if (d != null) {
			//if (typeOfItem == d.typeOfItem ||typeOfItem == Draggable.Slot.INVENTORY) {
				d.parentToReturnTo = this.transform;
			//}
		}
	}
}
