using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject prefabProyectil;
    public Transform firePoint;
    public float force;

    // Update is called once per frame
    void Update()
    {
        ManageTouch();
        if (Input.GetKeyDown(KeyCode.Space)){
            Disparar();
        }
    }
    private void ManageTouch()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Disparar();
            }
        }
    }

    private void Disparar()
    {
        GameObject proyectil = Instantiate(prefabProyectil, firePoint.position, Quaternion.identity);
        proyectil.GetComponent<Rigidbody>().AddForce(firePoint.forward * force);
    }
}