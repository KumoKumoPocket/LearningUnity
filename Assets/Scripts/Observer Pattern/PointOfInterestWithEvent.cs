using System;
using UnityEngine;

public class PointOfInterestWithEvent : MonoBehaviour
{
    public static event Action<PointOfInterestWithEvent> OnPointOfInterestEntered;

    [SerializeField]
    private string _poiName;

    public string PoiName { get { return _poiName; } }

    private void OnTriggerEnter(Collider other)
    {
        if(OnPointOfInterestEntered != null && other.gameObject.tag == "RealPlayer")
        {
            OnPointOfInterestEntered(this);
        }
    }
}
