using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    [SerializeField] List<GameObject> nPCList;
    [SerializeField] GameObject[] nPC;
    [SerializeField] int maxNPC;
    Vector3 spawnPosition = new Vector3(-11.5f, 0, 0);

    void Start()
    {
        for(int i = 0; i < maxNPC; i++)
        {
            int randomNumber = Random.Range(0, nPC.Length);
            GameObject nPCSpawn = Instantiate(nPC[randomNumber], spawnPosition, Quaternion.identity, transform);
            nPCSpawn.GetComponent<SpriteRenderer>().sortingOrder = i;
            nPCList.Add(nPCSpawn);
        }
    }
}