﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jyunkaiEnemy : MonoBehaviour
{
    public EnemyController enemyController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < enemyController.jyunkaiTarget.Length; i++)
        {
            if (other.gameObject == enemyController.jyunkaiTarget[i])
            {
                Debug.Log("接触");
                enemyController.jyunkaiIndex =(i + 1)%enemyController.jyunkaiTarget.Length;
            }
        }
    }
}
