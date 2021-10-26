using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class CollectedObjController : MonoBehaviour
{
    [SerializeField] private PlayerManager _playerManager;
    [SerializeField] private Movement movement;
    [SerializeField] private GameObject sadCanvas;
    [SerializeField] private GameObject player1Prefab;
    [SerializeField] private GameObject player2Prefab;
    [SerializeField] private GameObject player3Prefab;
    [SerializeField] private GameObject player4Prefab;
    [SerializeField] private Transform location0;
    [SerializeField] private Transform location1;
    [SerializeField] private Transform location2;
    [SerializeField] private Transform location3;
    [SerializeField] private Transform location4;
    [SerializeField] private Transform location5;
    [SerializeField] private Transform location6;
    [SerializeField] private Transform location7;
    [SerializeField] private Transform location8;
    [SerializeField] private Transform location9;
    
    [SerializeField] private Transform prepLocations;
    [SerializeField] private Transform jumpLocations;
    //preplocations her katmanda bir tık sola gidecek
    [SerializeField] private Transform prepLocation0;
    [SerializeField] private Transform prepLocation1;
    [SerializeField] private Transform prepLocation2;
    [SerializeField] private Transform prepLocation3;
    [SerializeField] private Transform prepLocation4;
    [SerializeField] private Transform prepLocation5;
    [SerializeField] private Transform prepLocation6;
    [SerializeField] private Transform prepLocation7;
    [SerializeField] private Transform prepLocation8;
    [SerializeField] private Transform prepLocation9;
    
    [SerializeField] private Transform jumpLocation0;
    [SerializeField] private Transform jumpLocation1;
    [SerializeField] private Transform jumpLocation2;
    [SerializeField] private Transform jumpLocation3;
    [SerializeField] private Transform jumpLocation4;
    [SerializeField] private Transform jumpLocation5;
    [SerializeField] private Transform jumpLocation6;
    [SerializeField] private Transform jumpLocation7;
    [SerializeField] private Transform jumpLocation8;
    [SerializeField] private Transform jumpLocation9;

    [SerializeField] private Transform collectedPool;
    [SerializeField] private Transform garbagePool;
    [SerializeField] private Transform playerTransform;
    [SerializeField] public int playerAmount = 1;

    private bool isLocation0Available = false;
    private bool isLocation1Available = true;
    private bool isLocation2Available = true;
    private bool isLocation3Available = true;
    private bool isLocation4Available = true;
    private bool isLocation5Available = true;
    private bool isLocation6Available = true;
    private bool isLocation7Available = true;
    private bool isLocation8Available = true;
    private bool isLocation9Available = true;
    
    GameObject spawnedPlayer0 = null;
    GameObject spawnedPlayer1;
    GameObject spawnedPlayer2;
    GameObject spawnedPlayer3;
    GameObject spawnedPlayer4;
    GameObject spawnedPlayer5;
    GameObject spawnedPlayer6;
    GameObject spawnedPlayer7;
    GameObject spawnedPlayer8;
    GameObject spawnedPlayer9;

    //private Vector3 offset = new Vector3(0, 0, 0);
    /*BU BANA LAZIM OLAN BOOL DEĞERİ hepsi ya da herhangi biri atlayınca true olsun fark etmez.*/
    public bool everyoneJumped = false;
    //BOOL BİTTİ fonksiyonu 691. satırda.Bu arada 80. satırda değişken tanımladım bu nasıl kod wııfkpowkfowekfweo.

  

    private void Start()
    {
        spawnedPlayer0 = playerTransform.gameObject;
    }

    public void SpawnPlayer(GameObject playerPrefab)
    {
        Vector3 tempPlayerPosition = playerTransform.position;
        Debug.Log(playerAmount);

        if (isLocation0Available)
        {
            spawnedPlayer0=Instantiate(playerPrefab, location0.position, Quaternion.identity, collectedPool);
            spawnedPlayer0.tag = "Player";
            isLocation0Available = false;
            Debug.Log("Player");
        }
        
        else if (isLocation1Available)
        {
            spawnedPlayer1 = Instantiate(playerPrefab, location1.position, Quaternion.identity, collectedPool);
            spawnedPlayer1.tag = "spawned1";
            isLocation1Available = false;
            Debug.Log("spawned1");
        }

        else if (isLocation2Available)
        {
            spawnedPlayer2= Instantiate(playerPrefab, location2.position, Quaternion.identity,collectedPool);
            spawnedPlayer2.tag = "spawned2";
            isLocation2Available = false;
            Debug.Log("spawned2");
        }

        else if (isLocation3Available)
        {
            spawnedPlayer3= Instantiate(playerPrefab, location3.position, Quaternion.identity,collectedPool);
            spawnedPlayer3.tag = "spawned3";
            isLocation3Available = false;   
            Debug.Log("spawned3");
        }

        else if (isLocation4Available)
        {
            spawnedPlayer4= Instantiate(playerPrefab, location4.position, Quaternion.identity,collectedPool);
            spawnedPlayer4.tag = "spawned4";
            isLocation4Available = false;
            Debug.Log("spawned4");
        }

        else if (isLocation5Available)
        {
            spawnedPlayer5= Instantiate(playerPrefab, location5.position, Quaternion.identity,collectedPool);
            spawnedPlayer5.tag = "spawned5";
            isLocation5Available = false;
            Debug.Log("spawned5");
        }
        else if (isLocation6Available)
        {
            spawnedPlayer6= Instantiate(playerPrefab, location6.position, Quaternion.identity,collectedPool);
            spawnedPlayer6.tag = "spawned6";
            isLocation6Available = false;
            Debug.Log("spawned6");
        }
        else if (isLocation7Available)
        {
            spawnedPlayer7= Instantiate(playerPrefab, location7.position, Quaternion.identity,collectedPool);
            spawnedPlayer7.tag = "spawned7";
            isLocation7Available = false;
            Debug.Log("spawned7");
        }
        else if (isLocation8Available)
        {
            spawnedPlayer8= Instantiate(playerPrefab, location8.position, Quaternion.identity,collectedPool);
            spawnedPlayer8.tag = "spawned8";
            isLocation8Available = false;
            Debug.Log("spawned8");
        }
        else if (isLocation9Available)
        {
            spawnedPlayer9= Instantiate(playerPrefab, location9.position, Quaternion.identity,collectedPool);
            spawnedPlayer9.tag = "spawned9";
            isLocation9Available = false;
            Debug.Log("spawned9");
        }
    }
    
    public void DestroyPlayer(Animator animator)
    {
        switch (animator.gameObject.tag)
        {
            case "Player":
                if (playerTransform.gameObject != null)
                {
                    playerTransform.GetComponent<Animator>().SetBool("isFallen", true);
                    playerTransform.parent = garbagePool;
                    playerAmount--;
                    isLocation0Available = true;
                }

                break;
            case "spawned1":
                if (spawnedPlayer1 != null)
                {
                    spawnedPlayer1.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer1.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation1Available = true;
                }
                break;
            case "spawned2":
                if (spawnedPlayer2 != null)
                {
                    spawnedPlayer2.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer2.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation2Available = true;
                }
                break;
            case "spawned3":    
                if (spawnedPlayer3 != null)
                {
                    spawnedPlayer3.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer3.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation3Available = true;
                }

                break;
            case "spawned4":
                if (spawnedPlayer4 != null)
                {
                    spawnedPlayer4.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer4.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation4Available = true;
                }

                break;
            case "spawned5":
                if (spawnedPlayer5 != null)
                {
                    spawnedPlayer5.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer5.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation5Available = true;
                }
                break;
            case "spawned6":
                if (spawnedPlayer6 != null)
                {
                    spawnedPlayer6.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer6.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation6Available = true;
                }
                break;
            case "spawned7":
                if (spawnedPlayer7 != null)
                {
                    spawnedPlayer7.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer7.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation7Available = true;
                }
                break;
            case "spawned8":
                if (8 != null)
                {
                    spawnedPlayer8.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer8.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation8Available = true;
                }
                break;
            case "spawned9":
                if (spawnedPlayer9 != null)
                {
                    spawnedPlayer9.GetComponent<Animator>().SetBool("isFallen", true);
                    spawnedPlayer9.transform.parent = garbagePool;
                    playerAmount--;
                    isLocation9Available = true;
                }
                break;
        }

        if (playerAmount == 0)
        {
            sadCanvas.SetActive(true);
            movement.enabled = false;
        }
    }

    public void Jump()
    {
        movement.enabled = false;
        ChangeAnimationsEndGame();
        void player0()
        {
            if (spawnedPlayer0 != null)
            {
                spawnedPlayer0.GetComponent<Animator>().enabled = false;
                spawnedPlayer0.transform.localPosition = prepLocation0.localPosition;
                spawnedPlayer0.GetComponent<Rigidbody>().useGravity = false;
                spawnedPlayer0.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll; 
            }
            else
            {
                playerTransform.GetComponent<Animator>().enabled = false;
                playerTransform.localPosition = prepLocation0.localPosition;
                playerTransform.GetComponent<Rigidbody>().useGravity = false;
                playerTransform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            }
        }

        void player1()
        {
            spawnedPlayer1.GetComponent<Animator>().enabled = false;
            spawnedPlayer1.transform.localPosition = prepLocation1.localPosition;
            spawnedPlayer1.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }

        void player2()
        {
            spawnedPlayer2.transform.DOLocalMove(prepLocation3.localPosition,0.8f);
            spawnedPlayer2.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }

        void player3()
        {
            spawnedPlayer3.GetComponent<Animator>().enabled = false;
            spawnedPlayer3.transform.DOLocalMove(prepLocation6.localPosition,0.8f);
            spawnedPlayer3.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        
        void player4()
        {
            spawnedPlayer4.GetComponent<Animator>().SetBool("doBackFlip", true);
            spawnedPlayer4.transform.DOLocalMove(prepLocation2.localPosition,0.8f);
            spawnedPlayer4.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }

        void player5()
        {
            spawnedPlayer5.GetComponent<Animator>().SetBool("doBackFlip", true);
            spawnedPlayer5.transform.DOLocalMove(prepLocation4.localPosition, 0.8f);
            spawnedPlayer5.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer5.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }

        void player6()
        {
            spawnedPlayer6.GetComponent<Animator>().SetBool("doBackFlip", true);
            spawnedPlayer6.transform.DOLocalMove(prepLocation7.localPosition,0.8f);
            spawnedPlayer6.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer6.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        
        void player7()
        {
            spawnedPlayer7.GetComponent<Animator>().SetBool("doBackFlip", true);
            spawnedPlayer7.transform.DOLocalMove(prepLocation5.localPosition,0.8f);
            spawnedPlayer7.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer7.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        
        void player8()
        {
            spawnedPlayer8.GetComponent<Animator>().SetBool("doBackFlip", true);
            spawnedPlayer8.transform.DOLocalMove(prepLocation8.localPosition, 0.8f);
            spawnedPlayer8.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer8.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        
        void player9()
        {
            spawnedPlayer9.GetComponent<Animator>().SetBool("doBackFlip", true);
            spawnedPlayer9.transform.DOLocalMove(prepLocation9.localPosition, 0.8f);
            spawnedPlayer9.GetComponent<Rigidbody>().useGravity = false;
            spawnedPlayer9.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        
        void LocationsToLeft()
        {
            prepLocations.localPosition = (prepLocations.localPosition + new Vector3(0, -12, 0));
            jumpLocations.localPosition = (jumpLocations.localPosition + new Vector3(0, -12, 0));
            
        }
        
        IEnumerator JumpAnimations()
        {
            if (playerAmount == 1)
            {
                player0();
            }

            if (playerAmount == 2)
            {
                player0();
                player1();
            }

            if (playerAmount == 3)
            {
                player0();
                player1();
                yield return new WaitForSeconds(0.8f);
                player2();
            }

            if (playerAmount == 4)
            {
                player0();
                player1();
                player3();
                yield return new WaitForSeconds(0.8f);
                player2();
                
            }

            if (playerAmount == 5)
            {
                player0();
                player1();
                player3();
                yield return new WaitForSeconds(0.8f);
                player2();
                player4();
            }

            if (playerAmount == 6)
            {
                player0();
                player1();
                player3();
                yield return new WaitForSeconds(0.8f);
                player2();
                player4();
                yield return new WaitForSeconds(0.8f);
                player5();
            }
            
            if (playerAmount == 7)
            {
                player0();
                player1();
                player3();
                player6();
                yield return new WaitForSeconds(0.8f);
                player2();
                player4();
                yield return new WaitForSeconds(0.8f);
                player5();
            }
            
            if (playerAmount == 8)
            {
                player0();
                player1();
                player3();
                player6();
                yield return new WaitForSeconds(0.8f);
                player2();
                player4();
                player7();
                yield return new WaitForSeconds(0.8f);
                player5();
            }
            if (playerAmount == 9)
            {
                player0();
                player1();
                player3();
                player6();
                yield return new WaitForSeconds(0.8f);
                player2();
                player4();
                player7();
                yield return new WaitForSeconds(0.8f);
                player5();
                player8();
            }
            if (playerAmount == 10)
            {
                player0();
                player1();
                player2();
                player3();
                yield return new WaitForSeconds(0.8f);
                player4();
                player5();
                player6();
                yield return new WaitForSeconds(0.8f);
                player7();
                player8();
                yield return new WaitForSeconds(0.8f);
                player9();
            }

            yield return new WaitForSeconds(1.5f);
            Jump2();
        }

        

        StartCoroutine(JumpAnimations());
        /*
         switch (playerAmount)
         {
             case 1:
                 playerTransform.GetComponent<Animator>().enabled = false;
                 playerTransform.localPosition= (new Vector3(0, 0, 0));
                 playerTransform.GetComponent<Rigidbody>().useGravity = false;
                 playerTransform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                 break;
             case 2:
                 playerTransform.GetComponent<Animator>().enabled = false;
                 playerTransform.localPosition= (new Vector3(0, 0, 0));
                 playerTransform.GetComponent<Rigidbody>().useGravity = false;
                 playerTransform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                 
                 spawnedPlayer1.GetComponent<Animator>().enabled = false;
                 spawnedPlayer1.transform.localPosition= new Vector3(2, 0, 0);
                 spawnedPlayer1.GetComponent<Rigidbody>().useGravity = false;
                 spawnedPlayer1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                 break;
             case 3:
                 playerTransform.GetComponent<Animator>().enabled = false;
                 playerTransform.localPosition= (new Vector3(0, 0, 0));
                 playerTransform.GetComponent<Rigidbody>().useGravity = false;
                 playerTransform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                 
                 spawnedPlayer1.GetComponent<Animator>().enabled = false;
                 spawnedPlayer1.transform.localPosition= new Vector3(2, 0, 0);
                 spawnedPlayer1.GetComponent<Rigidbody>().useGravity = false;
                 spawnedPlayer1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                 
                 spawnedPlayer2.GetComponent<Animator>().enabled = false;
                 spawnedPlayer2.transform.localPosition = new Vector3(0.5f, 6, 0);
                 spawnedPlayer2.GetComponent<Rigidbody>().useGravity = false;
                 spawnedPlayer2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                 break;
             case 6:
                 
                 StartCoroutine(WaitForAnimation());
 
                 break;
         }
     */

    }
    public void Jump2()
    {
        StartCoroutine(jumpThroughtWall());
        void Player0()
        {
            if (spawnedPlayer0 != null)
            {
                spawnedPlayer0.GetComponent<Animator>().Play("backflip", 0, 0);
                spawnedPlayer0.transform.DOLocalMove(jumpLocation0.localPosition, 0.8f);
                spawnedPlayer0.transform.Rotate(new Vector3(0, 180, 0));
                spawnedPlayer0.GetComponent<Collider>().enabled = false;
                //spawnedPlayer0.transform.DOScale(6, 0);   
            }
            else
            {
                playerTransform.GetComponent<Animator>().Play("backflip", 0, 0);
                playerTransform.transform.DOLocalMove(jumpLocation0.localPosition, 0.8f);
                playerTransform.transform.Rotate(new Vector3(0, 180, 0));
                playerTransform.GetComponent<Collider>().enabled = false;
                //layerTransform.transform.DOScale(6, 0);   
            }
        }      
        void Player1()
        {
            spawnedPlayer1.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer1.transform.DOLocalMove(jumpLocation1.localPosition, 0.8f);
            spawnedPlayer1.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer1.GetComponent<Collider>().enabled = false;
            //spawnedPlayer1.transform.DOScale(6, 0);   
        }
        void Player2()
        {
            spawnedPlayer2.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer2.transform.DOLocalMove(jumpLocation3.localPosition, 0.8f);
            spawnedPlayer2.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer2.GetComponent<Collider>().enabled = false;
            //spawnedPlayer2.transform.DOScale(6, 0);   
        }
        void Player3()
        {
            spawnedPlayer3.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer3.transform.DOLocalMove(jumpLocation6.localPosition, 0.8f);
            spawnedPlayer3.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer3.GetComponent<Collider>().enabled = false;
            //spawnedPlayer3.transform.DOScale(6, 0);   
        }
        void Player4()
        {
            spawnedPlayer4.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer4.transform.DOLocalMove(jumpLocation2.localPosition, 0.8f);
            spawnedPlayer4.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer4.GetComponent<Collider>().enabled = false;
            //spawnedPlayer4.transform.DOScale(6, 0);   
        }
        void Player5()
        {
            spawnedPlayer5.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer5.transform.DOLocalMove(jumpLocation4.localPosition, 0.8f);
            spawnedPlayer5.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer5.GetComponent<Collider>().enabled = false;
            //spawnedPlayer5.transform.DOScale(6, 0);   
        }
        void Player6()
        {
            spawnedPlayer6.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer6.transform.DOLocalMove(jumpLocation7.localPosition, 0.8f);
            spawnedPlayer6.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer6.GetComponent<Collider>().enabled = false;
            //spawnedPlayer6.transform.DOScale(6, 0);   
        }
        void Player7()
        {
            spawnedPlayer7.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer7.transform.DOLocalMove(jumpLocation5.localPosition, 0.8f);
            spawnedPlayer7.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer7.GetComponent<Collider>().enabled = false;
            //spawnedPlayer7.transform.DOScale(6, 0);   
        }
        void Player8()
        {
            spawnedPlayer8.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer8.transform.DOLocalMove(jumpLocation8.localPosition, 0.8f);
            spawnedPlayer8.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer8.GetComponent<Collider>().enabled = false;
            //spawnedPlayer8.transform.DOScale(6, 0);   
        }
        void Player9()
        {
            spawnedPlayer9.GetComponent<Animator>().Play("backflip",0,0);
            spawnedPlayer9.transform.DOLocalMove(jumpLocation9.localPosition, 0.8f);
            spawnedPlayer9.transform.Rotate(new Vector3(0,180,0));
            spawnedPlayer9.GetComponent<Collider>().enabled = false;
            //spawnedPlayer9.transform.DOScale(6, 0);   
        }
        
        IEnumerator jumpThroughtWall()
        {
            if (playerAmount == 1)
            {
                Player0();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 2)
            {
                Player0();
                Player1();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 3)
            {
                Player2();
                yield return new WaitForSeconds(0.8f);
                Player0();
                Player1();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 4)
            {
                Player2();
                yield return new WaitForSeconds(0.8f);
                Player0();
                Player1();
                Player3();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 5)
            {
                Player2();
                Player4();
                yield return new WaitForSeconds(0.8f);
                Player0();
                Player1();
                Player3();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 6)
            {
                Player5();
                yield return new WaitForSeconds(0.8f);
                Player2();
                Player4();
                yield return new WaitForSeconds(0.8f);
                Player0();
                Player1();
                Player3();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 7)
            {
                Player5();
                yield return new WaitForSeconds(0.8f);
                Player2();
                Player4();
                yield return new WaitForSeconds(0.8f);
                Player0();
                Player1();
                Player3();
                Player6();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 8)
            {
                Player5();
                yield return new WaitForSeconds(0.8f);
                Player2();
                Player4();
                Player7();
                yield return new WaitForSeconds(0.8f);
                Player0();
                Player1();
                Player3();
                Player6();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 9)
            {
                Player5();
                Player8();
                yield return new WaitForSeconds(0.8f);
                Player2();
                Player4();
                Player7();
                yield return new WaitForSeconds(0.8f);
                Player0();
                Player1();
                Player3();
                Player6();
                everyoneJumped = true;
                yield break;
            }
            if (playerAmount == 10)
            {
                Player9();
                yield return new WaitForSeconds(0.8f);
                Player8();
                Player7();
                yield return new WaitForSeconds(0.8f);
                Player6();
                Player5();
                Player4();
                yield return new WaitForSeconds(0.8f);
                Player3();
                Player2();
                Player1();
                Player0();
                everyoneJumped = true;
                StopCoroutine(jumpThroughtWall());
            }

            
            Debug.Log(everyoneJumped);
        }
    }


    public void ChangeAnimationsEndGame()
    {
        if (spawnedPlayer0 != null)
            spawnedPlayer0.GetComponent<Animator>().SetBool("pose", true);
        if (playerTransform != null)
            playerTransform.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer1 !=null)
            spawnedPlayer1.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer2 !=null)
            spawnedPlayer2.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer3 !=null)
            spawnedPlayer3.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer4 !=null)
            spawnedPlayer4.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer5 !=null)
            spawnedPlayer5.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer6 != null)
            spawnedPlayer6.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer7 != null)
            spawnedPlayer7.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer8 != null)
            spawnedPlayer8.GetComponent<Animator>().SetBool("pose", true);
        if (spawnedPlayer9 != null)
            spawnedPlayer9.GetComponent<Animator>().SetBool("pose", true);

        

    }
    //Bu o fonksiyon bana lazım olan.
    public bool getEveryoneJumpedValue()
    {
        return everyoneJumped;
    }
    /*
    IEnumerator WaitForAnimation()
    {
        playerTransform.GetComponent<Animator>().enabled = false;
        playerTransform.localPosition= (new Vector3(0, -2.23f, -2.3f));
        playerTransform.GetComponent<Rigidbody>().useGravity = false;
        playerTransform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        spawnedPlayer1.GetComponent<Animator>().enabled = false;
        spawnedPlayer1.transform.localPosition= new Vector3(2, -2.23f,  -2.3f);
        spawnedPlayer1.GetComponent<Rigidbody>().useGravity = false;
        spawnedPlayer1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                
        spawnedPlayer2.GetComponent<Animator>().enabled = false;
        spawnedPlayer2.transform.localPosition = new Vector3(-2, -2.23f,  -2.3f);
        spawnedPlayer2.GetComponent<Rigidbody>().useGravity = false;
        spawnedPlayer2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        
        
        //spawnedPlayer3.transform.localPosition = new Vector3(1, 0 - 2.23f, -8);
        spawnedPlayer3.GetComponent<Rigidbody>().useGravity = false;
        spawnedPlayer3.GetComponent<Animator>().SetBool("doBackFlip", true);
        spawnedPlayer3.transform.DOLocalMove(new Vector3(1, 6 - 2.23f, 0),0.8f);
        spawnedPlayer3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        //spawnedPlayer4.transform.localPosition = new Vector3(-1, 6-2.23f, -8);
        spawnedPlayer4.GetComponent<Rigidbody>().useGravity = false;
        spawnedPlayer4.GetComponent<Animator>().SetBool("doBackFlip", true);
        spawnedPlayer4.transform.DOLocalMove(new Vector3(-1, 6 - 2.23f, 0), 0.8f);
        spawnedPlayer4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        
        
        yield return new WaitForSeconds(0.6f);
        //spawnedPlayer5.transform.localPosition = new Vector3(0, 0, -13);
        spawnedPlayer5.GetComponent<Rigidbody>().useGravity = false;
        spawnedPlayer5.GetComponent<Animator>().SetBool("doBackFlip", true);
        yield return new WaitForSeconds(0.3f);
        spawnedPlayer5.transform.DOLocalMove(new Vector3(0, 12 - 2.23f, 0), 1);
        spawnedPlayer5.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        StartCoroutine(JumpAnimation());
    }

    IEnumerator JumpAnimation()
    {
        yield return new WaitForSeconds(1);
        spawnedPlayer5.GetComponent<Animator>().Play("backflip",0,0);
        spawnedPlayer5.transform.DOLocalMove(new Vector3(0, 0, 35), 1);
        spawnedPlayer5.transform.Rotate(new Vector3(0,180,0));
        spawnedPlayer5.transform.DOScale(5, 1);
        yield return new WaitForSeconds(0.6f);
        
        spawnedPlayer4.GetComponent<Animator>().Play("backflip",0,0);
        spawnedPlayer4.transform.DOLocalMove(new Vector3(-1.5f, 0.5f, 70), 1);
        spawnedPlayer4.transform.Rotate(new Vector3(0,180,0));
        spawnedPlayer4.transform.DOScale(6, 1);
        
        spawnedPlayer3.GetComponent<Animator>().Play("backflip",0,0);
        spawnedPlayer3.transform.DOLocalMove(new Vector3(0.5f, 0.5f, 70), 1);
        spawnedPlayer3.transform.Rotate(new Vector3(0,180,0));
        spawnedPlayer3.transform.DOScale(6, 1);
        yield return new WaitForSeconds(0.6f);
        
        spawnedPlayer2.GetComponent<Animator>().Play("backflip",0,0);
        spawnedPlayer2.transform.DOLocalMove(new Vector3(-1.5f, 0.7f, 110), 1);
        spawnedPlayer2.transform.Rotate(new Vector3(0,180,0));
        spawnedPlayer2.transform.DOScale(7, 1);
        
        spawnedPlayer1.GetComponent<Animator>().Play("backflip",0,0);
        spawnedPlayer1.transform.DOLocalMove(new Vector3(0.5f, 0.7f, 110), 1);
        spawnedPlayer1.transform.Rotate(new Vector3(0,180,0));
        spawnedPlayer1.transform.DOScale(7, 1);
        
        playerTransform.GetComponent<Animator>().Play("backflip",0,0);
        playerTransform.transform.DOLocalMove(new Vector3(2.5f, 0.7f, 110), 1);
        playerTransform.transform.Rotate(new Vector3(0,180,0));
        playerTransform.transform.DOScale(7, 1);
    }
    */
}


