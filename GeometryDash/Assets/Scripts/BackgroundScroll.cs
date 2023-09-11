using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speedBg;
    public float speedG;
    public Transform background;
    public Transform ground;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //background x���� -1156 �����϶� x�� ���� 1920���� ����
        if(background.position.x < -1150)
        {
            background.position = new Vector3(1920, 540, 0);
        }
        background.position += new Vector3(-speedBg, 0, 0) * Time.deltaTime;
        //ground x���� -1146 �����϶� x�� ���� 1146���� ����
        if (ground.position.x < -1146)
        {
            ground.position = new Vector3(1146, 540, 0);
        }
        ground.position += new Vector3(-speedG, 0, 0) * Time.deltaTime;

    }
}
