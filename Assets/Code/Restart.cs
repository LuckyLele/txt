using UnityEngine;
using System.Collections;

public class Restart: MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   public  void Load()
    {
       //重新开始游戏
        Application.LoadLevel(1);
       Time.timeScale = 1;
    }

    public void Quit()
    {
        //退出游戏
        Application.Quit();
    }

    public void startmenu()
    {
        //返回开始界面
        Application.LoadLevel(0);
    }

}
