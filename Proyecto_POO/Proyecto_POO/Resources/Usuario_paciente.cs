using System;

public class Usuario_paciente : Usuario {
    public Usuario_paciente(String codigo, String contrasena)
        : base(codigo, contrasena)
    {
       
    }
    public override bool modificarPaciente(String numeroDeAfiliacion) 
    {
        bool bandera = false;
        if (this.codigo == numeroDeAfiliacion)
        {
            bandera = true;
        }
        return bandera;
    }
    public override bool darAltaPaciente(String numeroDeAfiliacion)
    {
        bool bandera = false;
        if (this.codigo == numeroDeAfiliacion)
        {
            bandera = true;
        }
        return bandera;
    }
    public override bool trasladoPaciente(String numeroDeAfiliacion)
    {
        bool bandera = false;
        if (this.codigo == numeroDeAfiliacion) 
        {
            bandera = true;
        }
        return bandera;
    }
    public override bool ingresarPaciente()
    {
        return false;
    }
}
