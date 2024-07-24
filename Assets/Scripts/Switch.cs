using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
	UnityEngine.Video.VideoPlayer switchVideoPlayer;
	public double nextSceneNum;

	// Start is called before the first frame update
	void Start()
	{
		switchVideoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void switcher()
	{
		switchVideoPlayer.loopPointReached += EndReached;
		switchVideoPlayer.Play();

	}

	void EndReached(UnityEngine.Video.VideoPlayer switchVideoPlayer)
	{
		if (nextSceneNum == 1)
		{
			SceneManager.LoadScene("1_MainRoom");
		}
		else if (nextSceneNum == 2.1)
		{
			SceneManager.LoadScene("2.1_Star");
		}
		else if (nextSceneNum == 2.2)
		{
			SceneManager.LoadScene("2.2_Sea");
		}
		else if (nextSceneNum == 2.3)
		{
			SceneManager.LoadScene("2.3_Classroom");
		}
		else if (nextSceneNum == 2.4)
		{
			SceneManager.LoadScene("2.4_SnowMountain");
		}
		else if (nextSceneNum == 2.5)
		{
			SceneManager.LoadScene("2.5_Scut");
		}
		else if (nextSceneNum == 2.6)
		{
			SceneManager.LoadScene("2.6_Rome");
		}
		else if (nextSceneNum == 2.7)
		{
			SceneManager.LoadScene("2.7_Paris");
		}
		else if (nextSceneNum == 2.8)
		{
			SceneManager.LoadScene("2.8_Sunset");
		}
		else if (nextSceneNum == 3)
		{
			SceneManager.LoadScene("3_MusicRoom");
		}
		else if (nextSceneNum == 4)
		{
			SceneManager.LoadScene("4_Canteen");
		}
		else if (nextSceneNum == 5)
		{
			SceneManager.LoadScene("5_BasketballCourt");
		}
	}

}
