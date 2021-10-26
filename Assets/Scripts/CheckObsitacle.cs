using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObsitacle : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform garbagePool;
    [SerializeField] private GameObject collectedObjController;
    
    [SerializeField] private GameObject player1Prefab;
    [SerializeField] private GameObject player2Prefab;
    [SerializeField] private GameObject player3Prefab;
    [SerializeField] private GameObject player4Prefab;
    void Start()
     {
         garbagePool = GameObject.Find("GarbagePool").transform;
           collectedObjController = GameObject.Find("CollectedObjController");
     }

    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Mop":
                other.collider.enabled = false;
                //animator.SetBool("isFallen", true);
                //this.GetComponentInParent<Transform>().parent = garbagePool;
                //collectedObjController.GetComponent<CollectedObjController>().playerAmount--;
                collectedObjController.GetComponent<CollectedObjController>().DestroyPlayer(animator);
                break;
            case "1Player":
                Destroy(other.gameObject);
                collectedObjController.GetComponent<CollectedObjController>().playerAmount += 1;
                collectedObjController.GetComponent<CollectedObjController>().SpawnPlayer(player1Prefab);
                break;
            case "2Player":
                Destroy(other.gameObject);
                collectedObjController.GetComponent<CollectedObjController>().playerAmount += 1;
                collectedObjController.GetComponent<CollectedObjController>().SpawnPlayer(player2Prefab);
                break;
            case "3Player":
                Destroy(other.gameObject);
                collectedObjController.GetComponent<CollectedObjController>().playerAmount += 1;
                collectedObjController.GetComponent<CollectedObjController>().SpawnPlayer(player3Prefab);
                break;
            case "4Player":
                Destroy(other.gameObject);
                collectedObjController.GetComponent<CollectedObjController>().playerAmount += 1;
                collectedObjController.GetComponent<CollectedObjController>().SpawnPlayer(player4Prefab);
                break;
            case "Player":
                break;
        }
    }

    
}

