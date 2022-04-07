using System;//espacio de nombres raiz. contiene los tipos basico de freamwork .net
using System.Windows.Forms;//contiene todos los tipos que permite la creacion de aplicaciones de windows, ya sean formularios...

namespace TAPU1_A4_PIDETEC_//Espacio de nombres utilizado para trabajar varios archivos como uno solo
{
    public partial class MenuComida : Form //clase
    {//apertura bloque codigo

        //crea un objeto de la clase mostrarplatillos  de manera global para poder acceder al mismo objeto en diferentes eventos
        MostrarPlatillos mostrarPlatillos = new MostrarPlatillos();
        ImagenesPlatillos ImagenesPlatillos = new ImagenesPlatillos();//se crea un objeto de la clase ImagenesPlatillos para poder cargar el form y las imagenes del menu
        double CuentaTotal;//declaracion variable 
        public MenuComida()//constructor que inicializa el componente
        {//apertura bloque codigo
            InitializeComponent();//metodo para la inicializacion
           
        }//cierre bloque codigo

        public MenuComida(String NombreUsuario, string Clasificacion)//Constructor para cargar el form con un nombre y una clasificacion(Alumnos,Empleados,Invitados)
        {//aperura bloque codigo
            InitializeComponent();//metodo para la inicializacion
            LblNombreUsuario.Text = "Usuario: " + Clasificacion + NombreUsuario;//Enlaza todos los elementos y los conviete en solo 1 texto 

        }//cierre bloque codigo

        private void BtnGorditas_Click(object sender, EventArgs e)//Permite seleccionr las gorditas que va a comprar el usuario
        {//apertura de bloque codigo
            if (BarraProgresoGorditas.Value < 100)//condicion para no ecceder el 100% de la barra, esto para no generar excepciones
            {//apertura bloque codigo
                BarraProgresoGorditas.Value = BarraProgresoGorditas.Value + 10;//guarda el progreso de la barra gorditas e incrementa

                int NumPlatillos = BarraProgresoGorditas.Value / 10;//Obtiene el numero platillos que elejiste en gorditas

                BtnGorditas.Text = "Gorditas " + NumPlatillos;//Modifica el texto del boton gorditas para mostrar cuantas gorditas se estan seleccionando
                //Calcula el costo total de las gorditas adquiridas mas otros elementos
                CuentaTotal = CuentaTotal + 10;//costo de 10c/u
                LblCostoTotal.Text = "Cuenta: $" + CuentaTotal;//Muestra el costo total actualmente en el form
            }//cierre bloque codigo
        }

        private void BtnHamburguesas_Click(object sender, EventArgs e)//permite seleccionar las hamburguesas que va a comprar el usuario
        {//apertura bloque codigo
            if (BarraProgresoHamburguesa.Value < 100)//condicion para no ecceder el 100% de la barra, esto para no generar excepciones
            {//apertura bloque codigo
                BarraProgresoHamburguesa.Value = BarraProgresoHamburguesa.Value + 10;//guarda el progreso de la barra Hamburguesas e incrementa
                int NumPlatillos = BarraProgresoHamburguesa.Value / 10;//Obtiene el numero de platillos que elejite en hamburguesas
                BtnHamburguesas.Text = "Hamburguesas " + NumPlatillos;//modifica el texto del boton hamburguesas para mostrar cuantas hamburguesas se estan seleccionando
                //Calcula el costo total de las hamburguesas adquiridas mas otros elementos
                CuentaTotal = CuentaTotal + 30;//costo de 30c/u
                LblCostoTotal.Text = "Cuenta: $" + CuentaTotal;//Muestra el costo total actualmente en el form
            }//cierre bloque codigo
        }//cierre bloque codigo

        private void BtnEnsalada_Click(object sender, EventArgs e)//Permite seleleccionar los platillos de ensalada que va a comprar el usuario
        {//apertura del bloque codigo
            if (BarraProgresoEnsalada.Value < 100)//condiccion para no ecceder el 100% de la barra, esto para no generar excepciones
            {//apertura bloque codigo
                BarraProgresoEnsalada.Value = BarraProgresoEnsalada.Value + 10;//guarda el progreso de la barra ensalada e incrementa
                int NumPlatillos = BarraProgresoEnsalada.Value / 10;//obtiene el numero de platillos que seleccionaste en ensalada
                BtnEnsalada.Text = "Ensalada " + NumPlatillos;//actualiza el numero de platillos seleccionados mostrando el resultado en pantalla 
                //Calcula el costo total de los platillos de ensalada adquiridos mas otros elementos
                CuentaTotal = CuentaTotal + 45;//costo 45c/u
                LblCostoTotal.Text = "Cuenta: $" + CuentaTotal;//muestra el costo total actualmente en el form
            }//cierre bloque codigo
        }//cierre bloque codigo

        private void BtnTacosBarbacoa_Click(object sender, EventArgs e)//permite seleccionar los platillos de tacos de barbacoa que va a comprar el usuario
        {//apertura del bloque codigo
            if (BarraProgresoTacosBarbacoa.Value < 100)//condicion para no exceder el 100% de la barra, esto para no generar excepciones
            {//apertura del bloque codigo
                BarraProgresoTacosBarbacoa.Value = BarraProgresoTacosBarbacoa.Value + 10;//guarda el progeso de la barra tacos de barbacoa e incrementa
                int NumPlatillos = BarraProgresoTacosBarbacoa.Value / 10;//Obtiene el numero de platillo que seleccionaste en tacos de barbacoa
                BtnTacosBarbacoa.Text = "Tacos de barbacoa  " + NumPlatillos;//actualiza el numero de platillos seleccionados mostrando el resultado en pantalla
                //calcula el costo total de los tacos de barbacoa adquiridos mas otros elementos
                CuentaTotal = CuentaTotal + 37;//costo 37c/u
                LblCostoTotal.Text = "Cuenta: $" + CuentaTotal;//muestra el costo total actualmente en el form 
            }//cierre de bloque de datos
        }//cierre bloque datos

        private void LblCerrarSesion_Click(object sender, EventArgs e)//permite salir de la sesion
        {//apertura bloque codigo

            this.DialogResult = DialogResult.OK;
            this.Close();//cierra la ventana
        }//cierre bloque codigo

        

        private void BtnGorditas_MouseEnter(object sender, EventArgs e)//permite mostrar la imagen de gorditas mediante un nuevo form
        {//apertura bloque codigo

            //se coloca el fondo a el form mediante una imagen que existe en el proyecto
            mostrarPlatillos.BackgroundImage = TAPU1_A4_PIDETEC_.Properties.Resources.Gorditas; 
            mostrarPlatillos.Show();//muestra el form con el fondo ya establecido
        }//cierre bloque codigo

        private void BtnGorditas_MouseLeave(object sender, EventArgs e)//no muetra la imagen si salgo del botongordits
        {//apetura bloque codigp
            mostrarPlatillos.Hide();//oculta la imagen
        }//cierre bloque codigo
        
        private void BtnHamburguesas_MouseEnter(object sender, EventArgs e)//permite mostrar la imagen de Hamburguesas mediante un nuevo form
        {//apertura bloque codigo
            //se coloca el fondo a el form mediante una imagen que existe en el proyecto
            mostrarPlatillos.BackgroundImage = TAPU1_A4_PIDETEC_.Properties.Resources.Hamburguesa;
            mostrarPlatillos.Show();//muestra el form con el fondo ya establecido
        }//cierre bloque codigo

        private void BtnHamburguesas_MouseLeave(object sender, EventArgs e)//No muestra la imagen si salgo del boton hamburguesa
        {//apertura bloque codigo
            mostrarPlatillos.Hide();//oculta la imagen
        }//cierre bloque codigo

        private void BtnEnsalada_MouseEnter(object sender, EventArgs e)//permite mostrar la imagen de ensalada mediante un nuevo form
        {//apertura bloque codigo
            //se coloca el fondo a el form mediante una imagen que existe en el proyecto
            mostrarPlatillos.BackgroundImage = TAPU1_A4_PIDETEC_.Properties.Resources.Ensalada;
            mostrarPlatillos.Show();//muestra el form con el fondo ya establecido
        }

        private void BtnEnsalada_MouseLeave(object sender, EventArgs e)//No muestra la imagen si salgo del boton Ensalada
        {
            mostrarPlatillos.Hide();//oculta la imagen
        }

        private void BtnTacosBarbacoa_MouseEnter(object sender, EventArgs e)//permite mostrar la imagen de tacos de barbacoa mediante un nuevo form
        {//apertura bloque codigo
            //se coloca el fondo a el form mediante una imagen que existe en el proyecto
            mostrarPlatillos.BackgroundImage = TAPU1_A4_PIDETEC_.Properties.Resources.TacosBarbacoa;
            mostrarPlatillos.Show();//muestra el form con el fondo ya establecido
        }//cierre bloque codigo

        private void BtnTacosBarbacoa_MouseLeave(object sender, EventArgs e)//no muestra la imagen si salgo del boton tacos de barbacoa
        {//apertura bloque codigo
            mostrarPlatillos.Hide();//oculta la imagen
        }//cierre bloque codigo
    }
}
