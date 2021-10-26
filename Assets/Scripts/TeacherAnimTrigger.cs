using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherAnimTrigger : MonoBehaviour
{
    [SerializeField] private GameObject teacher;
    private void OnTriggerEnter(Collider other)
    { 
        teacher.GetComponent<Teacher>().TriggerAnim();
    }
}
