using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform target;
    public float speed = 0.08f;
    public Vector3 desiredPosition, position;

    void FixedUpdate()
    {
        desiredPosition = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, speed);
    }
}
