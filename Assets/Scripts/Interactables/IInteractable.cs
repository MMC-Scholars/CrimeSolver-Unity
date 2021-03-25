using UnityEngine;

namespace MMC
{
    public interface IInteractable
    {

        public void StartInteract(Pawn interacter, Vector3 hitLocation, Vector3 hitNormal);

        public void StopInteract();

    }
}
