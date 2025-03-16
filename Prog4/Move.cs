using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 15f;
    public float rotationSpeed = 100f;
    public float jumpHeight = 3f;
    public float jumpSpeed = 5f;
    public float detectionDistance = 1f; // Distance for obstacle detection

    private bool isJumping = false;
    private float originalY;
    private float jumpProgress = 0f;

    void Start()
    {
        originalY = transform.position.y;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Move direction relative to where the camera is facing
        Vector3 moveDirection = transform.right * moveX + transform.forward * moveY;
        moveDirection.y = 0; // Prevent vertical movement
        moveDirection.Normalize();

        Vector3 newPosition = transform.position + moveDirection * moveSpeed * Time.deltaTime;

        // Raycast to check if movement is possible
        if (!Physics.Raycast(transform.position, moveDirection, detectionDistance))
        {
            transform.position = newPosition;
        }

        // Jumping (Move Up & Come Down)
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            jumpProgress = 0f;
        }

        if (isJumping)
        {
            jumpProgress += Time.deltaTime * jumpSpeed;
            float newY = originalY + Mathf.Sin(jumpProgress * Mathf.PI) * jumpHeight;

            if (jumpProgress >= 1f)
            {
                newY = originalY;
                isJumping = false;
            }

            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }

        // Mouse Look Rotation
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, mouseX, Space.World);
        transform.Rotate(Vector3.right, -mouseY, Space.Self);
    }
}
