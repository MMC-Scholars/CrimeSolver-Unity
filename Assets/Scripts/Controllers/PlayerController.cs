using UnityEngine;
using UnityEngine.InputSystem;

namespace MMC
{
    public class PlayerController : MonoBehaviour
    {
        const float MOUSE_SENSITIVITY = 0.3f;
        // existing camera member is obsolete so we need the new keyword here
        // https://docs.unity3d.com/ScriptReference/Component-camera.html
        new Camera camera;

        float xRotation = 0.0f;
        float yRotation = 0.0f;


        void Start()
        {
            camera = GameObject.Find("Camera").GetComponent<Camera>();
            /* Cursor.lockState = CursorLockMode.Locked; */
            Cursor.lockState = CursorLockMode.Confined;
        }

        public void OnMove(InputAction.CallbackContext value)
        {
            Vector2 delta = value.ReadValue<Vector2>();
            Vector3 input = new Vector3(delta.x, 0, delta.y);

            transform.position += input;
        }

        public void OnLook(InputAction.CallbackContext value)
        {
            Vector2 delta = value.ReadValue<Vector2>();

            yRotation += delta.x * MOUSE_SENSITIVITY;
            xRotation -= delta.y * MOUSE_SENSITIVITY;
            xRotation = Mathf.Clamp(xRotation, -90, 90);

            camera.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);

            /* Debug.Log($"input is {delta}!"); */
        }

        public void OnMenu()
        {
            Debug.Log("cancelled actions");
            Application.Quit();
        }

    }
}
