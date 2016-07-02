using UnityEngine;
using System.Collections;

public class Startmenu : MonoBehaviour {
    //[SerializeField]
    //public UIButton satrtgame;//开始游戏
    [SerializeField]
    public UISprite gameDescription;//游戏说明


    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void StartLoad()
    {
        Application.LoadLevel(1);
    }
    public void GameDescription()
    {
        gameDescription.gameObject.SetActive(true);
    }

    public void Return()
    {
        gameDescription.gameObject.SetActive(false);
    }
}
