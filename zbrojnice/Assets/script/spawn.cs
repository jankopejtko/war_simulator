using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] private GameObject soldier;
    void Start()
    {
        Instantiate(soldier, new Vector3(, 8.5f, 0), Quaternion.identity);
    }
}
