using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
    //目的地となるオブジェクトのトランスフォーム格納用
    public Transform target;
    //エージェントとなるオブジェクトのNavMeshAgent格納用
    public NavMeshAgent agent;
    public NavMeshAgent[] agents;
    // Use this for initialization

    void Start(){

    }

    void Update()
    {
        for(int i=0;i<agents.Length;i++){
            //目的地となる座標を設定する
            agents[i].destination = target.position;
        }
    }
}