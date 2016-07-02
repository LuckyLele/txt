using UnityEngine;
using System.Collections;

public class camera_jump : MonoBehaviour
{
    private Vector3 offsetPosition;//相机与人物坐标的距离;
    private Transform player;
  
	// Use this for initialization
	void Start ()
	{
        //获取人物当前对象transform组件；
        player = GameObject.FindGameObjectWithTag("play").transform;
        //旋转物体，指向相机的当前位置
        transform.LookAt(transform.position);
        offsetPosition = transform.position - player.position;
     
	}
	
	// Update is called once per frame
	void Update ()
	{
        //运动后相机的坐标
	    transform.position = offsetPosition + player.position;
	}
}
