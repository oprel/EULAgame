using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expManager : MonoBehaviour {

    public static bool inMenu;
    public static expManager self;

    public bool triggerMenu;
    public float menuTimer;
    public bool pauseTimer;
    [Header("Settings")]
    public float waitTime = 10;

    // Use this for initialization
    private void Awake()
    {
        menuTimer = waitTime * 2;
        self = this;
    }

    // Update is called once per frame
    void Update () {
        if (!inMenu)
        {
            Time.timeScale = 1.0f;
            if (!pauseTimer) menuTimer -= Time.deltaTime;
            if (menuTimer < 0 || triggerMenu)
            {
                //inMenu = true;
                menuManager.self.openMenu();
                menuTimer = waitTime;
            }
        }
        else
        {
            Time.timeScale = 0.1f;
        }
     
	}
}
