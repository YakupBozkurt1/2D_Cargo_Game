using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject myCar;
    void LateUpdate()
    {
        transform.position = myCar.transform.position + new Vector3(0, 0, -10);
    }
}
