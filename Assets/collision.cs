using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    [SerializeField] float delay =0.5f;
    [SerializeField] AudioClip Crash_effect;

    public bool hascrashed = false;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "enemy" && !hascrashed ){
        crash();
        Debug.Log("collided");
        Invoke("restart",delay);
        GetComponent<Rigidbody2D>().simulated = false;
        GetComponent<AudioSource>().PlayOneShot(Crash_effect);
        
        }
    }

    void restart(){
        
        SceneManager.LoadScene(0);
    }

    public void crash(){
        hascrashed = true;
    }
}
