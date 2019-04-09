using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_Door : MonoBehaviour

    
{
    public GameObject keyObject;
    public GameObject UI;
    public string door;
    private string keyword;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            UI.GetComponent<TextMesh>().text = "Press E to Unlock";
            UI.SetActive(true);
            
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            UI.SetActive(false);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if
        if (door.Contains(keyword))
        {

        }
        {

        }
    }
}
