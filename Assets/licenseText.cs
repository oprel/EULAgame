using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class EULA
{
    public string start;
    public string end;
}

public class licenseText : MonoBehaviour {

    public string[] conditions;
    public string[] negatives;
    

    public EULA[] eulas;

    [Header("Objects")]
    public GameObject window;
    public Text t;
    public Text f;
    public static int currentEULA = 0;
    public static int currentCondition = 4;

    public static bool currentBool;
	// Use this for initialization
	void Start () {
        t.text = getText();
        f.enabled = false;
    }
	
    public string getText()
    {
        string s ="";
        s += eulas[currentEULA].start;
        currentBool = Random.value > .5;
        if (currentBool)
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


    public void nextEULA(bool agreed)
    {
        audioManager.click();
        if (currentBool == agreed && currentCondition>4) StartCoroutine(showFail());
        currentEULA = (currentEULA + 1) % eulas.Length;
        StartCoroutine(loadNext());
    }

    public IEnumerator loadNext()
    {
        window.SetActive(false);
        t.text = getText();
        Debug.Log("ASS1");
        for (int i = 0; i < 100; i++)
        {
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("ASS2");
        window.SetActive(true);
        audioManager.error();
        yield return null;
    }
    public IEnumerator showFail()
    {
        audioManager.fail();
        string s = "";
        if (currentBool)
        {
            s= "YES: " + conditions[currentCondition];
        }
        else
        {
            s = "NO: " + negatives[currentCondition];
        }
        f.text = s.ToUpper();
        f.enabled = true;
        currentCondition++;

        for (int i = 0; i < 300; i++)
        {
            yield return new WaitForEndOfFrame();
        }
        if (f.text == s.ToUpper())
        f.enabled = false;
    }
}
