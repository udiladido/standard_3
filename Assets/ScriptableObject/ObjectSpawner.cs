using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public DynamicOS test;

    private void Start()
    {
       GameObject newObject = test.CreateObject();
       newObject.transform.SetParent(gameObject.transform);
    }


}
