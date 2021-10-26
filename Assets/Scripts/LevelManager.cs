using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tabtale.TTPlugins;

public class LevelManager : MonoBehaviour
{
    public GameObject CollectedObjController;
    private bool everyoneJumped;
    private CollectedObjController CollectedObjScript;

    [SerializeField] private GameObject endGameCanvas;
    private void Start()
    {
        CollectedObjScript = CollectedObjController.GetComponent<CollectedObjController>();
    }

    void Update()
    {
        everyoneJumped = CollectedObjScript.getEveryoneJumpedValue();

        Debug.Log(everyoneJumped);
        if (everyoneJumped)
        {
            StartCoroutine(waitForSceneLoading());
            
        }
        
    }
    private void Awake()
    
    {
    
    	// Initialize CLIK
    
    	TTPCore.Setup();
    
    	// Your code here
    
    }

    IEnumerator waitForSceneLoading()
    {
        yield return new WaitForSeconds(5);
        endGameCanvas.SetActive(true);
        
    }
}
