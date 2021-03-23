using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    void OnMove(InputValue input)
    {
        Vector2 delta = input.Get<Vector2>();
        Vector3 pos = transform.position;

        transform.position = new Vector3(pos.x + delta.x, pos.y, pos.z + delta.y);
    }

}
