using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class die_chance : MonoBehaviour
{
    [SerializeField] GameObject soldier;
    public bool isSoldier_with_gun;
    public bool isSoldier_medic;
    private int day = 135849;
    private int multiplier = 1;
    void Update()
    {
        if (time_counter.time > day * multiplier) 
        {
            if (isSoldier_with_gun)
            {
                if (Random.Range(0, 100) < 10)
                {
                    if(soldier.tag == "green") 
                    {
                        //warehouse.sodliersGreen.Remove(soldier);
                        warehouse.weaponsGreen--;
                    }
                    if (soldier.tag == "red")
                    {
                        //warehouse.sodliersRed.Remove(soldier);
                        warehouse.weaponsRed--;
                    }
                    Destroy(soldier);
                    //Debug.Log("soldier died");
                }
            }
            else 
            {
                if (Random.Range(0, 100) < 90)
                {
                    if (soldier.tag == "green")
                    {
                        //warehouse.sodliersGreen.Remove(soldier);
                    }
                    if (soldier.tag == "red")
                    {
                        //warehouse.sodliersRed.Remove(soldier);
                    }
                    Destroy(soldier);
                    //Debug.Log("soldier died");
                }
            }
            multiplier++;
        }
    }
}
