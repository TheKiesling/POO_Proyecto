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
    public string[] buscar_paciente(string numero_afiliación) {
        string[] datos=new string[6];
        foreach (Paciente paciente in pacientes) {
            if (paciente != null) {                
                if (paciente.getNumeroAfiliacion() == numero_afiliación) {
                    datos[0] = paciente.getNombre();
                    datos[1] = paciente.getFechaNacimiento();
                    datos[2] = paciente.getSexo();
                    datos[3] = paciente.getDPI();
                    datos[4] = paciente.getEnfermedad();
                    datos[5] = paciente.getTipoAfiliacion();
                }
            }
        }
        return datos;
    }

    public Boolean retirar_paciente(string numero_afiliación){
        Boolean retiro = false;
        foreach (Paciente paciente in pacientes){
            if (paciente != null){
                if (paciente.getNumeroAfiliacion() == numero_afiliación){
                    pacientes.Remove(paciente);
                }
            }
        }
        return retiro;
    }
}
