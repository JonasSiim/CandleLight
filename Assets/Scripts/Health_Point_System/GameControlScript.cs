using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
    [SerializeField] private string newLevel;
    public GameObject LifePoint1, LifePoint2, LifePoint3, LifePoint4, LifePoint5, LifePoint6;
    public static int health;

    public static int HeartScript { get; internal set; }
    public static int PlayerRemoveLife { get; internal set; }

    // Start is called before the first frame update
    void Start()
    {
        health = 6;
        LifePoint1.gameObject.SetActive(true);
        LifePoint2.gameObject.SetActive(true);
        LifePoint3.gameObject.SetActive(true);
        LifePoint4.gameObject.SetActive(true);
        LifePoint5.gameObject.SetActive(true);
        LifePoint6.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (health > 6)
            health = 6;

        switch (health)
        {


            case 6:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(true);
                LifePoint3.gameObject.SetActive(true);
                LifePoint4.gameObject.SetActive(true);
                LifePoint5.gameObject.SetActive(true);
                LifePoint6.gameObject.SetActive(true);
                break;
            case 5:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(true);
                LifePoint3.gameObject.SetActive(true);
                LifePoint4.gameObject.SetActive(true);
                LifePoint5.gameObject.SetActive(true);
                LifePoint6.gameObject.SetActive(false);
                break;
            case 4:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(true);
                LifePoint3.gameObject.SetActive(true);
                LifePoint4.gameObject.SetActive(true);
                LifePoint5.gameObject.SetActive(false);
                LifePoint6.gameObject.SetActive(false);
                break;
            case 3:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(true);
                LifePoint3.gameObject.SetActive(true);
                LifePoint4.gameObject.SetActive(false);
                LifePoint5.gameObject.SetActive(false);
                LifePoint6.gameObject.SetActive(false);
                break;
            case 2:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(true);
                LifePoint3.gameObject.SetActive(false);
                LifePoint4.gameObject.SetActive(false);
                LifePoint5.gameObject.SetActive(false);
                LifePoint6.gameObject.SetActive(false);
                break;
            case 1:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(false);
                LifePoint3.gameObject.SetActive(false);
                LifePoint4.gameObject.SetActive(false);
                LifePoint5.gameObject.SetActive(false);
                LifePoint6.gameObject.SetActive(false);
                break;
            case 0:
                LifePoint1.gameObject.SetActive(false);
                LifePoint2.gameObject.SetActive(false);
                LifePoint3.gameObject.SetActive(false);
                LifePoint4.gameObject.SetActive(false);
                LifePoint5.gameObject.SetActive(false);
                LifePoint6.gameObject.SetActive(false);
                Destroy(gameObject);
                SceneManager.LoadScene(newLevel);
                //Add things that happen when the player dies
                break;
        }
    }
}