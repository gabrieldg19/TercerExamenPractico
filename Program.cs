using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace TercerExamenPractico
{
    class Program
    {
        static void Main()
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=MiBaseDeDatos;Integrated Security=True;Trust Server Certificate=True";

            // Verificar conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al conectar: {ex.Message}");
                    return;
                }
            }

            // Usar DatabaseHelper para ejecutar una consulta
            DatabaseHelper dbHelper = new DatabaseHelper(connectionString);

            try
            {
                Console.WriteLine("Obteniendo lista de empleados...");
                string query = "SELECT EmpleadoID, Nombre, Apellido, Edad, Salario FROM Empleados";
                DataTable empleados = dbHelper.ExecuteQuery(query);

                foreach (DataRow row in empleados.Rows)
                {
                 Console.WriteLine($"ID: {row["EmpleadoID"]}, Nombre: {row["Nombre"]} {row["Apellido"]}, Edad: {row["Edad"]}, Salario: {row["Salario"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
            }
        }
    }
}