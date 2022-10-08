//Jan Kopejtko, 2022

using UnityEngine;

public class cursor : MonoBehaviour
{
    [SerializeField] bool isVisible;
    void Start()
    {
        if (isVisible) 
        {
            Cursor.visible = true;
        }
        else 
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
