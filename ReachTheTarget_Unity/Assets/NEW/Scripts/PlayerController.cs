using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
    }
    void FixedUpdate()
    {
        transform.position +=
        (Vector3)(movement * speed * Time.fixedDeltaTime);
    }
}