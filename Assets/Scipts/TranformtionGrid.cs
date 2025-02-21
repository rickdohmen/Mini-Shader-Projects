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
            for(int y = 0; y < gridResolution; y++)
            {
                for(int x = 0; x < gridResolution; x++)
                {
                    grid[i] = CreatGridPoint(x, y, z);
                }
            }
        }

        
    }

    Transform CreatGridPoint(int x, int y, int z)
    {
        Transform point = Instantiate<Transform>(prefab);
        point.localPosition = GetCoordination(x, y, z);
        point.GetComponent<MeshRenderer>().material.color = new Color
            (
                (float) x / gridResolution, (float) y / gridResolution, (float) z / gridResolution
            );
        return point;
    }

    Vector3 GetCoordination(int x, int y, int z)
    {
        return new Vector3(x - (gridResolution - 1) * 0.5f, y - (gridResolution - 1) * 0.5f, z - (gridResolution - 1) * 0.5f);
    }
}


