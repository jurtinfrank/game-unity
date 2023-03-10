using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentanaEmergente : MonoBehaviour
{
    public GameObject Ventana;

    public void OpenVentana ()
    {
        if (Ventana != null)
        {
            bool isActive = Ventana.activeSelf;

            Ventana.SetActive(!isActive);
        }
    }
}
