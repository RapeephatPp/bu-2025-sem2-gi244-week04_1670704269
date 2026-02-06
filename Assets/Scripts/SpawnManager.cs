using System;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   
    public GameObject [] dogPrefabs;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            float x = UnityEngine.Random.Range(-10f, 10f);
            int index = UnityEngine.Random.Range(0, dogPrefabs.Length);
            if (dogPrefabs[index] != null)
            {
                Instantiate(dogPrefabs[index], new Vector3(x, 0, 20), Quaternion.Euler(0, 180, 0));
            }
            else
            {
                Debug.LogWarning("No dog prefab found");
            }
        }
    }
}
