using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonScript : MonoBehaviour
{
    private int score;
    [SerializeField] Text m_score;

    public List<Transform> targetObjects; // Liste des objets cibles
    public List<GameObject> objectsToDestroy; // Liste des objets à détruire

    public float triggerDistance = 5f; // Distance pour déclencher la destruction

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForDestruction();
    }

    void CheckForDestruction()
    {
        for (int i = 0; i < targetObjects.Count; i++)
        {
            float distanceToTarget = Vector3.Distance(transform.position, targetObjects[i].position);
            if (distanceToTarget <= triggerDistance && Input.GetKeyDown(KeyCode.E))
            {
                score++;
                Destroy(objectsToDestroy[i]);
                targetObjects.RemoveAt(i);
                objectsToDestroy.RemoveAt(i);
                UpdateScoreUI();
                break; // Sortir de la boucle pour éviter les problèmes d'index après la suppression
            }
        }
    }

    void UpdateScoreUI()
    {
        m_score.text = "nombre de notes : " + score.ToString();
    }
}
