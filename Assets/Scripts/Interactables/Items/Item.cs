
using UnityEngine;

namespace MMC
{
    public abstract class Item : MonoBehaviour, IInteractable
    {
        public bool IsInHand { get; protected set; }

        [field: SerializeField]
        public Vector3 InHandPosition { get; protected set; }

        [field: SerializeField]
        Quaternion inHandRotation;
        public Quaternion InHandRotation { get; protected set; }

        [field: SerializeField]
        public Vector3 AimPosition { get; protected set; }

        [SerializeField]
        Quaternion aimRotation;
        public Quaternion AimRotation { get { return aimRotation; } }

        public virtual void StartInteract(PlayerPawn player, Vector3 hitLocation, Vector3 hitNormal)
        {
            // check for space in the player inventory

            // if there is space then place item into inventory
        }
        public virtual void StopInteract() { }

        void SetSelect(bool bIsSelected)
        {
            IsInHand = bIsSelected;
            gameObject.GetComponent<Renderer>().enabled = IsInHand;
        }
        public virtual void Select()
        {
            SetSelect(true);
        }

        public virtual void Deselect()
        {
            SetSelect(false);
        }

    }
}