using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ForDebug : MonoBehaviour
{
    public Transform background;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float yScreenHalfSize = Camera.main.orthographicSize;
        float xScreenHalfSize = yScreenHalfSize * Camera.main.aspect;

        float leftPosX = -(xScreenHalfSize * 2);
        float rightPosX = xScreenHalfSize * 2;

        Debug.Log(leftPosX);
        Debug.Log(rightPosX);
    }
}
