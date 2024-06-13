using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class cafeine : MonoBehaviour
{
    public string message = "E pour boire!"; // Message à afficher
    public float displayDistance = 5f; // Distance pour afficher le message
    public Transform player; // Référence au joueur
    private TMP_Text messageText; // Référence au composant TMP_Text

    void Start()
    {
        messageText = GetComponentInChildren<TMP_Text>(); // Récupère le composant TMP_Text dans les enfants
        messageText.enabled = false; // Désactive le texte par défaut
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position); // Calcul de la distance
        if (distance <= displayDistance)
        {
            messageText.text = message; // Définit le message
            messageText.enabled = true; // Affiche le texte
        }
        else
        {
            messageText.enabled = false; // Cache le texte
        }
    }
}
