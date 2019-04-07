using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door_Script : MonoBehaviour
{
    
    public GameObject UI;
    public GameObject KeyObject;
    public bool PickedUp;
    private string message;
    public bool boolSwitch;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player") //Once players enters the key, show unlock message and set switch to true
        {
            
            UI.SetActive(true);
            boolSwitch = true;
           


        }
    }

    void OnTriggerExit2D(Collider2D col) //stop rendering the pick up message
    {
        if (col.gameObject.name == "Player")
        {
            UI.SetActive(false);

        }
    }

    private void Update()
    {
        DoorUpdate();
        PickedUp = KeyObject.GetComponent<Key_Script>().PickedUp; //collect the bool variable from key script
    }

    void DoorUpdate()
    {
        if(boolSwitch == true)//if players stands in the collider
        {
            message = "Press E to Unlock";
            UI.GetComponent<TextMeshProUGUI>().text = message;
        }
        if (Input.GetKeyDown(KeyCode.E) && PickedUp == true) //if key is pressed and key is picked up
        {

            gameObject.SetActive(false);
            message = "";

        }
    }
}
