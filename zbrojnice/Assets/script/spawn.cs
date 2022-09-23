using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] private int numberOfSoldiers;
    [SerializeField] private int rotation;
    [SerializeField] private GameObject soldier1;
    [SerializeField] private GameObject soldier2;

    void Start()
    {
        for(int i = 0; i < numberOfSoldiers; i++) 
        {
            float n = Random.Range(0f, 10f);
            if(n > 5f)
            {
                Instantiate(soldier1, new Vector3(Random.Range(0.5f, 7f), 8.45f, Random.Range(-4f,4f)), Quaternion.Euler(0,-90,0));
            }
            else 
            {
                Instantiate(soldier2, new Vector3(Random.Range(0.5f, 7f), 8.45f, Random.Range(-4f,4f)), Quaternion.Euler(0,-90,0));
            }
        }
    }
}
