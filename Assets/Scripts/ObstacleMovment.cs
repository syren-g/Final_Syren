using UnityEngine;

public class HW7EnemyMove : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0, -1, 0);
    public Vector3 HorizontalMovement = new Vector3(1, 0, 0);
    public float speed = 3;
    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;
       

    }
}


