using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed

    void Update()
    {
        // Get input from keyboard
        float moveX = Input.GetAxis("Horizontal"); // Left/Right or A/D
        float moveZ = Input.GetAxis("Vertical");   // Forward/Backward or W/S

        // Move the character in world space
        Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);
    }
}

