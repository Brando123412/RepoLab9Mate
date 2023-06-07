using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    [SerializeField] private Transform[] checkpointsPatrol;
    [SerializeField] private Rigidbody myRB;
    [SerializeField] private float velocityModifier = 5f;
    [SerializeField] private Transform currentPositionTarget;
    private int patrolPos = 0;
    Vector3 velocidad;
    [SerializeField] int[] tiempos ;

    private void Start() {
        currentPositionTarget = checkpointsPatrol[patrolPos];
        transform.position = currentPositionTarget.position;
    }
    private void CheckNewPoint() {
        transform.position = currentPositionTarget.position;
        patrolPos = patrolPos + 1 == checkpointsPatrol.Length ? 0 : patrolPos + 1;
        currentPositionTarget = checkpointsPatrol[patrolPos];

        Vector3 distanceTarget = (currentPositionTarget.position - transform.position);
        velocidad = distanceTarget / tiempos[patrolPos];

        myRB.velocity = new Vector3(velocidad.x, 0, velocidad.z);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Puntos"))
        {
            CheckNewPoint();
        }
    }
}
