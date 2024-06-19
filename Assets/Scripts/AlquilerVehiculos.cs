using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public Vehiculo[] vehiculos;

    private float prom;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        ActivarCartelesPromoDe4Ruedas();
        CalcularPromedio();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetearVehiculos();
        }
    }

    void ResetearVehiculos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].CartelPromo.SetActive(false);
        }

        randomIndex = Random.Range(0, vehiculos.Length);

        vehiculos[randomIndex].CartelPromo.SetActive(true);
    } 

    void ActivarCartelesPromoDe4Ruedas()
    {
        for (int i = 0;i < vehiculos.Length;i++)
        {
            if (vehiculos[i].cantRuedas < 4)
            {
                vehiculos[i].CartelPromo.SetActive(false);
            }
        }
    }

    void CalcularPromedio()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            prom =+ vehiculos[i].precioAlquiler;
        }
        Debug.Log("Promedio del precio de los alquileres: " + prom);
    } 
}
