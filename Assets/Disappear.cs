using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public bool disappear;
    public GameObject furniture;

    
    // Use this for initialization
    void Start()
    {
        furniture.SetActive(true);
    }

    public void SetInactive()
    {
        furniture.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}