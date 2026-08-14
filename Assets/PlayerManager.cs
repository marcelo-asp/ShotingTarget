using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public GameObject menu;
    public InputActionProperty pauseAction;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ( pauseAction.action.WasPressedThisFrame()){
            if(menu.isVisible){
                menu.SetActive(false);
            }
            else{
                menu.SetActive(true);
            }
        }
    }
}
