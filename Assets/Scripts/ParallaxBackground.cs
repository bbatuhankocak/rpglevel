using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private GameObject cam;

    [SerializeField] private float parallaxEffect;

    private float xPosition;
    private float length;
    void Start()
    {
        cam = GameObject.Find("Main Camera");

        xPosition = transform.position.x;

        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceMoved = cam.transform.position.x * (1-parallaxEffect);
        float distanceToMove = parallaxEffect * cam.transform.position.x;

        transform.position = new Vector3 (xPosition + distanceToMove,transform.position.y);


        if(distanceMoved > length + xPosition)
        {
            xPosition = xPosition + length;

        }else if (distanceMoved < xPosition-length)
            xPosition = xPosition - length;
    }
}
