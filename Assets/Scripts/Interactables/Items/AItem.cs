
using UnityEngine;

namespace MMC
{
    public abstract class AItem : MonoBehaviour, IInteractable
    {
        public bool IsInHand { get; protected set; }

        [field: SerializeField]
        public Vector3 InHandPosition { get; protected set; }

        [field: SerializeField]
        public Quaternion InHandRotation { get; protected set; }

        [field: SerializeField]
        public Vector3 AimPosition { get; protected set; }

        [field: SerializeField]
        public Quaternion AimRotation { get; protected set; }

        public virtual void StartInteract(PlayerPawn player, Vector3 hitLocation, Vector3 hitNormal)
        {
            // check for space in the player inventory

            // if there is space then place AItem
            // into inventory
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