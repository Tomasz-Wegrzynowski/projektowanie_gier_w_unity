using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random=UnityEngine.Random;

public class zadanie1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int maxObjects = 9;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;
    Collider m_Collider;
    Vector3 m_Size;

    void Start()
    {
        m_Collider = GetComponent<Collider>();
        m_Size = m_Collider.bounds.size;
        // List<int> pozycje_x = new List<int>(Enumerable.Range(0, maxObjects).OrderBy(x => Guid.NewGuid()).Take(maxObjects));
        // List<int> pozycje_z = new List<int>(Enumerable.Range(0, maxObjects).OrderBy(x => Guid.NewGuid()).Take(maxObjects));
        // List<int> pozycje_x = new List<int>(Enumerable.Range(0, 20).OrderBy(x => Guid.NewGuid()).Take(maxObjects));
        // List<int> pozycje_z = new List<int>(Enumerable.Range(0, 20).OrderBy(x => Guid.NewGuid()).Take(maxObjects));
        int min_x= (int)(transform.position.x - (m_Size.x/2));
        int max_x= (int)(transform.position.x + (m_Size.x/2));
        int min_z= (int)(transform.position.z - (m_Size.z/2));
        int max_z= (int)(transform.position.z + (m_Size.z/2));

        for(int i=0; i<maxObjects; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(min_x,max_x),5, Random.Range(min_z, max_z));
            this.positions.Add(randomSpawnPosition);
        }
        foreach(Vector3 elem in positions){
            Debug.Log(elem);
        }
        //Output to the console the size of the Collider volume
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach(Vector3 pos in positions)
        {
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}

