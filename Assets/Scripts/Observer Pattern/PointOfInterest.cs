using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterest : Subject
{
    [SerializeField]
    private string poiName;

    private void OnTriggerEnter(Collider other)
    {
        Notify(poiName, Kumo.NotificationType.ACHIVEMENT_ACHIEVED);   
    }
}
