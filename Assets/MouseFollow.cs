using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public bool canMove = false;
    public float smoothSpeed = 10f;

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        if (!canMove) return;

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        transform.Rotate(0, 200 * Time.deltaTime, 0);


        Vector3 targetPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos.y = 0.5f+ Mathf.Sin(Time.time * 5f) * 0.05f; ;

        // Smooth movement
        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPos,
            ref velocity,
            0.1f
        );
    }
}