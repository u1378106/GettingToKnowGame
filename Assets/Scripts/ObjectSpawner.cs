using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject colorObject;
    public GameObject canvasObj;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void StartSpawningObjects()
    {
        InvokeRepeating("SpawnObjects", 2, 3);
    }

    public void SpawnObjects()
    {
        GameObject colorObj =  Instantiate(colorObject, new Vector2(Random.Range(40, 800), 600), Quaternion.identity, canvasObj.transform);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
