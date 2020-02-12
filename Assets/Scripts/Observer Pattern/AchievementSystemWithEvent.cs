using System;
using UnityEngine;

public class AchievementSystemWithEvent : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();

        PointOfInterestWithEvent.OnPointOfInterestEntered += 
            PointOfInterestWithEvent_OnPointOfInterestEntered;

        PointOfInterestWithEvent.OnPointOfInterestEntered += 
            PointOfInterestWithEvent_OnPointOfInterestEntered02;

    }

    private void OnDestroy()
    {
        PointOfInterestWithEvent.OnPointOfInterestEntered -=
            PointOfInterestWithEvent_OnPointOfInterestEntered;

        PointOfInterestWithEvent.OnPointOfInterestEntered -=
            PointOfInterestWithEvent_OnPointOfInterestEntered02;
    }

    private void PointOfInterestWithEvent_OnPointOfInterestEntered02(PointOfInterestWithEvent obj)
    {
        Debug.Log("OMG! Is that a " + obj.PoiName + " reference!?!");
    }

    private void PointOfInterestWithEvent_OnPointOfInterestEntered(PointOfInterestWithEvent obj)
    {
        string achievementKey = "achievement_" + obj.PoiName;

        if (PlayerPrefs.GetInt(achievementKey) == 1)
        {
            return;
        }

        PlayerPrefs.SetInt(achievementKey, 1);
        Debug.Log("Unlocked " + obj.PoiName);
    }
}
    