using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float jumpHeight;
    public float jumpHeightSave;
    public float jumpHeight2;

    public float movex;
    public float movey;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    public Vector2 movePositionVector;

    public Transform trampCheck;
    public float trampCheckRadius;
    public LayerMask whatIsTramp;
    private bool tramped;

    // Use this for initialization
    void Start () {

    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        tramped = Physics2D.OverlapCircle(trampCheck.position, trampCheckRadius, whatIsTramp);
		Movement ();
    }

	void Update(){
        
	}


		
    void Movement()
    {
        if (tramped)
        {
            jumpHeight = jumpHeight2;
        }
        else
        {
            jumpHeight = jumpHeightSave;
        }



        movex = Input.GetAxisRaw("Horizontal");
        movey = Input.GetAxisRaw("Vertical");

        if (movex != 0)
       {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(movex * speed, GetComponent<Rigidbody2D>().velocity.y);

            if (movex > 0)
            {
                transform.eulerAngles = new Vector2(0, 0);
            }
            else if (movex < 0)
            {
                transform.eulerAngles = new Vector2(0, 180);
            }
       }

        if (movey > 0 && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
    }
    
       
    
}
