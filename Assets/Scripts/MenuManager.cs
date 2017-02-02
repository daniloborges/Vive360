using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device controller
    {
        get {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }
    public GameObject NavigationMenu;
    public GameObject MainCamera;

    // Use this for initialization
    void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        if (NavigationMenu == null)
        {
            NavigationMenu = GameObject.Find("Menu");
        }
        if(MainCamera == null)
        {
            MainCamera = GameObject.Find("Camera (head)");
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        if(controller.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            Debug.Log(controller.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).magnitude);
            //if (controller.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).magnitude > 0.8)
            //{
            if (!NavigationMenu.activeInHierarchy)
            {
                Vector3 newrotation = new Vector3(0, 0, MainCamera.transform.rotation.eulerAngles.y - 90);
                NavigationMenu.transform.localRotation = Quaternion.Euler(newrotation);
                //NavigationMenu.transform.position = new Vector3(MainCamera.transform.position.x, 0, MainCamera.transform.position.z);
            }
            NavigationMenu.SetActive(!NavigationMenu.activeInHierarchy);
            //}
        }
	}
}
