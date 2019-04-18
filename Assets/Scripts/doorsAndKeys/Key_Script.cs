using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Key_Script : MonoBehaviour


{
    //Key objects
    public GameObject rKey;
    public GameObject rKeyGraph;
    public GameObject gKey;
    public GameObject gKeyGraph;
    public GameObject yKey;
    public GameObject yKeyGraph;
    //UI
    public GameObject UI;
    //public string door;
    public bool PickedUp;
    private string message;
    private bool boolSwitch;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            UI.SetActive(true);
            boolSwitch = true;
            message = "Press E to Pick Up";
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            UI.SetActive(false);
            boolSwitch = false;
            message = "";

        }
    }

    // Update is called once per frame
    void Update()
    {
        KeyUpdate();
    }

    void KeyUpdate()
    {
        if (boolSwitch == true)
        {
            
            UI.GetComponentInChildren<TextMeshProUGUI>().text = message;
            UI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PickedUp = true;
                message = "The key has been picked up";
                gameObject.SetActive(false);
                UI.SetActive(false);
                //KeyGraphic.SetActive(true);

            }

        }
    }
}

