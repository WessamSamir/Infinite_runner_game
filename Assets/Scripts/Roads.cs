using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class Roads : MonoBehaviour
{
    public GameObject[] rodas;
    float zSpawn = 0;
    float tileLength = 20;
    int numOfTiles = 4;
    private Transform playerTransform;
    [SerializeField] NavMeshSurface surface;

    List<GameObject> activeTiles = new List<GameObject>();

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i=0; i<numOfTiles; i++)
        {

            GenerateTile(0);

        }
        surface.BuildNavMesh();
    }

    void Update()
    {
        if(playerTransform.position.z - 35 > zSpawn - (numOfTiles * tileLength))
        {
            GenerateTile(Random.Range(0, rodas.Length));
            DeleteTile();
        }
    }

    void GenerateTile(int indx)
    {
        GameObject go = Instantiate(rodas[indx], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;
        
    }

    void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
