using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextMenu : MonoBehaviour {

    public GameObject next;

    public void goToNext()
    {
        next.SetActive(true);
        gameObject.SetActive(false);
    }
}
