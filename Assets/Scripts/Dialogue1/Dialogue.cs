using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    //public TextMeshProUGUI interact;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject yesButton;
    public GameObject noButton;
    public GameObject interact;
    private int saved;
    // Start is called before the first frame update

    void Start()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);
        interact.SetActive(false);
        saved = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        if (index == sentences.Length - 1)
        {
            noButton.SetActive(true);
            yesButton.SetActive(true);
        }

        if (index >= 0)
        {
            interact.SetActive(false);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        interact.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = " ";
            continueButton.SetActive(false);
            yesButton.SetActive(false);
            noButton.SetActive(false);
        }        
    }

    void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.name == "Player" && Input.GetKeyUp(KeyCode.E) && saved == 1) 
        {
            StartCoroutine(Type());
            Debug.Log("asset");
            
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player" && saved == 1)
        {
            interact.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        interact.SetActive(false);
    }

    public void saveCandle()
    {
        if (GameControlScript.health > 1)
        {
            GameControlScript.health -= 1;
            textDisplay.text = " ";
            saved++;
            continueButton.SetActive(false);
            yesButton.SetActive(false);
            noButton.SetActive(false);
        }
    }

    public void doNotsaveCandle()
    {
        textDisplay.text = " ";
        continueButton.SetActive(false);
        yesButton.SetActive(false);
        noButton.SetActive(false);
    }
}
