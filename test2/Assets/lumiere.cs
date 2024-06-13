using UnityEngine;

public class lumiere : MonoBehaviour
{
    // Référence à l'objet Light
    public Light lightSource;

    // La touche pour basculer l'état de la lumière
    public KeyCode toggleKey = KeyCode.F;

    // Initialisation
    void Start()
    {
        // Vérifie si la référence de la lumière est définie
        if (lightSource == null)
        {
            Debug.LogError("La source de lumière n'est pas assignée.");
        }
    }

    // Mise à jour appelée une fois par frame
    void Update()
    {
        // Vérifie si la touche définie est pressée
        if (Input.GetKeyDown(toggleKey))
        {
            // Bascule l'état de la lumière
            lightSource.enabled = !lightSource.enabled;
        }
    }
}
