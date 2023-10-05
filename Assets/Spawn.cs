using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject instanceObject;

    public Vector3 instancePosition = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(instanceObject, instancePosition, Quaternion.identity);
        }
    }
}
