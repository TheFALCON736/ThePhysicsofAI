using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject shellPrefab;
    public GameObject shellSpawnPos;
    public GameObject target;
    public GameObject parent;
    float speed = 15;
    float turnSpeed = 2;

    
    void Start()
    {
        
    }

    void Fire()
    {
        GameObject shell = Instantiate(shellPrefab, shellSpawnPos.transform.position, shellSpawnPos.transform.rotation);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Fire();

        Vector3 direction = (target.transform
    }
}
