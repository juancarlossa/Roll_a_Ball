using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float rangoXMin; // Valor m�nimo del rango de movimiento en el eje X
    public float rangoXMax; // Valor m�ximo del rango de movimiento en el eje X
    public float rangoZMin; // Valor m�nimo del rango de movimiento en el eje Z
    public float rangoZMax; // Valor m�ximo del rango de movimiento en el eje Z
    public float velocidad = 3; // Velocidad de movimiento de los objetos

    private Vector3 destino; // Posici�n de destino actual del objeto

    private void Start()
    {
        // Generar la primera posici�n de destino aleatoria
        GenerarDestinoAleatorio();
    }

    private void Update()
    {
        // Mover el objeto hacia el destino
        transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);

        // Comprobar si el objeto ha llegado al destino
        if (transform.position == destino)
        {
            // Generar una nueva posici�n de destino aleatoria
            GenerarDestinoAleatorio();
        }
    }

    private void GenerarDestinoAleatorio()
    {
        // Generar una posici�n aleatoria dentro del rango definido
        float posX = Random.Range(rangoXMin, rangoXMax);
        float posZ = Random.Range(rangoZMin, rangoZMax);

        // Establecer la nueva posici�n de destino
        destino = new Vector3(posX, transform.position.y, posZ);
    }
}