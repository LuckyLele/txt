using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public  Vector3 targerPosition=Vector3.zero;
	// Use this for initialization
	void Start ()
	{
	    targerPosition = transform.position;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //从摄像机发出到点击坐标的射线
            RaycastHit hitInfo;
            bool isCollider = Physics.Raycast(ray, out hitInfo);
            if (isCollider&&hitInfo.collider.tag=="ground")
            {
                lookAtTarget(hitInfo.point);
            }
        }
    }
    void lookAtTarget(Vector3 hitPoint)
    {
        //让主角朝向目标位置
        targerPosition = hitPoint;
        targerPosition=new Vector3(targerPosition.x,transform.position.y,targerPosition.z);
        //旋转物体，这样向前向量指向targerPosition的当前位置
        this.transform.LookAt(targerPosition);
        
    }

}
