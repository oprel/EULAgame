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
    public bool b;
    private void Awake()
    {
        ev = GetComponent<VRTK_ControllerEvents>();
        pointerline = GetComponent<VRTK_StraightPointerRenderer>();
        listener = GetComponent<VRTK_ControllerUIPointerEvents_ListenerExample>();
        pointers = GetComponents<VRTK_UIPointer>();
    }
    // Update is called once per frame
    void Update () {
       if (b != expManager.inMenu)
        {
            //Debug.Log(b);
            b = expManager.inMenu;
            OculusAvatar.ShowControllers(b);
            pointerline.enabled = b;
            listener.enabled = b;
            foreach(VRTK_UIPointer p in pointers)
            {
                p.enabled = b;
            }
        }	
	}
}
