using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLift : MonoBehaviour
{
    public float speed = 3f;
    public float maxHeight = 30f;
    public float minHeight = 14f;

    private float direction = 1f;

    private void Update()
    {
        GameObject objetoConScript1 = GameObject.Find("Player"); // Reemplaza "NombreDelObjeto" con el nombre del objeto en la jerarquía de Unity
        PlayerController playerControler = objetoConScript1.GetComponent<PlayerController>();

        int count = playerControler.count;
        if (count >= 20)
        {
            // Calcula la nueva posición del cubo
            float newY = transform.position.y + speed * direction * Time.deltaTime;
            newY = Mathf.Clamp(newY, minHeight, maxHeight);
            Vector3 newPosition = new Vector3(transform.position.x, newY, transform.position.z);

            // Actualiza la posición del cubo
            transform.position = newPosition;

            // Cambia la dirección cuando alcanza los límites
            if (transform.position.y >= maxHeight || transform.position.y <= minHeight)
            {
                direction *= -1f;
            }
        }
    }
}