using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerzaAscenso = 30f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Hacemos el objeto kinem�tico para que no sea afectado por la gravedad inicialmente
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            rb.isKinematic = false; // Desactivamos la cinem�tica para que el objeto sea afectado por las fuerzas
            rb.AddForce(Vector3.up * fuerzaAscenso, ForceMode.Force);
        }
    }
}
