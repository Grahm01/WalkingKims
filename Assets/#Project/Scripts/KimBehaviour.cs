using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class KimBehaviour : MonoBehaviour
{
    public Vector3 destination;
    private Pool pool;

    private void Start()
    {
        pool = FindObjectOfType<Pool>();
    }
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
    private void OnMouseDown()
    {
        pool.Kill(this);
    }
}
