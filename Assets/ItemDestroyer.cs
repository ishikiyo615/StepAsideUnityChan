using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    private int deadline = -10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //unitychanの位置情報を取り出す
        Vector3 uni = GameObject.Find("unitychan").transform.position;
        float z = uni.z;

        if (transform.position.z < z + deadline)
        {
            Destroy(gameObject);
        }

    }
}
