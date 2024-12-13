using UnityEngine;

public class MoveImage : MonoBehaviour
{
    // Speed at which the image moves
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Get input for movement (arrow keys or WASD)
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down Arrow

        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontal, vertical, 0) * moveSpeed * Time.deltaTime;

        // Apply the movement to the image's RectTransform
        transform.position += movement;
    }
}
