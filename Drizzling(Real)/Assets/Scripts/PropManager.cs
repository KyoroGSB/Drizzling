using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PropManager : MonoBehaviour {

    public GameObject Ruyi;
    public Transform tempArea;
    public Transform propArea;
    DontDestroy DD;
    void Start() {
        DD = FindObjectOfType<DontDestroy>();
    }
    

    public void ChangeArea() {
        if (DD.Props[0]) {
            if (Ruyi.transform.parent == propArea)
            {

            }
            else { Ruyi.transform.SetParent(propArea); }
        }
    } 
    
}
