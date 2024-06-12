using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DonnerNoteFontaine : MonoBehaviour
{
    [SerializeField] Text m_score;
    public Transform targetObject;
    public float triggerDistance = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialisation si nécessaire
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, targetObject.position);
        if (m_score.text == "8" && distanceToTarget <= triggerDistance)
        {
            UpdateScoreUI();
        }
    }

    void UpdateScoreUI()
    {
        m_score.text = "FIN JEU";
    }
}
