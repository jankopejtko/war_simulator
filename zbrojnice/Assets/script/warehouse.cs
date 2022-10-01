using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class warehouse : MonoBehaviour
{
    public int startNumOfSoldiers;
    public static int sodliersGreen_num;
    public static int sodliersRed_num;
    public static int weaponsGreen;
    public static int weaponsRed;
    public Text greenNumber_text;
    public Text redNumber_text;
    public Text greenweapons_text;
    public Text redweapons_text;
    public GameObject greenSoldier;
    public GameObject redSoldier;
    public GameObject greenMedic;
    public GameObject redMedic;
    public GameObject greenSoldier_without_gun;
    public GameObject redSoldier_without_gun;
    private void Start()
    {
        weaponsGreen = Random.Range(40, 100);
        weaponsRed = Random.Range(40, 100);
        //first spawn
        tools.spawnSoldiers(greenSoldier, weaponsGreen, -90, 0.5f, 6, "green");
        tools.spawnSoldiers(redSoldier, weaponsRed, 90, -0.5f, -6, "red");

        tools.spawnSoldiers(greenMedic, 2, -90, 0.5f, 6, "green");
        tools.spawnSoldiers(redMedic, 2, 90, -0.5f, -6, "red");

        tools.spawnSoldiers(greenSoldier_without_gun, startNumOfSoldiers - 2 - weaponsGreen, -90, 0.5f, 6, "green");
        tools.spawnSoldiers(redSoldier_without_gun, startNumOfSoldiers - 2 - weaponsRed, 90, -0.5f, -6, "red");
    }
    private void Update()
    {
        sodliersGreen_num = 0;
        sodliersRed_num = 0;
        foreach (GameObject soldier in GameObject.FindGameObjectsWithTag("green"))
        {
            sodliersGreen_num++;
        }
        foreach (GameObject soldier in GameObject.FindGameObjectsWithTag("red"))
        {
            sodliersRed_num++;
        }
        greenNumber_text.text = "number of soldiers: " + sodliersGreen_num.ToString();
        redNumber_text.text = "number of soldiers: " + sodliersRed_num.ToString();
        greenweapons_text.text = "number of weapons: " + weaponsGreen.ToString();
        redweapons_text.text = "number of weapons: " + weaponsRed.ToString();
    }
}
