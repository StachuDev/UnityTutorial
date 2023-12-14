using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public ScoreManager manager;
    private void OnTriggerEnter(Collider collider){
        // manager.AddPoint();
        ScoreManager.instance.AddPoint();

        Destroy(collider.gameObject);
    }
}
