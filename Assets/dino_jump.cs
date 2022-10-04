using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dino_jump : MonoBehaviour
{
    
public Rigidbody2D rb;
private BoxCollider2D coll;

[SerializeField] LayerMask jumpableground;

private void Start() {
    coll = GetComponent<BoxCollider2D>();
}

public float jumpAmount = 10;
[SerializeField] AudioClip Jump_effect;
void Update()
{
    rb = GetComponent<Rigidbody2D>();
    
    if (Input.GetKeyDown(KeyCode.Space) && IsGrounded() && FindObjectOfType<collision>().hascrashed == false)
    {
        rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        GetComponent<AudioSource>().PlayOneShot(Jump_effect);
    }
}

private bool IsGrounded(){
    return Physics2D.BoxCast(coll.bounds.center,coll.bounds.size,0f,Vector2.down,.1f, jumpableground);
}
}
