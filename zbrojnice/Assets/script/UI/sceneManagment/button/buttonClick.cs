//Jan Kopejtko, 2022

using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonClick : MonoBehaviour
{
    public static void startSim() 
    {
        SceneManager.LoadScene("game");
    }
    public static void exit() 
    {
        Application.Quit();
    }
}
