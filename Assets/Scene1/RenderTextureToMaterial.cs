using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderTextureToMaterial : MonoBehaviour
{
    public RenderTexture renderTexture;
    public Material material;
    // Start is called before the first frame update
    void Start()
    {
        this.material.mainTexture = this.renderTexture;
    }
}
