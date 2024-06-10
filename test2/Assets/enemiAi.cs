using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiAi : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;
    

   void Start()
   {
        if(player != null)
        {
           player = GameObject.FindGameObjectWithTag("Player").transform;
        }
   }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            transform.position += direction * speed * Time.deltaTime;

            transform.LookAt(player);
        }
    }
}
