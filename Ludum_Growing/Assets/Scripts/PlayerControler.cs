using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

public float speed = 0.0f;
public float jumpHeight;

public Transform groundCheck;
public float groundCheckRadius;
public LayerMask whatIsGround;

public Animator Animator;
public Rigidbody2D rb2d;
public bool isGrounded;


	// Use this for initialization
	void Start ()
	{
		Animator = GetComponent<Animator>();
		rb2d = gameObject.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() 
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

		if(!isGrounded)
		{
			Animator.SetBool("aniGrounded", false);

		}
		else
		{
			Animator.SetBool("aniGrounded", true);
		}
	}


	// Update is called once per frame
	void Update () {
		Movement();
	

	}

	void Movement()
	{

		//move right
		if(Input.GetKey (KeyCode.X))
		{

			transform.Translate(Vector2.right * 4.0f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
			Animator.SetFloat("speed", Mathf.Abs(1));

		
		}
		else
		{
			//walk cycle will not end unless I set speed to 0
			Animator.SetFloat("speed", Mathf.Abs(0));	

		}

		//move left
		if(Input.GetKey (KeyCode.Z))
		{
			transform.Translate(Vector2.right * 4.0f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
			Animator.SetFloat("speed", Mathf.Abs(1));	
		}

		else
		{
			///????? If I set speed to 0 like I did move right
			///it'll break the right walking animation ??????
		}

		//jump up
		if (Input.GetKeyDown (KeyCode.Space) && isGrounded)
		{
			rb2d.velocity = new Vector2(0, jumpHeight);

		}


		



	}
}
