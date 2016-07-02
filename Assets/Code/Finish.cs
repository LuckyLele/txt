using UnityEngine;
using System.Collections;

public class Finish: MonoBehaviour
{
    [SerializeField] public UIButton button;//游戏胜利
    [SerializeField] public UIButton button1;//继续游戏
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider coll)
    {
        
            Time.timeScale = 0;
            button.gameObject.SetActive(true);
            button1.gameObject.SetActive(true);
    }
}
