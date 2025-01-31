using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 5f; // velocidad de la bola
    public float fuerza = 10f;

    void Start()
    {
        // movimiento inicial aleatorio
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = Random.insideUnitSphere * speed;
    }

    void FixedUpdate()
    {
        // comprobar si la bola está fuera de los límites de la pantalla
        if (transform.position.magnitude > 10f)
        {
            // invertir la dirección de la velocidad
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity *= -1f;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rebotable"))
        {
            Vector3 direccion = collision.contacts[0].point - transform.position;
            direccion = -direccion.normalized;

            // Generar un ángulo aleatorio en el plano XY
            float aleatorio = Random.Range(0f, 90f);
            Quaternion rotacionAleatoria = Quaternion.Euler(0f, aleatorio, 0f);
            Vector3 direccionAleatoria = rotacionAleatoria * direccion;

            GetComponent<Rigidbody>().AddForce(direccionAleatoria * fuerza, ForceMode.Impulse);
        }
    }
}