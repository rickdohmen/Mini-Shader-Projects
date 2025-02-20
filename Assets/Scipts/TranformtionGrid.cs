using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranformtionGrid : MonoBehaviour
{
    public Transform prefab;
    public int gridResolution = 10;

    Transform[] grid;

    void Awake()
    {
        grid = new Transform[gridResolution * gridResolution * gridResolution];
        for(int i = 0, z = 0; z< gridResolution; z++)
        {
            for(y = 0; y < gridResolution; y++)
            {
                for(x = 0; x < gridResolution; x++)
                {
                    grid[i] = CreateGridPoint(x, y, z);
                }
            }
        }
    }
}
