using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class zad1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;

    public int cubeCount = 5;

    public Material[] materials;


    void Start()
    {
        Transform planeTransform = transform;
        Vector3 planeScale = planeTransform.lossyScale;
        // Vector3Int planeScaleRangeInt = Vector3Int.FloorToInt(planeScale);


        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        // List<int> pozycje_x = new List<int>(Enumerable.Range(-Mathf.RoundToInt(planeScale.x * 5), Mathf.RoundToInt(planeScale.x * 5)).OrderBy(x => Guid.NewGuid()).Take(cubeCount));
        // List<int> pozycje_z = new List<int>(Enumerable.Range(-Mathf.RoundToInt(planeScale.z * 5), Mathf.RoundToInt(planeScale.z * 5)).OrderBy(x => Guid.NewGuid()).Take(cubeCount));

        List<int> pozycje_z = new List<int>(Enumerable.Range(Mathf.RoundToInt(planeTransform.position.z) - 4, 8).OrderBy(x => Guid.NewGuid()).Take(cubeCount));
        List<int> pozycje_x = new List<int>(Enumerable.Range(Mathf.RoundToInt(planeTransform.position.x) - 4, 8).OrderBy(x => Guid.NewGuid()).Take(cubeCount));

        for (int i = 0; i < cubeCount; i++)
        {
            // this.positions.Add(new Vector3(transform.position.x - pozycje_x[i], transform.position.y, transform.position.z - pozycje_z[i]));
            this.positions.Add(new Vector3(pozycje_x[i], planeTransform.position.y + 0.5f, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        if (positions == null || materials == null || block == null)
        {
            Debug.Log("One of the required variables is null");
            yield break;
        }

        foreach (Vector3 pos in positions)
        {

            GameObject obj = Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            MeshRenderer renderer = obj.GetComponent<MeshRenderer>();
            if (renderer == null)
            {
                renderer = obj.AddComponent<MeshRenderer>();
            }
            Material randomMaterial = materials[UnityEngine.Random.Range(0, materials.Length)];
            renderer.material = randomMaterial;
            yield return new WaitForSeconds(this.delay);

        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}