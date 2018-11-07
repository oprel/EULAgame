using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour {

    public static audioManager self;
    public AudioSource errorSound;
    public AudioSource clickSound;
    // Use this for initialization
    private void Awake()
    {
        self = this;
    }

    public static void error()
    {
        self.errorSound.Play();
    }

    public static void click()
    {
        self.clickSound.Play();
    }
}
