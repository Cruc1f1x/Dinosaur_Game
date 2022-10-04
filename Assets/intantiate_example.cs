using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intantiate_example : MonoBehaviour
{
    [SerializeField] GameObject object_to_spawn;
    private void Start() {
        StartCoroutine(spawn());
    }

    IEnumerator spawn(){
        while(true){
            
        yield return new WaitForSeconds(Random.Range(0.5f,1.5f));
        Instantiate(object_to_spawn,new Vector3(8.99f,-1.88f,0), Quaternion.identity);
        }
    }
}
