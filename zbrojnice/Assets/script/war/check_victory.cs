//Jan Kopejtko, 2022

using UnityEngine.SceneManagement;
using UnityEngine;

public class check_victory : MonoBehaviour
{
    void Update()
    {
        if(warehouse.sodliersGreen_num == 1 || warehouse.sodliersRed_num == 1) 
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("main screen");
        }
    }
}
