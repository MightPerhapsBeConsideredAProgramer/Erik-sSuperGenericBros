using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 6f;
    public float JumpSpeed = 7f;

    public Rigidbody2D RB;
    public SpriteRenderer PlayerSprite;
    private float HorizontalMovement;

    public Transform GroundCheck;
    public LayerMask GroundLayer;

    void Update()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal");
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move() 
    {
        RB.linearVelocity = new Vector2(MoveSpeed * HorizontalMovement * Time.deltaTime, RB.linearVelocity.y);
        if (HorizontalMovement  > 0 ) 
            PlayerSprite.flipX = false;
        if (HorizontalMovement  < 0 ) 
            PlayerSprite.flipX = true;
    }
    
    public void Jump()
    {
        if (!Input.GetKeyDown(KeyCode.Space))
            return;

        bool IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, 0.1f, GroundLayer);

        if (IsGrounded )
            RB.linearVelocity = new Vector2(RB.linearVelocity.x, JumpSpeed);


    }


}
