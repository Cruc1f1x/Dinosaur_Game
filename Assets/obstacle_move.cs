using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_move : MonoBehaviour
{
    
    public float speed;

    private void Start() {
        
    }

   
    void Update()
    {
        if(FindObjectOfType<collision>().hascrashed == false){

        transform.position = transform.position + Vector3.left*Time.deltaTime*speed; 
        }
    }
}
                   