using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Hospital
{
    /**
    @author: José Pablo Kiesling Lange
    Nombre del programa: Hospital.cs
    @version: 
        - Creación: 24/09/2021
        - Última modificación: 03/09/2021

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

    /****
     * Buscar Paciente: busca al paciente en la lista de pacientes
     * @param numero_afiliacion
     */
    public string[] buscar_paciente(string numero_afiliación) {
        string[] datos=new string[7];
        foreach (Paciente paciente in pacientes) {
            if (paciente != null) {                
                if (paciente.getNumeroAfiliacion() == numero_afiliación) {
                    datos[0] = paciente.getNombre();
                    datos[1] = paciente.getFechaNacimiento();
                    datos[2] = paciente.getSexo();
                    datos[3] = paciente.getDPI();
                    datos[4] = paciente.getEnfermedad();
                    datos[5] = paciente.getTipoAfiliacion();
                    datos[6] = paciente.getSede();
                }
            }
        }
        return datos;
    }

    public Boolean recorrerArreglo(String numero_afiliacion)
    {
        Boolean verificacion = false;
        foreach (Paciente paciente in pacientes)
        {
            if (paciente != null)
            {
                if (paciente.getNumeroAfiliacion() == numero_afiliacion)
                {
                    verificacion = true;
                }
            }
        }
        return verificacion;
    }

    /****
     * Retirar Paciente: retira el paciente de la lista de pacientes
     * @param numero_afiliacion
     */
    public Boolean retirar_paciente(string numero_afiliación){
        Boolean retiro = false;
        for (int i = 0; i < pacientes.Count() && retiro == false;i++){
            if (pacientes[i] != null)
            {
                if (pacientes[i].getNumeroAfiliacion() == numero_afiliación)
                {
                    pacientes.Remove(pacientes[i]);
                    retiro = true;
                }
            }
        }
        return retiro;
    }
    /*************************************************************************************************
     * modificar paciente: Modifica un paciente de la lista de pacientes
     * @param numero_afiliacion
     */
    public Boolean modificar_paciente(string numero_afiliación)
    {
        Boolean modificar = false;
        string[] datos = buscar_paciente(numero_afiliación);
        modificar = retirar_paciente(numero_afiliación);
        Paciente paciente_modificado = new Paciente(datos[0], datos[1], datos[2], datos[3], datos[4], numero_afiliación, datos[5], datos[6]);
        return modificar;
    }

    public Boolean trasladoPaciente(string numero_afiliación, string sede)
    {
        Boolean traslado = false;
        foreach (Paciente paciente in pacientes)
        {
            if (paciente != null)
            {
                if (paciente.getNumeroAfiliacion() == numero_afiliación)
                {
                    paciente.setSede(sede);
                    traslado = true;
                }
            }
        }

        return traslado;
    }
}
