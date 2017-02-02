using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMenuManager : MonoBehaviour {

    private SteamVR_TrackedController controller;
    public GameObject NavigationMenu;

    private void OnEnabled()
    {
        controller = GetComponent<SteamVR_TrackedController>();
        controller.TriggerClicked += controller_MenuButtonClicked;
    }

    private void OnDisable()
    {
        //controller.TriggerClicked -= controller_MenuButtonClicked;
    }

    private void controller_MenuButtonClicked(object sender, ClickedEventArgs e)
    {
        Debug.Log("Menu Clicked");
        NavigationMenu.SetActive(!NavigationMenu.activeInHierarchy);
    }

    // Use this for initialization
    void Start () {
        if (NavigationMenu == null)
        {
            NavigationMenu = GameObject.Find("Menu");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
