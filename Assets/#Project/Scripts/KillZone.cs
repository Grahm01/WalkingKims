using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Pool pool;
    private void OnTriggerEnter(Collider other)
    {
        KimBehaviour kim = other.GetComponent<KimBehaviour>();
        if (kim != null)
        {
            pool.Kill(kim);
        }
    }
}
