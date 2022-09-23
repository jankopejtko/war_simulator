using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] private int numberOfSoldiers;
    [SerializeField] private int rotation;
    [SerializeField] private GameObject soldier1;
    [SerializeField] private GameObject soldier2;
    [SerializeField] private GameObject soldier3;
    [SerializeField] private float min_x;
    [SerializeField] private float max_x;

    void Start()
    {
        for (int i = 0; i < numberOfSoldiers; i++)
        {
            float n = Random.Range(1, 4);
            switch (n) 
            {
                case 1:
                    Instantiate(soldier1, new Vector3(Random.Range(min_x, max_x), 8f, Random.Range(-4f, 4f)), Quaternion.Euler(0, rotation, 0));
                    break;
                case 2:
                    Instantiate(soldier2, new Vector3(Random.Range(min_x, max_x), 8f, Random.Range(-4f, 4f)), Quaternion.Euler(0, rotation, 0));
                    break;
                case 3:
                    Instantiate(soldier3, new Vector3(Random.Range(min_x, max_x), 8f, Random.Range(-4f, 4f)), Quaternion.Euler(0, rotation, 0));
                    break;
            }
        }
    }
    //public static void SpawnSoldiers(int number, GameObject soldier1, GameObject soldier2, GameObject soldier3, int rotation) 
    //{
    //    for (int i = 0; i < number; i++)
    //    {
    //        float n = Random.Range(0f, 10f);
    //        if (n > 5f)
    //        {
    //            Instantiate(soldier1, new Vector3(Random.Range(min_x, max_x), 8.45f, Random.Range(-4f, 4f)), Quaternion.Euler(0, rotation, 0));
    //        }
    //        else
    //        {
    //            Instantiate(soldier2, new Vector3(Random.Range(min_x, max_x), 8.45f, Random.Range(-4f, 4f)), Quaternion.Euler(0, rotation, 0));
    //        }
    //    }
    //}
}
