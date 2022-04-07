using System;//espacio de nombres raiz. contiene los tipos basico de freamwork .net
using System.Windows.Forms;//contiene todos los tipos que permite la creacion de aplicaciones de windows, ya sean formularios...

namespace TAPU1_A4_PIDETEC_//Espacio de nombres utilizado para trabajar varios archivos como uno solo
{
    public partial class InicioSesion : Form //clase
    {
        
        string[] BDAlumnoEmpleadoNombre = new string[22];//declaracion e inicializacion de un arreglo
        string[] BDAlumnoEmpleadoUsuario = new string[23];//declaracion e inicializacion de un arreglo
        //Se declara i global para utilizar el valor en otros metodos de la clase
        int i = -1;
        MenuComida menu;
        public InicioSesion()//Constructor de la clase
        {//inicio bloque de codigo
            InitializeComponent();//inicializa el componente
            //Almacenamos la informacion en un arreglo de los usuarios que son empleados y alumnos
            //El usuario lleva numeros pero se coloca como string por que no lleva ninguna operacion aritmetica
            //ademas de que el usuario invitado va ingresar su nombre y no un numero

            //Empleados Nombre
            BDAlumnoEmpleadoNombre[0] = "ALAMILLA MARTINEZ ROMELIA ELIZABETH";//Empleados Nombre
             BDAlumnoEmpleadoNombre[1] = "ARELLANO AGUILAR ENRIQUE ALEJANDRO";//Empleados Nombre
            BDAlumnoEmpleadoNombre[2] = "BARRIOS GALDAMEZ ABRIL FERNANDA";//Empleados Nombre
            BDAlumnoEmpleadoNombre[3] = "CASTELLANOS HERNANDEZ BLANCA ITZEL";//Empleados Nombre
            BDAlumnoEmpleadoNombre[4] = "ESCOBAR RUIZ CINDY LETICIA";//Empleados Nombre
            BDAlumnoEmpleadoNombre[5] = "GOMEZ ALVAREZ REBECA";//Empleados Nombre
            BDAlumnoEmpleadoNombre[6] = "GUERRERO ASTUDILLO LUIS ENRIQUE";//Empleados Nombre
            BDAlumnoEmpleadoNombre[7] = "HERNANDEZ ARGUELLO BRENDA BERENICE";//Empleados Nombre
            BDAlumnoEmpleadoNombre[8] = "HERNANDEZ PEREZ LORENA GUADALUPE";//Empleados Nombre
            BDAlumnoEmpleadoNombre[9] = "LOPEZ OVANDO YURIDIANA MONTSERRAT";//Empleados Nombre


            //Empleados Usuario
            BDAlumnoEmpleadoUsuario[0] = "201000201";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[1] = "201000202";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[2] = "201000203";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[3] = "201000204";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[4] = "201000205";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[5] = "201000206";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[6] = "201000207";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[7] = "201000208";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[8] = "201000209";//Empleados Usuario
            BDAlumnoEmpleadoUsuario[9] = "201000210";//Empleados Usuario

            //Alumnos Nombre
            BDAlumnoEmpleadoNombre[10] = "ALVAREZ LOZA JOB ALBERTO";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[11] = "AVITIA MUÑIZ ELIENAI AZUCENA";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[12] = "CARRIZALES CARRILLO LUIS GAEL";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[13] = "CENICEROS CABRERA YOHEL";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[14] = "HERNANDEZ AGUILAR NAYDELIN GUADALUPE";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[15] = "JIMENEZ IBARRA HECTOR ADAIR";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[16] = "LOZA MILAN LEONARDO";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[17] = "OCHOA ESPARZA SANJUANA MELISSA";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[18] = "SCOTT CARREON PAOLA ALEJANDRA";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[19] = "VELASQUEZ VAZQUEZ DIANA KAREN";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[20] = "JOSE DE JESUS CARDENAS MATA";//Alumnos Nombre
            BDAlumnoEmpleadoNombre[21] = "CRISTOBAL JESUS ORTIZ REYNA";//Alumnos Nombre

            //Alumnos Usuario
            BDAlumnoEmpleadoUsuario[10] = "201000212";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[11] = "201000213";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[12] = "201000214";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[13] = "201000215";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[14] = "201000216";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[15] = "201000217";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[16] = "201000218";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[17] = "201000219";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[18] = "201000220";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[19] = "201000221";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[20] = "201000222";//Alumnos Usuario
            BDAlumnoEmpleadoUsuario[21] = "201000223";//Alumnos Usuario
            //Se crea un espacio en nullo para identificar que la busqueda no encontro ningun elemento
            //asociado a lo que ingreso
            BDAlumnoEmpleadoUsuario[22] = null;

        }//fin del bloque de codigo

        private void OpcInvitado_CheckedChanged(object sender, EventArgs e)//valida si el checkbox esta activado o no para mostrar un mensaje solo para invitados
        {//inicio bloque de codigo
            if (OpcInvitado.Checked == true)//determina si el checkbox esta activado
            {//inicio bloque de codigo
                TextBoxUsuario.Text = "Ingrese su nombre invitado";//muesta un mensaje para el usuario invitado
            }//fin del bloque de codigo
            else
            {//inicio del bloque de codigo
                TextBoxUsuario.Text = "Ingrese su número de empleado o control";//revierte el mensaje si se equivocó el usuario en la eleccion
            }//fin del bloque de codigo

        }//fin de bloque de codigo

        private void BtnAceptar_Click(object sender, EventArgs e)//Se determina si el tipo de usuario que quiere acceder ingresara al menu
        {//inicio bloque de codigo
            
            i = -1;//asignacion a variable

            if (OpcInvitado.Checked == false)//valida si el checkbox esta desactivado para poder analizarlo como un integrante de la BD
            {//Inicio bloque de codigo


                do//estructura do-while
                {//inicio bloque de codigo
                    //Incrementa de uno en uno para poder comparar todos los elementos del arreglo
                    i++;

                //compara todos los elementos del arreglo para identificar si encontro algo sobre lo que el usuario ingreso
                } while (TextBoxUsuario.Text != BDAlumnoEmpleadoUsuario[i] && i < BDAlumnoEmpleadoUsuario.Length - 1);
                //vacia la caja de texto del usurio
                TextBoxUsuario.Text = string.Empty;

                if (BDAlumnoEmpleadoUsuario[i] == null)//Evalua si encontró un resultado real en el arreglo
                {//inicio bloque de codigo
                    //muestra un mensaje en pantalla mediante otro form donde no se encontro ningun resultado
                    MessageBox.Show("No se encontró ningún resultado", "Ingrese nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }//fin bloque de codigo
                else
                {//inicio bloque de codigo
                    //evalua cuales son los usuarios empleados
                    //if (i >= 0 && i <= 9)
                    //{//Inicio bloque codigo
                    //    //string NombreUsuario = BDAlumnoEmpleadoNombre[i];//guarda el valor de un arreglo en una variable local
                    //    //MenuComida menuComida = new MenuComida(NombreUsuario, "Empleado. ");//carga el form con el nombre del usuario y su clasificacion empleado
                    //    //menuComida.Show();//muestra el form ya cargado

                    //}//fin bloque codigo
                    //if (i >= 10 && i <= 21)//evalua cuales son los usuarios Alumnos
                    //{//inicio bloque codigo
                    //    //string NombreUsuario = BDAlumnoEmpleadoNombre[i];//guarda el valor de un arreglo en una variable local
                    //    //MenuComida menuComida = new MenuComida(NombreUsuario, "Alumno. ");//carga el form con el nombre del usuario y su clasificacion alumno
                    //    //menuComida.Show();//muestra el form ya cargado


                    //}//cierre bloque codigo


                    menu = new MenuComida();
                    this.Hide();
                    DialogResult dr = menu.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        this.Show();
                    }


                }//cierre bloque codigo

                

            }//fin bloque de codigo
            else
            {//inicio bloque de codigo
                MenuComida menuComida = new MenuComida(TextBoxUsuario.Text, "Invitado. ");//carga el form con el nombre del usuario y su clasificacion invitado
                menuComida.Show();//muestra el form ya cargado
                
            }//fin bloque de codigo
        }//fin bloque codigo

        private void BtnCancelar_Click(object sender, EventArgs e)//cierra la ventana si se da click en el boton cancelar
        {//inicio bloque codigo
            this.Close();//ciera el form1
        }//cierre bloque codigo

        private void TextBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)//controla el tecleo que puedes ingresar, los empleados y alumnos solo numeros y los invitados letras
        {//inicio bloque codigo
            if (OpcInvitado.Checked == false)//evalua si el checkbox esta desactivado
            {//inicio bloque codigo

                if (e.KeyChar >= 0 && e.KeyChar <= 47 && e.KeyChar != 8 || e.KeyChar >= 58 && e.KeyChar <= 255)//condicion que te permite dejar solo numeros y retroceso
                {//inicio bloque codigo
                    e.Handled = true;//se indica que se controlo el evento
                    return;//devuelve la instruccion a donde se llamo
                }//cierre bloque codigo
            }//cierre bloque codigo
            else
            {//apertura bloque codigo
                //condicion que te permite dejar solo letras, espacios y retroceso
                if (e.KeyChar >= 0 && e.KeyChar <= 64 && e.KeyChar != 8 && e.KeyChar != 32 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
                {//apertura bloque codigo
                    e.Handled = true;//se indica que se controlo el evento
                    return;//devuelve la instruccion a donde se llamo
                }//cierre bloque codigo
            }//cierre bloque codigo  

        }//cierre bloque codigo
    }//cierre bloque codigo
}//cierre bloque codigo
