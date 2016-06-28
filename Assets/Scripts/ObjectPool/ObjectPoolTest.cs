using UnityEngine;
using System.Collections;

public class ObjectPoolTest : MonoBehaviour
{
    public GameObject cubePrefab;

    ObjectPool<GameObject> cubePool;
    void Awake()
    {
        cubePool = new ObjectPool<GameObject>();
        cubePool.original = cubePrefab;

        cubePool.createMethod = CubeCreate;
        cubePool.initMethod = (GameObject target) =>
        {
            target.SetActive(true);
        };
        cubePool.releaseMethod = (GameObject target) =>
        {
            target.SetActive(false);
        };

        cubePool.Init(10);
    }

    GameObject CubeCreate(GameObject cube)
    {
        return Instantiate(cube);
    }
}
