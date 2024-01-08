using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeArrayRed : MonoBehaviour
{
    [SerializeField]
    private GameObject[] playerCubes;

    void Start()
    {
        playerCubes = GetCubes();
    }

    private GameObject[] GetCubes()
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Player");

        foreach ( GameObject cube in cubes)
        {
            cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
        }

        return cubes;
    }

=======
public class CubeArray : MonoBehaviour
{
    public GameObject[] cubes;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //foreach (var cube in cubes)
            //{
            //    cube.GetComponent<Renderer>().material.color = Color.red;
            //}
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
>>>>>>> dcebb6cd41cf90d1e24547e9d6632094c9d0a41c
}
