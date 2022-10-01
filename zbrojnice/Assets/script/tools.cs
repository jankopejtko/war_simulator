using UnityEngine;

public class tools
{
    //soldiers
    public static void spawnSoldiers(GameObject type, int number, int soldier_rotation, float min_x_location, float max_x_location, string tag, int max_number = 300) 
    {
        if (number > max_number)
        {
            return;
        }
        else
        {
            for (int i = 0; i < number; i++)
            {
                GameObject soldier = GameObject.Instantiate(type, new Vector3(Random.Range(min_x_location, max_x_location), 8, Random.Range(-4f, 4f)), Quaternion.Euler(0, soldier_rotation, 0));
                soldier.tag = tag;
            }
        }
    }
}
