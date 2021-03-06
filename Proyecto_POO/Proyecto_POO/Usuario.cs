using System;

public abstract class Usuario
{
    /**
    @author: José Pablo Kiesling Lange
    Nombre del programa: Usuario.cs
    @version: 
        - Creación: 09/10/2021
        - Última modificación: 09/10/2021

    Clase madre que tiene las propiedades y los métodos genéricos de los usuarios
     */

    //---------------------------PROPIEDADES-------------------------
    protected String codigo;
    protected String contrasena;

    //-----------------------------MÉTODOS---------------------------
    public Usuario(String codigo, String contrasena)
	{
        this.codigo = codigo;
        this.contrasena = contrasena;
	}

    public abstract void modificarPaciente(); //administrador puede cambiar la propia o la de alguien más; paciente solo la propia

    public abstract void darAltaPaciente();

    public abstract void trasladoPaciente();

    public abstract void ingresarPaciente();

    public void cambiarContrasena(String contrasena)
    {
        this.contrasena = contrasena;
    }
}
