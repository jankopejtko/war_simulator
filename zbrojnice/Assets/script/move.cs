using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody hrac;
    public CharacterController ovladani;
    public float pohyb_rychlost = 15f;

    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 pohyb = transform.right * x + transform.forward * z;

        ovladani.Move(pohyb * pohyb_rychlost * Time.deltaTime);
    }
}

