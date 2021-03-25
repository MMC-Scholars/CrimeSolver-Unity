using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MMC
{
    public class Item : MonoBehaviour, IInteractable
    {
        public bool bIsInInventory;
        public bool bIsInHand;
        public Transform tInHandTransform;
        public Transform tAimTransform;

        public virtual void OnStartInteract(Pawn interacter, Vector3 hitLocation, Vector3 hitNormal)
        {
            PlayerPawn player = interacter as PlayerPawn;
            if (player != null)
            {
                // check for space in the player inventory

                // if there is space then place item into inventory

            }
        }
        public virtual void OnStopInteract() { }
        public virtual void OnSelect()
        {
            bIsInHand = true;
            gameObject.GetComponent<Renderer>().enabled = true;
        }

        public virtual void OnDeselect()
        {
            bIsInHand = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }

    }
}