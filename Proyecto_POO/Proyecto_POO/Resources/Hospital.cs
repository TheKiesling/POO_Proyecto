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
     * asignarPaciente: agrega un paciente a la lista de pacientes
     * @param paciente
     */
    public void asignarPaciente(Paciente paciente){
        pacientes.Add(paciente);
    }
    //****************************************************************

}
