using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilScript : MonoBehaviour
{
    //Variables
    public bool isWatered = false;
    public bool isSeeded = false;
    public float treeSpawnPosition = 5f;
    private bool hasTree = false;

    //GameObjects
    public GameObject treePrefab;

    private void Update()
    {
        
    }

    public void GrowTree()
    {
        if (!hasTree)
        {
            if (isWatered && isSeeded)
            {
                hasTree = true;
                Instantiate(treePrefab, new Vector2(transform.position.x, transform.position.y + treeSpawnPosition), Quaternion.identity);
            }
        }
    }
}
