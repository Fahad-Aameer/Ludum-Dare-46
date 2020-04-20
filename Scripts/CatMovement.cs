using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour, IDamageable
{


    public float moveSpeed;
    public Rigidbody2D rb;
    public GameObject effect;
    

    public int Health { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Health = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if(rb.position.y < -15)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void Damage()
    {
        Health--;

        if (Health <= 0)
        {
            

            Destroy(gameObject);
            FindObjectOfType<GameManager>().EndGame();
            Instantiate(effect, transform.position, Quaternion.identity);
            PlayerMovement pM = GameObject.Find("Player").GetComponent<PlayerMovement>();
            pM.moveSpeed = 0;
            pM.jumpForce = 0;


        }
    }
}
