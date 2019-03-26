using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Script : MonoBehaviour

{
    public GameObject pressUI;
    public GameObject DialogueText;
    public string[] dialogueElements;
    private bool boolSwitch;
    private int dialogueCount;
    public int presentChoice;
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
            dialogueCount = -1;
        }
    }

    void Update()
    {
        if (dialogueCount > -1)
        {
            DialogueText.GetComponent<TextMesh>().text = dialogueElements[dialogueCount];
        }
        if (boolSwitch == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && dialogueCount < dialogueElements.Length - 1)
            {
                DialogueText.SetActive(true);
                dialogueCount++;
            }
        }

        if(dialogueCount == presentChoice)
        {
            if (Input.GetKeyDown(KeyCode.Y)) { Debug.Log("Candle Saved"); } //close dialogue
            else if (Input.GetKeyDown(KeyCode.N)) { Debug.Log("Candle not Saved"); } //close dialogue
            
        }
        
        
    }

}
