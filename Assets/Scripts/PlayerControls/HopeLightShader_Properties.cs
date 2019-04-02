using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopeLightShader_Properties : MonoBehaviour
{
    public Material mat;
    public string propertyName; // in this case must be set to the players position (_PlayerPos)
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            mat.SetVector(propertyName, player.position);
        }
        else
            Debug.Log("Assign the player propperty in the HopeLightShader_Properties");
    }
}
