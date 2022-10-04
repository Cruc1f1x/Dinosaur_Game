using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] GameObject go;
    // private Transform t_1;
     void start() {
        // t_1 = GetComponent<Transform>();
        Instantiate(go,Vector3.zero,Quaternion.identity);
    }
}
