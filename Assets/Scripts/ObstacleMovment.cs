using UnityEngine;

public class HW7EnemyMove : MonoBehaviour
{
    public float verticalSpeed = 10f;
    public float horizontalSpeed = 2f;
    public float horizontalAmplitude = 1.5f;

    public float xMin = -7f;
    public float xMax = 6f;

    public float startX;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
        startX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {



        float x = startX + Mathf.Sin(Time.time * horizontalSpeed) * horizontalAmplitude;
        x = Mathf.Clamp(x, xMin, xMax);
        float y = rb.position.y - verticalSpeed * Time.fixedDeltaTime;
        rb.MovePosition(new Vector2(x, y));
    }
}


