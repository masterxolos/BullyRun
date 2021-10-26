using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using DG.Tweening;

public class CameraFollow : MonoBehaviour
{
    public GameObject CollectedObjController;
    [SerializeField] PlayerManager playerManager;
    [SerializeField] Transform camTransform;
    [SerializeField] int movementTime;
    [SerializeField] Ease camMovementEase;

    private CollectedObjController CollectedObjScript;

    public Transform target;
    [SerializeField, ReadOnly] private Vector3 offset;

    [SerializeField] float smoothSpeed;
    // private Vector3 offset = new Vector3(0, 10, 0);

    private bool moveTheCam = true;

    private bool everyoneJumped;
    private void Start()
    {
        CollectedObjScript = CollectedObjController.GetComponent<CollectedObjController>();
    }

    private void Update()
    {
        everyoneJumped = CollectedObjScript.getEveryoneJumpedValue();
        Debug.Log(everyoneJumped);
    }

    void LateUpdate()
    {

        //   offset = offset + new Vector3(0, 0, GameSettings.Instance().ZOffset); 
        if (moveTheCam)
        {
            if (playerManager.levelState == PlayerManager.LevelState.NotFinished)
            {
                Vector3 desiredPos = target.position + offset;
                Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
                transform.position = new Vector3(transform.position.x, transform.position.y, smoothedPos.z);
            }
        }
        if (everyoneJumped)
        {
            camTransform.DOMoveZ(380, movementTime);
            camTransform.DORotate(new Vector3(35, 0, 0), movementTime);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CamStopper"))
        {
            moveTheCam = false;
            camTransform.DOMoveY(45, movementTime);
            camTransform.DOMoveZ(320, movementTime);
            camTransform.DORotate(new Vector3(30,0,0),movementTime);
           // CollectedObjScript.ChangeAnimationsEndGame();
        }
    }
}
