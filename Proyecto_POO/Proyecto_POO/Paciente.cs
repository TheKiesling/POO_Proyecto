using System;

public class Paciente
{
    /**
    @author: José Pablo Kiesling Lange
    Nombre del programa: Paciente.cs
    @version: 
        - Creación: 24/09/2021
        - Última modificación: 24/09/2021

    Clase que tiene los métodos y propiedades de los pacientes para su manejo en el sistema
     */

    //---------------------------PROPIEDADES-------------------------
    private String nombre;
    private int edad;
    private String sexo;
    private String DPI;
    private String enfermedad;
    private String fecha_nacimiento;
    private String numero_afiliacion;
    private String tipo_afiliacion;

    /*****************************************************************
     * Paciente: asigna valores a las propiedades por medio de argumentos indicados por el usuario
     * @param nombre
     * @param edad
     * @param sexo
     * @param DPI
     * @param enfermedad
     * @param fecha_nacimiento
     * @param numero_afiliacion
     * @param tipo_afiliacion
     */
    public Paciente(String nombre, int edad, String sexo, String DPI, String enfermedad, String fecha_nacimiento, String numero_afiliacion, String tipo_afiliacion){
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
        this.DPI = DPI;
        this.enfermedad = enfermedad;
        this.fecha_nacimiento = fecha_nacimiento;
        this.numero_afiliacion = numero_afiliacion;
        this.tipo_afiliacion = tipo_afiliacion;
	}
    //****************************************************************

    /*****************************************************************
     * cambioEstadoSalud: asigna un valor vacío a enfermedad simbolizando que ya no posee enfermedad
     */
    public void cambioEstadoSalud(){
        this.enfermedad = "";
    }
    //****************************************************************

    /*****************************************************************
     * cambioEstadoSalud: asigna una nueva enfermedad al paciente en caso sea necesario
     * @param nueva_enfermedad
     */
    public void cambioEstadoSalud(String nueva_enfermedad) {
        this.enfermedad = nueva_enfermedad
    }
    //****************************************************************
}
