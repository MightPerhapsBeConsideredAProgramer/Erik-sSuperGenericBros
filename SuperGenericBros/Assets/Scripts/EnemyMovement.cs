using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform StartPos;
    public float Distance;
    public float Speed;

    public SpriteRenderer EnemySprite;

    void FixedUpdate()
    {
        float offset = Mathf.PingPong(Time.time * Speed, Distance);

        transform.position = new Vector3(StartPos.position.x + offset, StartPos.position.y);

        if (transform.position.x >= StartPos.position.x + Distance -0.1f)
            EnemySprite.flipX = false;
        if (transform.position.x <= StartPos.position.x + 0.1f)
            EnemySprite.flipX = true;
    }
}
