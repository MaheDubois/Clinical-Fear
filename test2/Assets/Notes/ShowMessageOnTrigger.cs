using UnityEngine;

public class ShowMessageOnTrigger : MonoBehaviour
{
    public string message = ""; // Message à afficher
    private bool showMessage = false; // État d'affichage du message

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Vérifie si le joueur entre dans le déclencheur
        {
            showMessage = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Vérifie si le joueur quitte le déclencheur
        {
            showMessage = false;
        }
    }

    void OnGUI()
    {
        if (showMessage)
        {
            GUI.Label(new Rect(10, 10, 200, 20), message); // Affiche le message à l'écran
        }
    }
}
