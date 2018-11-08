using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour {

    public static audioManager self;
    public AudioSource errorSound;
    public AudioSource clickSound;
    public AudioSource music;
    public AudioSource failure;
    // Use this for initialization
    private void Awake()
    {
        self = this;
    }

    private void Update()
    {
        if (music.isPlaying && expManager.inMenu)   music.Pause();
        if (!music.isPlaying && !expManager.inMenu) music.UnPause();

    }

    public static void error()
    {
        self.errorSound.Play();
    }

    public static void click()
    {
        self.clickSound.Play();
    }

    public static void fail()
    {
        self.failure.Play();
    }
}
