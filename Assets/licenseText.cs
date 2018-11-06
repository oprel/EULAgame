using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class licenseText : MonoBehaviour {

    public string[] EULAS;
    private Text t;
    private int currentEULA = 0;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
        t.text = EULAS[currentEULA];
	}
	
    public void nextEULA(GameObject o)
    {
        Debug.Log(o.name);
        if (currentEULA > EULAS.Length) { currentEULA = 0; }
            currentEULA++;
            t.text = EULAS[currentEULA];

            
    }
}
