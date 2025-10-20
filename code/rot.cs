using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f; // Rotation speed in degrees per second

    void Update()
    {
        // Rotate the object continuously around Y-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
