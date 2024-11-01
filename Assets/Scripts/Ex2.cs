using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    [SerializeField] bool powerup;

    void Start()
    {
        if (powerup == true)
        {
            print("Power-up coletado");

        }
        else
        {
            print("Nenhum powerup-up encontrado");

        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
