using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.Examples;

public class toggleTest : MonoBehaviour {

    private VRTK_ControllerEvents ev;
    private VRTK_UIPointer[] pointers;
    private VRTK_StraightPointerRenderer pointerline;
    private VRTK_ControllerUIPointerEvents_ListenerExample listener;
    public OvrAvatar OculusAvatar;
    public bool b =false;
    private void Start()
    {
        ev = GetComponent<VRTK_ControllerEvents>();
        pointerline = GetComponent<VRTK_StraightPointerRenderer>();
        listener = GetComponent<VRTK_ControllerUIPointerEvents_ListenerExample>();
        pointers = GetComponents<VRTK_UIPointer>();
        //setPointer();
        //ev.enabled = false;
        StartCoroutine(disableStart());
    }
    // Update is called once per frame
    void Update () {
       if (b != expManager.inMenu)
        {
            b = expManager.inMenu;
            setPointer();
        
        }	
	}

    void setPointer()
    {
        
        OculusAvatar.ShowControllers(b);
        pointerline.enabled = b;
        listener.enabled = b;
        foreach (VRTK_UIPointer p in pointers)
        {
            p.enabled = b;
        }
    }

    public IEnumerator disableStart()
    {
        yield return new WaitForSeconds(.1f);
        setPointer();
    }
}
