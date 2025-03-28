using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformType : MonoBehaviour
{
    public Text txtPlatform;
    // Start is called before the first frame update
    void Start()
    {
        if (Application.isMobilePlatform) {
            Debug.Log("Dispositivo móvil detectado");
            txtPlatform.text = "Dispositivo móvil detectado";
            // Configurar ajustes específicos para móviles
        } else {
            Debug.Log("Dispositivo desktop detectado");
            txtPlatform.text = "Dispositivo desktop detectado";
            // Configurar ajustes para desktop
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
