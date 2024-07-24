using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VR_SceneSwitcher : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

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
		else if (Name == "-1")
		{
			SceneManager.LoadScene("Test");
		}
	}
}
