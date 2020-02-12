using System.Collections;
using System.Collections.Generic;
using Kumo;
using UnityEngine;

public class AchivementSystem : Observer
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        foreach (var poi in FindObjectsOfType<PointOfInterest>())
        {
            poi.RegisterObserver(this);
        }
    }

    public override void OnNotify(object value, NotificationType notificationType)
    {
        if(notificationType == NotificationType.ACHIVEMENT_ACHIEVED)
        {
            string achievementKey = "achievement_" + value;

            if(PlayerPrefs.GetInt(achievementKey) == 1)
            {
                return;
            }

            PlayerPrefs.SetInt(achievementKey, 1);
            Debug.Log("Unlocked " + value);
        }
    }

}
