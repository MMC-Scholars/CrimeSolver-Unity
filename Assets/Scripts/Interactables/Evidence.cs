using UnityEngine;

namespace MMC
{
    public enum EEvidenceType
    {
        PHYSICAL,
        PHOTO,
        MAGNIFIED,
        INVISIBLE
    }

    public class Evidence : Item
    {
        [SerializeField]
        EEvidenceType type;
        public EEvidenceType Type { get { return type; } }

        public bool IsFound { get; protected set; }

        public void FindEvidence()
        {
            // we have found this 
            IsFound = true;

            // increment evidence count

        }

        public override void StartInteract(PlayerPawn player, Vector3 hitLocation, Vector3 hitNormal)
        {
            if (type == EEvidenceType.PHYSICAL)
            {
                base.StartInteract(player, hitLocation, hitNormal);
            }
        }
    }
}