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
            transform.position = new Vector2(Time.deltaTime * -HorizontalSpeed, transform.position.y);
        if (GoLeft)
            transform.position = new Vector2(Time.deltaTime * HorizontalSpeed, transform.position.y);
        if (!GoUpward)
            transform.position = new Vector2(transform.position.x, Time.deltaTime * -VerticalSpeed);
        if (GoUpward)
            transform.position = new Vector2(transform.position.x, Time.deltaTime * VerticalSpeed);
    }

    void Update()
    {
        bool HitUp = Physics2D.OverlapCircle(UpCheck.position, 0.1f, GroundLayer);
        bool Hitdown = Physics2D.OverlapCircle(DownCheck.position, 0.1f, GroundLayer);
        bool Hitleft = Physics2D.OverlapCircle(LeftCheck.position, 0.1f, GroundLayer);
        bool Hitright = Physics2D.OverlapCircle(RightCheck.position, 0.1f, GroundLayer);
    }
}
