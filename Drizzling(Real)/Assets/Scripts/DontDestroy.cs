using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

    static DontDestroy ins;
    public GameObject[] Items;
    public bool[] Props;
    
    void Awake()
    {
        if (ins == null)
        {
            ins = this;
            DontDestroyOnLoad(this);
           	SceneManager.LoadSceneAsync (1, LoadSceneMode.Additive);
        }
        else if (this != ins)
        {
            Destroy(gameObject);
        }
    }
}
