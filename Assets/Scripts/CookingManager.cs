using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager : MonoBehaviour
{

    public GameObject Dish;
    public GameObject Dish2;

    double number;
    bool cook;

    GameObject Potato;
    GameObject Tomato;
    GameObject Egg;

    public AudioSource ding;

    public UnityEngine.Video.VideoPlayer cookingVideoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Potato = GameObject.Find("Potato");
        Tomato = GameObject.Find("Tomato");
        Egg = GameObject.Find("Egg");
        cook = false;
        Dish.gameObject.SetActive(false);
        Dish2.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        number = Potato.GetComponent<Food>().getNum()
               + Tomato.GetComponent<Food>().getNum()
               + Egg.GetComponent<Food>().getNum();

        if ( number == 1 && cook)
        {
            Potato.gameObject.SetActive(false);

            cookingVideoPlayer.loopPointReached += EndReached;
            cookingVideoPlayer.Play();           
    
            //Debug.Log("激活土豆丝" + number);
        }
        else if (number == 1.3 && cook)
        {
            Tomato.gameObject.SetActive(false);
            Egg.gameObject.SetActive(false);

            cookingVideoPlayer.loopPointReached += EndReached;
            cookingVideoPlayer.Play();

            //Debug.Log("激活番茄炒鸡蛋" + number);
        }

    }

    private void resetFood()
    {
        Potato.gameObject.SetActive(true);
        Potato.gameObject.transform.position = new Vector3(-3.615828f, 1f, -1.923251f);
        Potato.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Potato.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        Tomato.gameObject.SetActive(true);
        Tomato.gameObject.transform.position = new Vector3(-3.505829f, 1f, -1.673251f);
        Tomato.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Tomato.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        Egg.gameObject.SetActive(true);
        Egg.gameObject.transform.position = new Vector3(-3.495829f, 1f, -1.453251f);
        Egg.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Egg.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        //Debug.Log(number);
    }

    public void OnBtnClick( int num )
    {
        if( num == 1 )
        {
            cook = true;
        }
        else if( num == 0 )
        {
            resetFood();
            cook = false;
            Dish.gameObject.SetActive(false);
            Dish2.gameObject.SetActive(false);
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer cookingVideoPlayer)
    {
        ding.Play();
        cookingVideoPlayer.Stop();

        cook = false;

        if(number==1)
        {
            Dish.gameObject.SetActive(true);
        }
        else if (number == 1.3)
        {
            Dish2.gameObject.SetActive(true);
        }

    }



}
