using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad5 : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    // x: (-5,5)
    // z: (25, 35)
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        for (int i = 0; i < 10; i++)
        {
            Instantiate(myPrefab, new Vector3(Random.Range(-4.5f, 4.5f), 0.5f, Random.Range(24.5f, 34.5f)), Quaternion.identity);
        }
    }
}
