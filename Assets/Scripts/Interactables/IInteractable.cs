using UnityEngine;

namespace MMC
{
    public interface IInteractable
    {

        public void StartInteract(PlayerPawn player, Vector3 hitLocation, Vector3 hitNormal);

        public void StopInteract();

    }
}
