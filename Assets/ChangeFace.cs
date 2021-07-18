using UnityEngine;
using System.Collections;

public class ChangeFace : MonoBehaviour
{
    public Texture sadface;
    public Texture happyface;
    public Texture neutralface;
    public Texture excitedface;
    public Renderer rend;

    void Start()
    {
       
    }

    public void RendSadFace()
    {
        //rend = GetComponent<Renderer>();
        rend.material.mainTexture = sadface;
    }

    public void RendHappyFace()
    {
        rend.material.mainTexture = happyface;
    }

    public void RendNeutralFace()
    {
        rend.material.mainTexture = neutralface;
    }

    public void RendExcitedFace()
    {
        rend.material.mainTexture = excitedface;
    }
    
}