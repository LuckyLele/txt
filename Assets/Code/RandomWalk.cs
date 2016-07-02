using UnityEngine;
using System.Collections;

public class RandomWalk : MonoBehaviour
{
    [SerializeField] private Transform spot;//npc对象
    [SerializeField]private NavMeshAgent navMesh;
    private float x;
    private float z;
    private bool isWalk = false;
    private Vector3 originalpoint;//初始点
    private Vector3 nextpoint;//下一个点
    // Use this for initialization
    void Start()
    {
        
        originalpoint = spot.position;//npc坐标
        //每次开始游戏都下一个点都不同；
        x = Random.Range(spot.position.x - 10, spot.position.x + 10); //随机X坐标
        z = Random.Range(spot.position.z - 10, spot.position.z + 10); //随机Z坐标
        nextpoint = new Vector3(x, spot.position.y, z);
        navMesh.SetDestination(nextpoint);

    }

    // Update is called once per frame
    void Update()
    {
        //npc在两点之间来回走动
        if (navMesh.remainingDistance < 0.1f && !isWalk)
        {
            navMesh.SetDestination(originalpoint);
            isWalk = !isWalk;
        }
        else if (navMesh.remainingDistance < 0.1f && isWalk)
        {
            navMesh.SetDestination(nextpoint);
            isWalk = !isWalk;
        }

    }
}
