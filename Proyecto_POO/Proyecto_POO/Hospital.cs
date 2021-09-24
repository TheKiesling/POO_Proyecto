using System;
using System.Collections.Generic;

public class Hospital
{
    /**
    @author: José Pablo Kiesling Lange
    Nombre del programa: Paciente.cs
    @version: 
        - Creación: 24/09/2021
        - Última modificación: 24/09/2021

    Clase que tiene los métodos y propiedades del hospital para la gestión de pacientes 
     */

    //---------------------------PROPIEDADES-------------------------
    private Paciente paciente;
    private String unidad;
    private List<Paciente> pacientes = new List<Paciente>();

    public Hospital(){

	}

    /*****************************************************************
     * asignarPaciente: instancia un paciente y lo agrega a la lista de pacientes
     * @param nombre
     * @param edad
     * @param sexo
     * @param DPI
     * @param enfermedad
     * @param fecha_nacimiento
     * @param numero_afiliacion
     * @param tipo_afiliacion
     */
    public void asignarPaciente(String nombre, int edad, String sexo, String DPI, String enfermedad, String fecha_nacimiento, String numero_afiliacion, String tipo_afiliacion){
        paciente = new Paciente(nombre, edad, sexo, DPI, enfermedad, fecha_nacimiento, numero_afiliacion, tipo_afiliacion);
        pacientes.Add(paciente);
    }
    //****************************************************************

}
