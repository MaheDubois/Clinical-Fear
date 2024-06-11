using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMessageDIstance : MonoBehaviour
{
    public Transform targetObject; // L'objet cible
    public float triggerDistance = 5f; // Distance pour afficher le message
    public string message = "E pour récuperer!"; // Message à afficher
    private bool showMessage = false; // État d'affichage du message
    

    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetObject.position); // Calcul de la distance
        if (distance <= triggerDistance)
        {
            showMessage = true;
        }
        else
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
