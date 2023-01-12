using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    public void SpawnPinButton()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
