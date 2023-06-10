using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Parcial_Programacion
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Alumno> alumnos;

        public ObservableCollection<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            Alumnos = new ObservableCollection<Alumno>();
            dataGrid.DataContext = this;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            string carnet = txtCarnet.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string grado = txtGrado.Text;

            // Crear un objeto Alumno y agregarlo a la colección
            Alumno alumno = new Alumno(carnet, nombre, telefono, grado);
            Alumnos.Add(alumno);

            // Guardar en la base de datos (código de conexión a la base de datos aquí)
            // ...

            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem is Alumno alumno)
            {
                // Eliminar de la colección
                Alumnos.Remove(alumno);

                // Eliminar de la base de datos (código de conexión a la base de datos aquí)
                // ...
            }
        }

        private void LimpiarCampos()
        {
            txtCarnet.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtGrado.Text = string.Empty;
        }
    }
}

