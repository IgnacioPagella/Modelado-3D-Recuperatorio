using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colegio : MonoBehaviour
{
    public string nom;
    public int anio;
    public string orientacion;
    // Start is called before the first frame update
    void Start()
    {
        if (orientacion != "T" && orientacion != "D" && orientacion != " G" && orientacion != "M" && orientacion != "H")
        {
            Debug.Log("Solo puedes ingresar T, D, G, M, H");
        }
        else if (anio < 3)
        {
            Debug.Log("Error. Aun estas en ciclo basico");
        }
        else if (nom == "")
        {
            Debug.Log(" No pusiste tu nombre ");
        }
        else
        {
            Debug.Log("Muchas gracias " + nom); 
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
