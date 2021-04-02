using UnityEngine;

public class RevealController : MonoBehaviour
{
    Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void SetLocation(Vector3 location)
    {
        material.SetVector("_Location", location);
    }

    public void SetHardness(float hardness)
    {
        material.SetFloat("_Hardness", hardness);
    }

    public void SetRadius(float radius)
    {
        material.SetFloat("_Radius", radius);
    }

}
