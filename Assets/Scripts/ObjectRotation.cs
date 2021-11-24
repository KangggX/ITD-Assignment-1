using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class ObjectRotation : MonoBehaviour
{
    public BoxCollider collider;
    public bool canRotate = false;

    private void Update()
    {
        collider.enabled = canRotate;
    }

    // Detects if user is dragging the collider. if true, they can rotate the object based on the axis
    private void OnMouseDrag()
    {
        float x = Input.GetAxis("Mouse X") * 1;
        float y = Input.GetAxis("Mouse Y") * 1;

        transform.Rotate(Vector3.down, x, Space.World);
        transform.Rotate(Vector3.right, y, Space.World);
    }

    // Activates object rotation
    public void ActivateRotation()
    {
        // if canRotate == true
        if (canRotate)
        {
            canRotate = !canRotate;
            collider.enabled = canRotate;
        }
        else // if canRotate == false
        {
            canRotate = !canRotate;
            collider.enabled = canRotate;
        }
    }
}
