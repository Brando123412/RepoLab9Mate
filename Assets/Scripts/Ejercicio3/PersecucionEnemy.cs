using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersecucionEnemy : MonoBehaviour
{
    public Transform objetivo;
    public float velocidadMaxima = 10f;
    public float aceleracion = 5f;
    public float tiempoObjetivo = 5f;

    private Rigidbody rigidbody;
    private Vector3 velocidadActual;
    private Vector3 aceleracionActual;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        velocidadActual = Vector3.zero;
        aceleracionActual = Vector3.zero;
    }
    void FixedUpdate()
    {
        Vector3 direccion = (objetivo.position - transform.position).normalized;
        float distancia = Vector3.Distance(transform.position, objetivo.position);
        float velocidadDeseada = distancia / tiempoObjetivo;

        aceleracionActual = (direccion * velocidadDeseada - velocidadActual) / tiempoObjetivo;
        aceleracionActual = Vector3.ClampMagnitude(aceleracionActual, aceleracion);

        rigidbody.AddForce(aceleracionActual, ForceMode.Acceleration);

        // Limitar la velocidad máxima
        rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, velocidadMaxima);

        velocidadActual = rigidbody.velocity;
    }
}
