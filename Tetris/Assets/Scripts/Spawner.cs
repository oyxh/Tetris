using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] groups;
	// Use this for initialization
	void Start () {
        spawnNext();
	}
	
	// 生成一个随机方块
    void spawnNext()
    {
        int i = Random.Range(0, groups.Length);
        GameObject ins = Instantiate(groups[i], transform.position, Quaternion.identity);
    }
}
