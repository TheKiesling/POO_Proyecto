using System;

public class Usuario_admin : Usuario {

    private Hospital hospital;
    
    public Usuario_admin(String codigo, String contrasena, String tipo)
        : base(codigo, contrasena, tipo)
    {
       
    }
    public override bool modificarPaciente(String numeroDeAfiliacion) 
    {
        bool bandera = false;
        bandera = hospital.recorrerArreglo(numeroDeAfiliacion);

        return bandera;
    }
    public override bool darAltaPaciente(String numeroDeAfiliacion)
    {
        bool bandera = false;
        bandera = hospital.recorrerArreglo(numeroDeAfiliacion);

        return bandera;
    }

    public override bool trasladoPaciente(String numeroDeAfiliacion)
    {
        bool bandera = false;
        bandera = hospital.recorrerArreglo(numeroDeAfiliacion);

        return bandera;
    }

    public override bool ingresarPaciente()
    {
        return false;
    }
}
