using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    bool vivo;
    [SerializeField] int VidaPlayer = 10;
    [SerializeField] bool powerup;

    void Start()
    {
        vivo = VidaPlayer <= 0 ? false : true;

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
        
        if (vivo == false && powerup == true ) {
            print("Morrendo");

            VidaPlayer += 10 / 2;

            print($"Ainda não, vida atual {VidaPlayer}");
         }
    }
}
