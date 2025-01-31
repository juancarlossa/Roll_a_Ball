using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float rangoXMin; // Valor mínimo del rango de movimiento en el eje X
    public float rangoXMax; // Valor máximo del rango de movimiento en el eje X
    public float rangoZMin; // Valor mínimo del rango de movimiento en el eje Z
    public float rangoZMax; // Valor máximo del rango de movimiento en el eje Z
    public float velocidad = 3; // Velocidad de movimiento de los objetos

    private Vector3 destino; // Posición de destino actual del objeto

    private void Start()
    {
        // Generar la primera posición de destino aleatoria
        GenerarDestinoAleatorio();
    }

    private void Update()
    {
        // Mover el objeto hacia el destino
        transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);

        // Comprobar si el objeto ha llegado al destino
        if (transform.position == destino)
        {
            // Generar una nueva posición de destino aleatoria
            GenerarDestinoAleatorio();
        }
    }

    private void GenerarDestinoAleatorio()
    {
        // Generar una posición aleatoria dentro del rango definido
        float posX = Random.Range(rangoXMin, rangoXMax);
        float posZ = Random.Range(rangoZMin, rangoZMax);

        // Establecer la nueva posición de destino
        destino = new Vector3(posX, transform.position.y, posZ);
    }
}