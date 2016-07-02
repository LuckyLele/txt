using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Iscollision: MonoBehaviour
{
    [SerializeField] public UIButton button;//重新开始游戏
   
	// Use this for initialization
	void Start ()
	{
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {
            Time.timeScale = 0;
            button.gameObject.SetActive(true);
       
    }

}
