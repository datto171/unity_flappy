using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingComponent : MonoBehaviour
{
    [SerializeField]
    float fallSpeed;
    [SerializeField]
    float jumpForce;
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    float maxFallSpeed;

    Vector2 position;
    float velocityY;
    // Start is called before the first frame update
    void Start()
    {
        position = (Vector2)transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       Fall();
       if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
         position.y = Mathf.Min(position.y, 4.5f);
         Death();
    }

    void FixedUpdate(){
        rb.position = position;
    }

    void Jump(){
        velocityY = -jumpForce; 
    }

    void Fall(){
        velocityY += fallSpeed * Time.deltaTime;
        velocityY = Mathf.Min(maxFallSpeed, velocityY);
        position.y -= velocityY * Time.deltaTime;       
    }

    void Death(){
        if (position.y <= -4.5f && !GameManager.IsOver()) {
            position.y = -4.5f;
            GameManager.GameOver();
        }
    }
}
