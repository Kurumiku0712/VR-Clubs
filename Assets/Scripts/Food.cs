using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    string foodName;
    double num;
    // Start is called before the first frame update
    void Start()
    {
        foodName = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "G" && foodName == "Potato" )
        {
            num = 1;
            //Debug.Log("土豆" + num);
        }
        if (collision.collider.tag == "G" && foodName == "Tomato")
        {
            num = 0.1;
            //Debug.Log("番茄" + num);
        }
        if (collision.collider.tag == "G" && foodName == "Egg")
        {
            num = 0.2;
            //Debug.Log("鸡蛋" + num);
        }
    }

    public double getNum()
    {
        return num;
    }


}
