using UnityEngine;
using TMPro;

public class TecladoController : MonoBehaviour
{
    [SerializeField] public TMP_Text inputFieldText; // El TextMeshPro donde se escribirá el texto
    [SerializeField] private string currentText = ""; // Texto actual del input

    // Función para agregar una tecla al texto actual
    public void AgregarTecla(string tecla)
    {
        currentText += tecla; // Agregar la tecla al texto actual
        ActualizarTexto(); // Actualizar el texto en el TextMeshPro
    }

    // Función para borrar la última tecla
    public void BorrarTecla()
    {
        if (currentText.Length > 0)
        {
            currentText = currentText.Substring(0, currentText.Length - 1); // Eliminar el último carácter
            ActualizarTexto(); // Actualizar el texto en el TextMeshPro
        }
    }

    // Función para mandar el texto
    public void Enter()
    {
        Debug.Log($"Texto enviado: {currentText}"); // Log del texto enviado
        LimpiarTexto(); // limpia el campo de texto después de enviarlo
    }

    // Función para limpiar el texto
    public void LimpiarTexto()
    {
        currentText = "";
        ActualizarTexto();
    }

    // Función auxiliar para actualizar el texto en el TextMeshPro
    private void ActualizarTexto()
    {
        inputFieldText.text = currentText; // Reflejar el texto actual en el TextMeshPro
    }
}
