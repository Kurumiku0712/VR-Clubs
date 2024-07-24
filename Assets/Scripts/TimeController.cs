using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour
{

	SteamVR_TrackedController TrackedController;
	float TouchPadX, TouchPadY;

	bool IsTrigger;

	Light CurrentLight;

	// Use this for initialization
	void Start()
	{
		CurrentLight = GameObject.Find("Directional Light").GetComponent<Light>();

		//获取控制器
		TrackedController = GetComponent<SteamVR_TrackedController>();
		//添加Trigger按下和松开的监听
		TrackedController.TriggerClicked += Trigger;
		TrackedController.TriggerUnclicked += UnTrigger;

	}

	void Trigger(object sender, ClickedEventArgs e)
	{
		//当按下的时候 设置is Trigger为true
		IsTrigger = true;
	}

	void UnTrigger(object sender, ClickedEventArgs e)
	{
		//当按下的时候 设置is Trigger为false
		IsTrigger = false;
	}

	// Update is called once per frame
	void Update()
	{

		if (IsTrigger)
		{
			//获取当前触摸位置 如果不为0 就根据触摸的x轴来调整平行光朝向
			if (TrackedController.controllerState.rAxis0.x != 0 && TrackedController.controllerState.rAxis0.y != 0)
			{
				float angle = 90 + TrackedController.controllerState.rAxis0.x * 120;

				CurrentLight.transform.rotation = Quaternion.AngleAxis(angle, Vector3.right);
			}
		}
	}
}
