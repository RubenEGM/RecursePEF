using UnityEngine;

public class RotarContinuamente : MonoBehaviour
{
    // Rotation speed on each axis
    [SerializeField]public Vector3 rotationSpeed = new Vector3(0, 100, 0);

    void Update()
    {
        // Rotate the object over time
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
