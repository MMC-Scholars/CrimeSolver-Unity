
using UnityEngine;

namespace MMC
{
    public class Item : MonoBehaviour, IInteractable
    {
        public bool IsInInventory { get; set; }
        public bool IsInHand { get; set; }

        [SerializeField]
        Vector3 inHandPosition;
        public Vector3 InHandPosition { get { return inHandPosition; } }

        [SerializeField]
        Quaternion inHandRotation;
        public Quaternion InHandRotation { get { return inHandRotation; } }

        [SerializeField]
        Vector3 aimPosition;
        public Vector3 AimPosition { get { return aimPosition; } }

        [SerializeField]
        Quaternion aimRotation;
        public Quaternion AimRotation { get { return aimRotation; } }

        public virtual void StartInteract(Pawn interacter, Vector3 hitLocation, Vector3 hitNormal)
        {
            PlayerPawn player = interacter as PlayerPawn;
            if (player != null)
            {
                // check for space in the player inventory

                // if there is space then place item into inventory

            }
        }
        public virtual void StopInteract() { }
        public virtual void Select()
        {
            IsInHand = true;
            gameObject.GetComponent<Renderer>().enabled = true;
        }

        public virtual void Deselect()
        {
            IsInHand = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }

    }
}