using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EULA
{
    public string start;
    public string end;
}

public class licenseText : MonoBehaviour {

    public string[] conditions;
    public string[] negatives;
    public GameObject window;

    public EULA[] eulas;
    private Text t;
    public static int currentEULA = 0;
    public static int currentCondition = 0;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
        t.text = getText();
    }
	
    public string getText()
    {
        string s ="";
        s += eulas[currentEULA].start;
        if (Random.value > .5f)
        {
            s += conditions[currentCondition];
        }
        else
        {
            s += negatives[currentCondition];
        }
        s+= eulas[currentEULA].start;
        return s;
    }


    public void nextEULA()
    {
        StartCoroutine(loadNext());
    }

    public IEnumerator loadNext()
    {
        window.SetActive(false);
        t.text = getText();
        yield return new WaitForSeconds(1);
        window.SetActive(true);
    }
}
