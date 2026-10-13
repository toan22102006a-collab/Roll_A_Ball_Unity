using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Góc xoay trên 3 trục X, Y, Z mỗi giây
    private Vector3 rotationSpeed = new Vector3(15, 30, 45);

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}