using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public List<KimBehaviour> kims = new List<KimBehaviour>();
    public GameObject kimPrefab;
    
    public KimBehaviour Create(Vector3 position, Quaternion rotation)
    {
        KimBehaviour kim = null;

        if (kims.Count > 0 )//si kims en réserve
        {
            kim = kims[0];
            kims.RemoveAt(0); //remove la kim en 0
            kim.transform.rotation = rotation;
            kim.transform.position = position;
            kim.gameObject.SetActive(true);

        }
        else //sinon
        {
            GameObject kimGo = Instantiate(kimPrefab, position, rotation);
            kim = kimGo.GetComponent<KimBehaviour>();

        }

        return kim;
    }

    public void Kill(KimBehaviour kim)
    {
        kim.gameObject.SetActive(false); //desactive le game object
        kims.Add(kim);

    }
}
