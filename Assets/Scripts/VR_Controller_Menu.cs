using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.UI;
using DG.Tweening;

public class VR_Controller_Menu : MonoBehaviour
{
    public Image PlaneImage;
    private bool isImageShow = false;


    // Start is called before the first frame update
    void Start()
    {
        PlaneImage.enabled = false;
        PlaneImage.rectTransform.localScale = Vector3.zero;
        VRTK_ControllerEvents events = GetComponent<VRTK_ControllerEvents>();
        events.ApplicationMenuPressed += new ControllerInteractionEventHandler(onApplicaitonMenuPressed);
    }

    private void onApplicaitonMenuPressed(object sender, ControllerInteractionEventArgs events)
    {
        if(isImageShow)
        {
            PlaneImage.rectTransform.DOScale(Vector3.zero, 0.3f);
            isImageShow = false;
        }
        else
        {
            PlaneImage.enabled = true;
            PlaneImage.rectTransform.DOScale(Vector3.one, 0.3f);
            isImageShow = true; 
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
