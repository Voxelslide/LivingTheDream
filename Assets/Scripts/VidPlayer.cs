using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

//using tutorial https://www.youtube.com/watch?v=9UE3hLSHMTE

public class VidPlayer : MonoBehaviour
{

  [SerializeField] string videoFileName;


    // Start is called before the first frame update
    void Start()
    {
    PlayVideo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  IEnumerator End()
  {
    // suspend execution for 5 seconds
    yield return new WaitForSeconds(11);
    print("WaitAndPrint " + Time.time);
    Application.Quit();
  }


  public void PlayVideo()
	{
    VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
		if (videoPlayer)
		{
      string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
      Debug.Log(videoPath);
      videoPlayer.url = videoPath;
      videoPlayer.Play();
      StartCoroutine("End");


    }
	}


}
