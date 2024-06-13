using UnityEngine;

public class scri : MonoBehaviour
{
    // Référence à la lumière
    public Light pointLight;

    // Touche pour allumer/éteindre la lumière
    public KeyCode toggleKey = KeyCode.F;

    void Start()
    {
        // Récupère la lumière attachée à cet objet
        pointLight = GetComponent<Light>();

        // Vérifie si une lumière est attachée à cet objet
        if (pointLight == null)
        {
            Debug.LogError("Aucune lumière trouvée sur cet objet.");
            return;
        }

        // Vérifie si la lumière est bien une lumière de type Point
        if (pointLight.type != LightType.Point)
        {
            Debug.LogWarning("Ce script doit être attaché à un objet avec une lumière de type Point.");
        }
    }

    void Update()
    {
        // Vérifie si la touche toggleKey est pressée
        if (Input.GetKeyDown(toggleKey))
        {
            // Inverse l'état d'activation de la lumière
            pointLight.enabled = !pointLight.enabled;
        }
    }
}
