using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject LifePoint1, LifePoint2, LifePoint3;
    public static int health;

    public static int HeartScript { get; internal set; }
    public static int PlayerRemoveLife { get; internal set; }

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        LifePoint1.gameObject.SetActive(true);
        LifePoint2.gameObject.SetActive(true);
        LifePoint3.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(true);
                LifePoint3.gameObject.SetActive(true);
                break;
            case 2:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(true);
                LifePoint3.gameObject.SetActive(false);
                break;
            case 1:
                LifePoint1.gameObject.SetActive(true);
                LifePoint2.gameObject.SetActive(false);
                LifePoint3.gameObject.SetActive(false);
                break;
            case 0:
                LifePoint1.gameObject.SetActive(false);
                LifePoint2.gameObject.SetActive(false);
                LifePoint3.gameObject.SetActive(false);
                break;

        }
    }
}