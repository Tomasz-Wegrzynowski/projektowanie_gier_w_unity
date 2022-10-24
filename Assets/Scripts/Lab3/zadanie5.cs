using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie5 : MonoBehaviour
{

    public GameObject myPrefab;
    public List<Vector3> positions = new List<Vector3>();

     void Start() {
        while (positions.Count < 10)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-5,5),5, Random.Range(-5, 5));
            positions.Add(randomSpawnPosition);
        }

         for (int i = 0; i < 10; i++) {
            Instantiate(myPrefab, positions[i], Quaternion.identity);
         }
     }
}
