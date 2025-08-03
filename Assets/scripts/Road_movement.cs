 using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Road_Movement : MonoBehaviour
{
    public float scrollSpeed = 1f;
    private Renderer rend;
    private Vector2 offset;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        offset.y += scrollSpeed * Time.deltaTime;
        rend.material.mainTextureOffset = offset;
    }
}