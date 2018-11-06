using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour {
    public static menuManager self;
    public GameObject[] menus;
    public int currentMenu;
    // Use this for initialization
    private void Awake()
    {
        self = this;
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void openMenu()
    {
        menus[currentMenu].SetActive(true);
    }

    public void closeMenu()
    {
        menus[currentMenu].SetActive(false);
        currentMenu = (currentMenu + 1) % menus.Length;
        expManager.inMenu = false;
    }
}
