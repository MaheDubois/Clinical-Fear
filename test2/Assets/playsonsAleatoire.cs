using UnityEngine;

public class playsonsAleatoire : MonoBehaviour
{
    // Probabilité de jouer le son (0.05 pour 5%)
    [Range(0f, 1f)]
    public float probability = 0.05f;

    // Référence à l'AudioSource
    public AudioSource audioSource;

    void Start()
    {
        // Récupère l'AudioSource attachée à cet objet
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Détecte un clic de souris
        if (Input.GetMouseButtonDown(0))
        {
            TryPlaySound();
        }
    }

    void TryPlaySound()
    {
        // Génère un nombre aléatoire entre 0 et 1
        float randomValue = Random.Range(0f, 1f);

        // Vérifie si ce nombre est inférieur à la probabilité définie
        if (randomValue < probability)
        {
            // Joue le son
            audioSource.Play();
        }
    }
}
