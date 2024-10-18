using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public int NumberOfWheels = 0;
    public bool Engine;
    public int Passengers = 0;
    public bool Cargo;

    void Start()
    {
        Engine = Cargo;

        VehicleRequirements requirements = new VehicleRequirements();
        requirements.NumberOfWheels = NumberOfWheels;
        requirements.Engine = Engine;
        requirements.Passengers = Passengers;

        IVehicle v = GetVehicle(requirements);
        Debug.Log(v);
    }

    private static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }

    public void WheeslUp()
    {
        NumberOfWheels += 1;
        Debug.Log("Number of Wheels: " + NumberOfWheels);
    }
    public void WheelsDown()
    {
        NumberOfWheels -= 1;
        Debug.Log("Number of Wheels: " + NumberOfWheels);
    }
    public void PassengersUp()
    {
        Passengers += 1;
        Debug.Log("Number of Passengers: " + Passengers);
    }
    public void PassengersDown()
    {
        Passengers -= 1;
        Debug.Log("Number of Passengers: " + Passengers);
    }
    public void CargoToggle(bool current)
    {
        if (current == false)
        {
            Cargo = true;
        }
        if (current == true)
        {
            Cargo = false;
        }
    }
    public void EngineToggle(bool current)
    {
        if (current == false)
        {
            Engine = true;
        }
        if (current == true)
        {
            Engine = false;
        }
    }
    public void OnStart()
    {
        Engine = Cargo;

        VehicleRequirements requirements = new VehicleRequirements();
        requirements.NumberOfWheels = NumberOfWheels;
        requirements.Engine = Engine;
        requirements.Passengers = Passengers;

        IVehicle v = GetVehicle(requirements);
        Debug.Log(v);
    }
}
