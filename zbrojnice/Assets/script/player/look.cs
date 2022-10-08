//Jan Kopejtko, 2022

using UnityEngine;

public class look : MonoBehaviour
{
    public float mousesenzitivity = 100f;
    public Transform hractelo;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesenzitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesenzitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        hractelo.Rotate(Vector3.up * mouseX);
        
        
    }


}
