using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemanager : MonoBehaviour {
    public GameObject[] tiles;
    private List<GameObject> tl;
    float spawnY = 35.0f;
    public GameObject player;
    private Transform pt;
    GameObject go;
    delegate void SpawnTiles();
    private List<SpawnTiles> tilelist;
    int deltiles=0;
    bool del = false;
    // Use this for initialization
    void Start()
    {
        pt = player.transform;
        tl = new List<GameObject>();
        tilelist = new List<SpawnTiles>();
        tilelist.Add(Spawn1);
        tilelist.Add(Spawn2);
        tilelist.Add(Spawn3);
        tilelist.Add(Spawn4);
        tilelist.Add(Spawn5);
        tilelist.Add(Spawn6);
        tilelist.Add(Spawn7);
        tilelist.Add(Spawn8);
        tilelist.Add(Spawn9);
        tilelist.Add(Spawn10);
        StartCoroutine(SpawnCall());
        Invoke("DeleteCall",8.0f);
    }
    void DeleteCall()
    {
        del = true;
    }
    void Update()
    {
        
    }
    IEnumerator SpawnCall()
    {
        while(true)
        {
            SpawnT();
            yield return new WaitForSeconds(2);
        }
    }
    void SpawnT()
    {
       
        tilelist[(int)Random.Range(0, 9.9999f)]();
        if (del == true)
        {
            Delete(deltiles);
        }
    }
    void Instantiate(int index,float posX,float posY)
    {
        go = Instantiate(tiles[index]) as GameObject;
        go.transform.SetParent(transform);
        spawnY += posY;
        go.transform.position = new Vector2(posX, spawnY);
        tl.Add(go);
    }
    void Spawn1()
    {
        Instantiate(0,-8,1.5f);
        Instantiate(0,5,0);
        Instantiate(0,0,6.5f);
        Instantiate(0,-3,4.5f);
        Instantiate(0,3,3);
        Instantiate(0,-4,3);
        Instantiate(0,8,5);
        Instantiate(0,-4,1.5f);
        spawnY += 5;
        deltiles = 8;
        Debug.Log("one");
    }
    void Spawn2()
    {
        Instantiate(11,-1,1.5f);
        Instantiate(11,6.5f,2);
        Instantiate(11,-8.5f,3);
        Instantiate(11,0,3);
        Instantiate(12,7.5f,3);
        Instantiate(12,-7.5f,5);
        Instantiate(11,2.5f,5);
        Instantiate(11,-7.5f,5);
        spawnY += 2.5f;
        deltiles = 8;
        Debug.Log("two");
    }
    void Spawn3()
    {
        Instantiate(4,-0.5f,2.5f);
        Instantiate(4,3.5f,2);
        Instantiate(9,-6.5f,2.5f);
        Instantiate(4,0.5f,3);
        Instantiate(9,6.5f,0);
        Instantiate(4,-9,2);
        Instantiate(4,-3,1.5f);
        Instantiate(9,3,4.5f);
        Instantiate(9,-9,0);
        Instantiate(4,-4.5f,3.5f);
        Instantiate(4,0,1.5f);
        Instantiate(9,-9,1.5f);
        Instantiate(9,-4,3);
        Instantiate(4,4,0);
        spawnY += 2.5f;
        deltiles = 14;
        Debug.Log("three");
    }
    void Spawn4()
    {
        Instantiate(14,0.5f,2);
        Instantiate(14,-10.5f,2.5f);
        Instantiate(15,5,3);
        Instantiate(16,-4,1.5f);
        Instantiate(15,9,5);
        Instantiate(15,-9.5f,2);
        Instantiate(14,-1.5f,0.5f);
        Instantiate(16,6,5);
        Instantiate(16,-5,3);
        spawnY += 5.5f;
        deltiles = 9;
        Debug.Log("four");
    }
    void Spawn5()
    {
        Instantiate(10,-7,3);
        Instantiate(10,7,0);
        Instantiate(11,0,5);
        Instantiate(10,-7,5);
        Instantiate(10,7,0);
        Instantiate(11,-4.5f,8.5f);
        Instantiate(11,4.5f,0);
        Instantiate(5,-10,1.5f);
        Instantiate(5,10,0);
        spawnY += 7;
        deltiles = 9;
        Debug.Log("five");
    }
    void Spawn6()
    {
        Instantiate(0,-3,2.5f);
        Instantiate(9,5.5f,0);
        Instantiate(14,1.5f,4.5f);
        Instantiate(3,-8.5f,1);
        Instantiate(14,-3.5f,1.5f);
        Instantiate(9,5.5f,2);
        Instantiate(9,-6.5f,2);
        Instantiate(3,6.5f,3);
        Instantiate(3,-2.5f,0.5f);
        Instantiate(0,-9.5f,1.5f);
        Instantiate(14,5.5f,2.5f);
        Instantiate(9,-1,1.5f);
        Instantiate(9,-8.5f,2);
        Instantiate(0,-1.5f,3);
        spawnY += 2.5f;
        deltiles = 14;
        Debug.Log("six");
    }
    void Spawn7()
    {
        Instantiate(10,-3.5f,2);
        Instantiate(10,5.5f,3.5f);
        Instantiate(5,-13,2.5f);
        Instantiate(9,-2,1.5f);
        Instantiate(1,5,3.5f);
        Instantiate(5,11,6.5f);
        Instantiate(5,-11,4);
        Instantiate(1,-2,1.5f);
        Instantiate(9,7.5f,5);
        spawnY += 2;
        deltiles = 9;
        Debug.Log("seven");
    }
    void Spawn8()
    {
        Instantiate(13,-7.5f,6);
        Instantiate(13,7.5f,0);
        Instantiate(2,0,10);
        Instantiate(13,-7.5f,10);
        Instantiate(13,7.5f,0);
        spawnY += 4;
        deltiles = 5;
        Debug.Log("eight");
    }
    void Spawn9()
    {
        Instantiate(2, -7.5f, 6);
        Instantiate(2, 7.5f, 0);
        Instantiate(13, 0, 10);
        Instantiate(2, -7.5f, 10);
        Instantiate(2, 7.5f, 0);
        spawnY += 4;
        deltiles = 5;
        Debug.Log("nine");
    }
    void Spawn10()
    {
        Instantiate(16,0,3);
        Instantiate(15,0,6.5f);
        Instantiate(16,-8,2.5f);
        Instantiate(16,8,0);
        Instantiate(14,-2.5f,2.5f);
        Instantiate(14,2.5f,0);
        Instantiate(15,-4.5f,4.5f);
        Instantiate(15,4.5f,0);
        Instantiate(14,0,4);
        spawnY += 7;
        deltiles = 9;
        Debug.Log("ten");
    }
    void Delete(int j)
    {
        for (int i = 0; i < j; i++)
        {
            Destroy(tl[0]);
            tl.RemoveAt(0);
        }
        Debug.Log("owo");
    }

}
