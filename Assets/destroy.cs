using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    [SerializeField] GameObject go;

    private void OnTriggerEnter2D(Collider2D other){
            Destroy(go,0.1f);
        }

        
}
