using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Planta
{
    public string NombrePlanta;
    public GameObject FormaPlanta;
}
public class PlantaManager : MonoBehaviour
{
    public static PlantaManager instance;
    public List<Planta> plantas;
    private void Awake()
    {
        instance = this;
        
    }

    // + - / * %
    // && || ? 
    // T && T == T
    // T && F == F
    // F && F == F
    // T || T == T
    // T || F == T
    // F || F == F
}
