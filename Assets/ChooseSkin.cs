using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSkin : MonoBehaviour
{
    public enum TIPO_SKIN
    {
        CUBO, CAPSULA, ESFERA
    }
    public TIPO_SKIN skin;
    public GameObject[] skins;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform t in transform)
        {
            t.gameObject.SetActive(false);
        }    
        switch(skin)
        {
            case TIPO_SKIN.CUBO:
                skins[0].SetActive(true);
                break;
            case TIPO_SKIN.CAPSULA:
                skins[1].SetActive(true);
                break;
            case TIPO_SKIN.ESFERA:
                skins[2].SetActive(true);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
