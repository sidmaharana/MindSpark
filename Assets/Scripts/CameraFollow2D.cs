using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform ramji;    // Reference to the "Ramji" GameObject's transform
    public Vector3 offset;     // Offset between the camera and "Ramji"

    void Start()
    {
        // Assign the Ramji GameObject if it's not set in the Inspector
        if (ramji == null)
        {
            ramji = GameObject.FindGameObjectWithTag("Ramji").transform;
        }

        // Initialize the offset (difference between the camera's position and "Ramji"'s position)
        offset = transform.position - ramji.position;
    }

    void LateUpdate()
    {
        // Follow "Ramji" only on the x and y axes, keeping the z position unchanged
        if (ramji != null)  // Ensure ramji is assigned before trying to access it
        {
            Vector3 newPosition = ramji.position + offset;
            newPosition.z = transform.position.z;  // Keep the z position the same
            transform.position = newPosition;
        }
    }
}
