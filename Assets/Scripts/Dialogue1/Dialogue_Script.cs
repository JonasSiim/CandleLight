using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Script : MonoBehaviour

{
    public GameObject pressUI;
    public GameObject DialogueText;
    private bool boolSwitch;
    private int dialogueCount;
    // When player approaches NPC
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player")
        {
            pressUI.SetActive(true);
            boolSwitch = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            pressUI.SetActive(false);
            DialogueText.SetActive(false);
            boolSwitch = false;
            dialogueCount = 0;
        }
    }

    void Update()
    {
        if (boolSwitch == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueText.SetActive(true);
                dialogueCount++;
            }
        }
        if (dialogueCount > 1)
        {

            DialogueText.GetComponent<TextMesh>().text = "Do you suck tities or vegana?";
            Debug.Log("yes i do");
        }
        else if (dialogueCount < 1)
        {
            DialogueText.GetComponent<TextMesh>().text = "Hi you little bitch";
        }
        Debug.Log(dialogueCount);
    }

}
