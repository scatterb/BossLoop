using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("Levelid: " + name);
        Application.LoadLevel(name);
    }

}
