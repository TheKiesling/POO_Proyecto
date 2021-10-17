using System;

public class Usuario_admin : Usuario {
    /**
    @author: Diego E. Lemus L.
    Nombre del programa: Usuario_admin.cs
    @version: 
        - Creación: 10/10/2021
        - Última modificación: 10/10/2021

    Clase hija de Usuario que tiene los métodos para el manejo de usuarios en general
     */

    //---------------------------PROPIEDADES-------------------------
    private Hospital hospital;

    //-----------------------------MÉTODOS---------------------------
    public Usuario_admin(String codigo, String contrasena, String tipo)
        : base(codigo, contrasena, tipo)
    {
       
    }

    /****
     * Modificar Paciente
     * @param numero_afiliacion
     */
    public override bool modificarPaciente(String numeroDeAfiliacion) 
    {
        return true;
    }

    /****
     * Dar de alta al Paciente
     * @param numero_afiliacion
     */
    public override bool darAltaPaciente(String numeroDeAfiliacion)
    {
        return true;
    }

    /****
     * Traslado Paciente
     * @param numero_afiliacion
     */
    public override bool trasladoPaciente(String numeroDeAfiliacion)
    {
        return true;
    }

    /****
     * Ingresar Paciente
     * @param null
     */
    public override bool ingresarPaciente()
    {
        return true;
    }
}
