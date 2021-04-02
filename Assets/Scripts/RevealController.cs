using UnityEngine;

namespace MMC
{
    public class RevealController : MonoBehaviour
    {
        Material material;

        static Vector3 revealLocation;
        static float hardness;
        static float radius;

        // Start is called before the first frame update
        void Start()
        {
            material = GetComponent<MeshRenderer>().sharedMaterial;
            material.SetFloat("_Radius", radius);
            material.SetFloat("_Hardness", hardness);
        }

        void LateUpdate()
        {
            material.SetVector("_Location", revealLocation); // we want to update this after we have received the new location
        }

        public static void SetLocation(Vector3 location)
        {
            revealLocation = location;
        }

        public static void SetHardness(float _hardness)
        {
            hardness = _hardness;
        }

        public static void SetRadius(float _radius)
        {
            radius = _radius;
        }
    }
}