using UnityEngine;

public class BouncyEnemyMovement : MonoBehaviour
{
    public float HorizontalSpeed;
    public float VerticalSpeed;

    public Transform UpCheck;
    public Transform DownCheck;
    public Transform LeftCheck;
    public Transform RightCheck;
    public LayerMask GroundLayer;

    public Rigidbody2D RB;

    public bool GoLeft;
    public bool GoUpward;

    private void FixedUpdate()
    {
        if (!GoLeft)
            RB.linearVelocity = new Vector2(Time.deltaTime * -HorizontalSpeed, RB.linearVelocity.y);
        if (GoLeft)
            RB.linearVelocity = new Vector2(Time.deltaTime * HorizontalSpeed, RB.linearVelocity.y);
        if (!GoUpward)
            RB.linearVelocity = new Vector2(RB.linearVelocity.x, Time.deltaTime * -VerticalSpeed);
        if (GoUpward)
            RB.linearVelocity = new Vector2(RB.linearVelocity.x, Time.deltaTime * VerticalSpeed);
    }

    void Update()
    {
        bool HitUp = Physics2D.OverlapCircle(UpCheck.position, 0.1f, GroundLayer);
        bool HitDown = Physics2D.OverlapCircle(DownCheck.position, 0.1f, GroundLayer);
        bool HitLeft = Physics2D.OverlapCircle(LeftCheck.position, 0.1f, GroundLayer);
        bool HitRight = Physics2D.OverlapCircle(RightCheck.position, 0.1f, GroundLayer);

        if(HitUp)
            GoUpward = false;
        if(HitDown)
            GoUpward = true;
        if(HitRight)
            GoLeft = false;
        if(HitLeft)
            GoLeft = true;
    }
}
