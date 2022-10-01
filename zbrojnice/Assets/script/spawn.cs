using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] private int numberOfSoldiers;
    [SerializeField] private int max_numberOfSoldiers;
    [SerializeField] private int rotation;
    [SerializeField] private GameObject soldier1;
    [SerializeField] private GameObject soldier2;
    [SerializeField] private GameObject soldier3;
    [SerializeField] private float min_x;
    [SerializeField] private float max_x;
    [SerializeField] private string tag;

    void Start()
    {
        tools.spawnSoldiers(soldier1, numberOfSoldiers, rotation, min_x, max_x, tag, max_numberOfSoldiers);
    }
}
