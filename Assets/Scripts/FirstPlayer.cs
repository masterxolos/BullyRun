using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayer : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;

    private Rigidbody firstPlayer;
    

    void Start()
    {
        firstPlayer = GetComponent<Rigidbody>();
        //GetComponent<Renderer>().material = playerManager.collectedObjMat;

        //playerManager.collidedList.Add(gameObject);


    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Grounded();
        }
    }

    void Grounded()
    {
        //   isGrounded=true;
        playerManager.playerState = PlayerManager.PlayerState.Move;
       // firstPlayer.useGravity = false;
        //firstPlayer.constraints = RigidbodyConstraints.FreezeAll;

       // Destroy(this, 1);
    }
}
