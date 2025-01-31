using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform door; // Referencia al cubo que deseas desplazar
    //public Vector3 posicionFinal;
    //public int count;
    //public PlayerController count;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        GameObject objetoConScript1 = GameObject.Find("Player"); // Reemplaza "NombreDelObjeto" con el nombre del objeto en la jerarquía de Unity
        PlayerController playerControler = objetoConScript1.GetComponent<PlayerController>();

        int count = playerControler.count;
        if (count >= 10)
        {
            // Calcula la nueva posición del cubo
            Vector3 nuevaPosicion = new Vector3(0f, 10f, 9.43f);
            Vector3 startPosition = new Vector3(0f, 0f, 9.43f);
            float velocidadMovimiento = 0.5f; // Ajusta la velocidad según tus necesidades

            // Aplica la nueva posición al cubo
            //door.transform.position = nuevaPosicion;

            door.position = Vector3.Lerp(door.position, nuevaPosicion, velocidadMovimiento * Time.deltaTime);
            door.position = Vector3.Lerp(door.position, startPosition, velocidadMovimiento * Time.deltaTime);
        }
    }
}
