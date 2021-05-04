using UnityEngine;
using UnityEngine.InputSystem;

namespace MMC
{
    public class PlayerController : MonoBehaviour
    {
        const float MOUSE_SENSITIVITY = 0.3f;
        const float MOVEMENT_SPEED = 0.2f;
        // existing camera member is obsolete so we need the new keyword here
        // https://docs.unity3d.com/ScriptReference/Component-camera.html
        new Camera camera;

        Transform playerMesh;

        float xRotation;
        float yRotation;

        bool bIsMoving;
        Vector2 movementDelta;

        void Awake()
        {
            camera = transform.Find("Camera").GetComponent<Camera>();
            Cursor.lockState = CursorLockMode.Locked;
            playerMesh = transform.Find("Mesh");

            xRotation = 0.0f;
            yRotation = 0.0f;
            bIsMoving = false;
            movementDelta = new Vector2();
        }

        void FixedUpdate()
        {
            if (bIsMoving)
            {
                Move(movementDelta);
            }
        }

        private void Move(Vector2 delta)
        {
            transform.position += playerMesh.transform.forward * delta.y * MOVEMENT_SPEED;
            transform.position += playerMesh.transform.right * delta.x * MOVEMENT_SPEED;
        }

        public void OnMove(InputAction.CallbackContext value)
        {
            movementDelta = value.ReadValue<Vector2>();
            bIsMoving = (movementDelta.x != 0 || movementDelta.y != 0);
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
