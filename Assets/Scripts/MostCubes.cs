using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostCubes : MonoBehaviour
{
    public float speed = 2f;
    public float maxHeight = 5f;
    public float minHeight = 0f;

    private float direction = 1f;

    private void Update()
    {
        // Calcula la nueva posici�n del cubo
        float newY = transform.position.y + speed * direction * Time.deltaTime;
        newY = Mathf.Clamp(newY, minHeight, maxHeight);
        Vector3 newPosition = new Vector3(transform.position.x, newY, transform.position.z);

        // Actualiza la posici�n del cubo
        transform.position = newPosition;

        // Cambia la direcci�n cuando alcanza los l�mites
        if (transform.position.y >= maxHeight || transform.position.y <= minHeight)
        {
            direction *= -1f;
        }
    }
}