using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class VR_UI_Manager : MonoBehaviour
{

	public GameObject PanelList;
	public GameObject StartButton;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	//显示选择列表
	public void ShowPanelList()
	{
		PanelList.SetActive(true);
		StartButton.SetActive(false);

		int count = PanelList.transform.childCount;
		for (int i = 0; i < count; i++)
		{
			Transform Btn = PanelList.transform.GetChild(i);
			Btn.transform.localScale = Vector3.zero;
			Btn.DOScale(Vector3.one, 0.3f).SetDelay(i * 0.1f);
		}
	}

	//隐藏人物选择列表
	public void HidePanelList()
	{
		int count = PanelList.transform.childCount;
		for (int i = 0; i < count; i++)
		{
			Transform Btn = PanelList.transform.GetChild(i);
			Btn.DOScale(Vector3.zero, 0.3f).SetDelay(i * 0.1f);
		}
	}

	//按钮点击函数
	public void OnBtnClick(string Name)
	{
		if (Name == "0")
		{
			SceneManager.LoadScene("0_Main");
		}
		else if (Name == "1")
		{
			SceneManager.LoadScene("1_MainRoom");
		}
		else if (Name == "2")
		{
			SceneManager.LoadScene("2.1_Star");
		}
		else if (Name == "3")
		{
			SceneManager.LoadScene("2.2_Sea");
		}
		else if (Name == "4")
		{
			SceneManager.LoadScene("2.3_Classroom");
		}
		else if (Name == "5")
		{
			SceneManager.LoadScene("2.4_SnowMountain");
		}
		else if (Name == "6")
		{
			SceneManager.LoadScene("2.5_Scut");
		}
		else if (Name == "7")
		{
			SceneManager.LoadScene("2.6_Rome");
		}
		else if (Name == "8")
		{
			SceneManager.LoadScene("2.7_Paris");
		}
		else if (Name == "9")
		{
			SceneManager.LoadScene("2.8_Sunset");
		}
		else if (Name == "10")
		{
			SceneManager.LoadScene("3_MusicRoom");
		}
		else if (Name == "11")
		{
			SceneManager.LoadScene("4_Canteen");
		}
		else if (Name == "12")
		{
			SceneManager.LoadScene("5_BasketballCourt");
		}

	}

}
