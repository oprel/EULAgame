using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour {
    public static menuManager self;
    public GameObject[] menus;
    public int currentMenu;
    public GameObject blackBG;
    public GameObject[] blockingObjects;

    // Use this for initialization
    private void Awake()
    {
        self = this;
        foreach (GameObject o in menus)
        {
            o.SetActive(false);
        }
        blackBG.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void openMenu()
    {
        menus[currentMenu].SetActive(true);
        blackBG.SetActive(true);
        audioManager.error();
        foreach (GameObject o in blockingObjects)
        {
            o.SetActive(false);
        }
    }

    public void closeMenu(bool agreed)
    {
        blackBG.SetActive(false);
        menus[currentMenu].SetActive(false);
        currentMenu = (currentMenu + 1) % menus.Length;
        expManager.inMenu = false;
        audioManager.click();
        foreach (GameObject o in blockingObjects)
        {
            o.SetActive(true);
        }
    }
}
