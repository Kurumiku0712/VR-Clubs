using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DynamicSkybox : MonoBehaviour
{
    private float value;//数值

    public float speed;//移动速度

    private void Update()
    {
        value += Time.deltaTime * speed;
        GetComponent<Skybox>().material.SetFloat("_Rotation", value);
    }
}