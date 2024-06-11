using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonScript : MonoBehaviour
{
    private int score;
    [SerializeField] Text m_score;
    public Transform targetObject; // L'objet cible
    public GameObject ObjectToDestroy1;
    public GameObject ObjectToDestroy2;
    public GameObject ObjectToDestroy3;
    public GameObject ObjectToDestroy4;
    public GameObject ObjectToDestroy5;
    public GameObject ObjectToDestroy6;
    public GameObject ObjectToDestroy7;
    public GameObject ObjectToDestroy8;
    public float triggerDistance = 5f; // Distance pour afficher le message

    // Start is called before the first frame update
    void Start()
    {
       
        score = 0;
        m_score.text = "nombre de notes : "+ score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetObject.position); // Calcul de la distance

        if (distance <= triggerDistance && Input.GetKeyDown(KeyCode.E))
        {
            score ++;
            if (ObjectToDestroy1)
                Destroy(ObjectToDestroy1);
            if (ObjectToDestroy2)
                Destroy(ObjectToDestroy2);
        }
        m_score.text = "nombre de notes : "+ score.ToString();
    }
}
