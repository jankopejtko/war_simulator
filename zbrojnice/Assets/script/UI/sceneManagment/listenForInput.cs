//Jan Kopejtko, 2022

using UnityEngine;
using UnityEngine.SceneManagement;

public class listenForInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter)) 
        {
            SceneManager.LoadScene("menu");
        }
    }
}
