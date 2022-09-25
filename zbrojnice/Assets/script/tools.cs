using UnityEngine;

public class tools
{
    public static void spawnSoldiers(GameObject type, int number, int max_number, int soldier_rotation, float min_x_location, float max_x_location) 
    {
        if (number > max_number)
        {
            return;
        }
        else
        {
            for (int i = 0; i < number; i++)
            {
                Object.Instantiate(type, new Vector3(Random.Range(min_x_location, max_x_location), 8, Random.Range(-4f, 4f)), Quaternion.Euler(0, soldier_rotation, 0));
            }
        }
    }
}
