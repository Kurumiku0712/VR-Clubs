using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PickupFood : MonoBehaviour
{

	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;

	// Use this for initialization
	void Awake()
	{

		trackedObj = GetComponent<SteamVR_TrackedObject>();

	}

	// Update is called once per frame
	void FixedUpdate()
	{

		device = SteamVR_Controller.Input((int)trackedObj.index);

	}

	void OnTriggerStay(Collider collider)
	{
		if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
		{

			collider.attachedRigidbody.isKinematic = true;
			collider.gameObject.transform.SetParent(gameObject.transform);

		}

		if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
		{
			collider.attachedRigidbody.isKinematic = false;
			collider.gameObject.transform.SetParent(null);

			tossObject(collider.attachedRigidbody);
		}

	}

	//处理投掷
	void tossObject(Rigidbody rigidbody)
	{
		//设置起始位置
		//有原始位置则取原始位置
		//没有原始位置则取父位置
		Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;

		if (origin != null)
		{
			rigidbody.velocity = origin.TransformVector(device.velocity) * 2;
			rigidbody.angularVelocity = origin.TransformVector(device.angularVelocity);
		}
		else
		{
			rigidbody.velocity = device.velocity * 2;
			rigidbody.angularVelocity = device.angularVelocity;
		}


	}

}
