//Jan Kopejtko, 2022

using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("main screen");
        }
    }
}
