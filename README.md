# arvr
tasks
# 🎮 C# Learning Task – Phase 1

## 📌 Task Description
This task helps learn **basic C# syntax** and apply it in Unity.  
You are required to:

1. Learn basic C# concepts: Variables, Loops, Conditions, Classes.  
2. Write simple Unity scripts: Rotate an object and Move a character.  
3. Document your scripts with brief explanations.

---

## 📌 Step 1: Learn Basic C# Syntax
- **Variables:** Store and manage data (e.g., int, float, string).  
- **Loops:** Repeat actions (`for`, `while`).  
- **Conditions:** Decision-making (`if`, `else`, `switch`).  
- **Classes:** Define objects and their methods.

---

## 📌 Step 2: Unity C# Scripts

### 🔹 1. Rotate an Object:This script rotates any GameObject it is attached to. rotationSpeed controls how fast it rotates, and Time.deltaTime ensures smooth rotation regardless of frame rate. Attach this script to a Cube or any GameObject to see it rotate.

```csharp
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
movement code:This script allows a GameObject (like a Capsule) to move based on keyboard input. Input.GetAxis() detects horizontal and vertical input, and transform.Translate() moves the object in 3D space. Attach this script to a Capsule or any GameObject you want to move
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
