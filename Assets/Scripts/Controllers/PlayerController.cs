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

        Transform playerMesh;

        float xRotation = 0.0f;
        float yRotation = 0.0f;

        void Awake()
        {
            camera = transform.Find("Camera").GetComponent<Camera>();
            Cursor.lockState = CursorLockMode.Locked;
            playerMesh = transform.Find("Mesh");
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

            camera.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0.0f);
            playerMesh.localRotation = Quaternion.Euler(0.0f, yRotation, 0.0f);
        }

        public void OnInteract(InputAction.CallbackContext value)
        { }

        public void OnQuit()
        {
#if UNITY_STANDALONE
            Application.Quit();
#endif
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

    }
}
