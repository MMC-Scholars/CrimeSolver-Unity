using UnityEngine;

namespace MMC
{
    public class Image : Item
    {
        //
        //  Declare reference to current billboard here
        //
        public bool bIsPinned; // specifically "pinned" to a board
        public bool bImagePinsPermanently; // theoretically an image can be pinned permanently (to some surface) but not be "pinned" to a board
        public Vector3 vPinnedImageScale;
        public override void OnStartInteract(Pawn interacter, Vector3 hitLocation, Vector3 hitNormal)
        {
            PlayerPawn player = interacter as PlayerPawn;
            if (player != null)
            {
                // get current item in hand

                // check if item in hand is in image

                // if YES item in hand is image, check if we are pinned 
                //// if YES we are pinned, add the image in hand to billboard
                //// if NO we are not pinned, check if we are not pinned permanently
                ////// if YES, base.OnStartInteract(interacter, hitLocation, hitNormal);
                // if NO item in hand is not image, check if we are not pinned permanently
                //// if YES, base.OnStartInteract(interacter, hitLocation, hitNormal);

            }
        }

    }


}