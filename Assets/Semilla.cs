using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semilla : MonoBehaviour
{
    public Planta planta;
    
    public void Germinar()
    {
        GameObject newPlanta =  Instantiate(planta.FormaPlanta, transform);
        PlantaManager.instance.plantas.Add(planta);
    }
    private void OnMouseDown()
    {
        Germinar();
    }
}
