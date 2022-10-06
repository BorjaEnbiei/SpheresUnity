using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < 10; i++)
        {
            Vector3 spawnSphere = new Vector3(Random.Range(5,-5),5,Random.Range(5,-5));
            Instantiate(sphere, spawnSphere, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
