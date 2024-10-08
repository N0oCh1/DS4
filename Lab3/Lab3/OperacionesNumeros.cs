using System.Collections.Generic;
using System.Windows.Forms;
using System;

public static class OperacionesNumeros
{
    private static List<int> listaNumeros = new List<int>();

    public static void agregarNumero(string input, DataGridView dgv)
    {
        if (int.TryParse(input, out int numero))
        {
            listaNumeros.Add(numero);
            actualizarDataGridView(dgv);
        }
        else
        {
            MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void eliminarNumero(string input, DataGridView dgv)
    {
        if (int.TryParse(input, out int numeroAEliminar))
        {
            listaNumeros.RemoveAll(n => n == numeroAEliminar);
            actualizarDataGridView(dgv);
        }
        else
        {
            MessageBox.Show("Ingrese un número válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void actualizarDataGridView(DataGridView dgv)
    {
        dgv.Columns.Clear();

        for (int i = 0; i < listaNumeros.Count; i++)
        {
            dgv.Columns.Add($"Columna{i}", $"Número {i + 1}");

            // Asegurarse de que haya al menos una fila por si acaso aunque tecnicamente no deberia ocurrir
            if (dgv.Rows.Count == 0)
            {
                dgv.Rows.Add();
            }          
            dgv.Rows[0].Cells[i].Value = listaNumeros[i];
        }
    }

    public static List<int> obtenerLista()
    {
        return listaNumeros;
    }
}
