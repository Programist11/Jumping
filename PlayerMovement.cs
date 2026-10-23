// using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public int amountOfClick = 0;
    // public int jumpCounter = 0;
    // public float delt;
    public int moveDirect = 1;
    public float jumpPower = 0f;
    public float speed = 0f;
    private bool isGround;
    private bool jumpF = true;
    private string currentAnimation;
    // public float rayDistance = 0f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        // StartCoroutine(JumpIEnumerator());
        // Time.timeScale = 0.1f;
    }
    private void Update()
    {
        // RaycastHit2D hit = Physics2D.Raycast(rb.position, Vector2.down, rayDistance, LayerMask.GetMask("Ground"));
        // if (hit.collider != null)
        // {
        //     isGround = true;
        // }
        // else
        // {
        //     isGround = false;
        // }
        if (Input.GetMouseButtonDown(0) && isGround)
        {
            Jump();
        }
        if (rb.velocity.y > 0)
            AnimationStart("Slime_jump");
        else if (rb.velocity.y < -10)
            AnimationStart("Slime_fall");
        else if(rb.velocity.y == 0)
            AnimationStart("Slime_breath");
    }
    private int Jump()
    {
        if (jumpF)
        {
            jumpF = false;
            return 0;
        }
        Debug.Log("Jump");
        amountOfClick++;
        rb.AddForce(new Vector2(rb.velocity.x, jumpPower), ForceMode2D.Impulse);
        return 0;
    }
    private void AnimationStart(string animation)
    {
        if (animation == currentAnimation)
            return;
        currentAnimation = animation;
        animator.Play(animation);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            isGround = false;
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(speed * moveDirect, 0, 0));

        if (moveDirect == 1)
            spriteRenderer.flipX = true;
        else
            spriteRenderer.flipX = false;

        
    }
    // IEnumerator JumpIEnumerator()
    // {
    //     while (true)
    //     {
    //         Jump();
    //         yield return new WaitForSeconds(delt);
    //     }
    // }
}
