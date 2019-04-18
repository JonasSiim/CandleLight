using UnityEngine;
using System.Collections;

public class scaleScript : MonoBehaviour
{

    public float HopeRadiuse = 1.0f;
    GameObject masksize;
    //Shader.GetGlobalFloat("_HopeRadius", HopeRadius);

    private void Start()
    {
        masksize = GameObject.Find("SpriteMask");
    }

    void Example()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("HopeLight_Shader");
        HopeRadiuse =(rend.material.GetFloat("_HopeRadius"));
        print(HopeRadiuse);



        // Widen the object by 0.1
        masksize.gameObject.transform.localScale = new Vector3(HopeRadiuse * 1000, HopeRadiuse *1000, 0);

        //mat.SetVector(propertyName, player.position);
    }
}