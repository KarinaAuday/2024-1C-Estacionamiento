﻿namespace _2024__1C_Estacionamiento.Models
{
    public class Cliente : Persona
    {
        public string Cuil { get; set; }

        public List<ClienteVehiculo> VehiculosAutorizados { get; set; } 

          
    }
}
