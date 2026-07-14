using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (Menu.GetComponent<Canvas>().enabled == false)
            {
                Menu.GetComponent<Canvas>().enabled = true;
                Scoreboard.GetComponent<Canvas>().enabled = false;
            }
            else
            {
                Menu.GetComponent<Canvas>().enabled = false;
                Scoreboard.GetComponent<Canvas>().enabled = true;
            }
        }
    }

}
