//Jan Kopejtko, 2022

using UnityEngine;

public class soldier_logic : MonoBehaviour
{
    [SerializeField] GameObject soldier;
    public GameObject soldier_with_gun_prefab;
    public bool isSoldier_with_gun;
    public bool isSoldier_medic;
    public bool isSoldier_without_gun;
    private int day = 1;
    private int multiplier = 1;
    void Update()
    {
        if (time_counter.days > day * multiplier)
        {
            if (isSoldier_with_gun) //isSoldier_with_gun die chance
            {
                if (Random.Range(0, 100) < 10)
                {
                    if(soldier.tag == "green") 
                    {
                        warehouse.weaponsGreen--;
                    }
                    if (soldier.tag == "red")
                    {
                        warehouse.weaponsRed--;
                    }
                    Destroy(soldier);
                }
            }
            if (isSoldier_without_gun) 
            {
                if (Random.Range(0, 100) < 25) //pick up weapon
                {
                    if (soldier.tag == "green")
                    {
                        warehouse.weaponsGreen++;
                        tools.spawnSoldiers(soldier_with_gun_prefab, 1, -90, 0.5f, 6, "green");
                    }
                    if (soldier.tag == "red")
                    {
                        warehouse.weaponsRed++;
                        tools.spawnSoldiers(soldier_with_gun_prefab, 1, 90, -0.5f, -6, "red");
                    }
                    Destroy(soldier);
                }
            }
            if (isSoldier_medic)
            {
                if (Random.Range(0, 100) < 4) //medic revive chance
                {
                    if (soldier.tag == "green")
                    {
                        warehouse.weaponsGreen++;
                        tools.spawnSoldiers(soldier_with_gun_prefab, 1, -90, 0.5f, 6, "green");
                    }
                    if (soldier.tag == "red")
                    {
                        warehouse.weaponsRed++;
                        tools.spawnSoldiers(soldier_with_gun_prefab, 1, 90, -0.5f, -6, "red");
                    }
                }
                if (Random.Range(0, 100) <= 1) //medic die chance
                {
                    Destroy(soldier);
                }
            }
            if(isSoldier_without_gun) //isSoldier_without_gun die chance
            {
                if (Random.Range(0, 100) < 90)
                {
                    Destroy(soldier);
                }
            }
            multiplier++;
        }
    }
}
