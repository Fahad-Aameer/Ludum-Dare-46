using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IDamageable
{
    

    public float moveSpeed;
    public Rigidbody2D rb;
    private float moveInput;
    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;

    private bool canDoubleJump;
    private bool isGroundedFrame = false;

    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    public bool dashing;

    public GameObject stompBox;

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
        Movement();

        if (rb.position.y < -15)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Movement()
    {
        moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);



        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);

        if (isGrounded == true && isGroundedFrame == false)
            isGroundedFrame = isGrounded;

        if (isGrounded)
        {
            canDoubleJump = true;

        }

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                


            }
            else
            {
                if (canDoubleJump)

                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                   

                    canDoubleJump = false;
                }

            }
        }

        if(direction == 0)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                if(moveInput < 0)
                {
                    direction = 1;

                }
                else if (moveInput > 0)
                {
                    direction = 2;
                }
            }
        }

        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
                dashing = false;
            }
            else
            {
                dashTime -= Time.deltaTime;

                if (direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                    dashing = true;
                    


                }
                else if(direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                    dashing = true;
                    

                }

               

            }
        }

        if (dashing == true)
        {
            stompBox.SetActive(true);

            AudioManager.instance.PlaySFX(0);
        }

        else if (dashing == false)
        {
            stompBox.SetActive(false);
            

        }

    }

    public void Damage()
    {
        Health--;

        if(Health <= 0)
        {
            CatMovement cM = GameObject.Find("Cat").GetComponent<CatMovement>();
            cM.moveSpeed = 0;
            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

   
}
