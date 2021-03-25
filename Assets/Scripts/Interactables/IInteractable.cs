using UnityEngine;

namespace MMC
{
    public interface IInteractable
    {

        public void OnStartInteract(Pawn interacter, Vector3 hitLocation, Vector3 hitNormal);

        public void OnStopInteract();

    }
}
