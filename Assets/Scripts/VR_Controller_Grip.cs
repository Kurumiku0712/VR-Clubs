using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.UI;
using DG.Tweening;

public class VR_Controller_Grip : MonoBehaviour
{
    public Image PlaneImageTips;
    private bool isImageTipsShow = false;


    // Start is called before the first frame update
    void Start()
    {
        PlaneImageTips.enabled = false;
        PlaneImageTips.rectTransform.localScale = Vector3.zero;
        VRTK_ControllerEvents events = GetComponent<VRTK_ControllerEvents>();
        events.GripPressed += new ControllerInteractionEventHandler(onGripPressed);
    }


    private void onGripPressed(object sender, ControllerInteractionEventArgs events)
    {
        if (isImageTipsShow)
        {
            PlaneImageTips.rectTransform.DOScale(Vector3.zero, 0.3f);
            isImageTipsShow = false;
        }
        else
        {
            PlaneImageTips.enabled = true;
            PlaneImageTips.rectTransform.DOScale(Vector3.one, 0.3f);
            isImageTipsShow = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
