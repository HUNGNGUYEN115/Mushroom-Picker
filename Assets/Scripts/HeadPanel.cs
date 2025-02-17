using UnityEngine;

public class HeadPanel : MonoBehaviour
{
    public Transform Head; // Assign the enemy's head transform
    public Vector3 offset = new Vector3(0, 1.5f, 0); // Adjust to float above head

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Head == null) return;

        // Position UI above the enemy
        transform.position = Head.position + offset;

        // Make UI face the camera (billboard effect)
        transform.LookAt(mainCamera.transform);
        transform.Rotate(0, 180, 0); // Flip because LookAt rotates it backwards
    }

    public void ShowPanel(bool show)
    {
        gameObject.SetActive(show); // Show or hide the UI panel
    }
}
