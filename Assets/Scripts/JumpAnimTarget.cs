using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JumpAnimTarget : MonoBehaviour
{
    [SerializeField] private GameObject collectedObjController;
    private bool isPlayed = false;
    private void OnTriggerEnter(Collider other)
    {
        if (isPlayed == false)
        {
            collectedObjController.GetComponent<CollectedObjController>().Jump();
            isPlayed = true;
        }      
            
        
    }
}
