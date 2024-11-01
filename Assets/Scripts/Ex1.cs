using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    [SerializeField] int VidaPlayer = 10;

    bool vivo;


    void Start()
    {
        vivo = VidaPlayer <= 0 ? false : true;

        if (vivo == true)
        {
            print("Personagem vivo");
        }
        else
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
