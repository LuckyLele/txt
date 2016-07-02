using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;//初始速度
    private  Move move;
    private CharacterController controller;
	// Use this for initialization
	void Start ()
	{
	    move = this.GetComponent<Move>();
	    controller = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float distance = Vector3.Distance(move.targerPosition,transform.position);
	    if (distance > 0.1f)
	    {
	        controller.SimpleMove(transform.forward*speed);
	    }
	}
   // Vector3 screenSpace  =  WorldToScreenPoint(transform.position);//三维物体坐标转屏幕坐标
}
