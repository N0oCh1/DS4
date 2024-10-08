using System.Collections.Generic;
using System.Windows.Forms;
using System;

public static class OperacionesNumeros  
{
    
    private static List<int> listaNumeros = new List<int>();

    
    public static void AgregarNumero(string input, DataGridView dgv)
    {
        if (int.TryParse(input, out int numero))
        {
            listaNumeros.Add(numero);  
            ActualizarDataGridView(dgv);
        }
        else
        {
            MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

   
    public static void EliminarNumero(string input, DataGridView dgv)
    {
        if (int.TryParse(input, out int numeroAEliminar))
        {
            listaNumeros.RemoveAll(n => n == numeroAEliminar); 
            ActualizarDataGridView(dgv); 
        }
        else
        {
            MessageBox.Show("Ingrese un número válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    
    public static void ActualizarDataGridView(DataGridView dgv)
    {
        dgv.Columns.Clear(); 

        for (int i = 0; i < listaNumeros.Count; i++)
        {
            dgv.Columns.Add($"Columna{i}", $"Número {i + 1}");

            
            if (dgv.Rows.Count == 0)
            {
                dgv.Rows.Add();
            }

            
            dgv.Rows[0].Cells[i].Value = listaNumeros[i];
        }
    }

    
    public static List<int> ObtenerLista()
    {
        return listaNumeros;
    }
}