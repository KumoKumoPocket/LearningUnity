using UnityEngine;

public class AchievementSystemWithEvent : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();

        PointOfInterestWithEvent.OnPointOfInterestEntered += 
            PointOfInterestWithEvent_OnPointOfInterestEntered;

    }

    private void PointOfInterestWithEvent_OnPointOfInterestEntered(PointOfInterestWithEvent value)
    {
        string achievementKey = "achievement_" + value.PoiName;

        if (PlayerPrefs.GetInt(achievementKey) == 1)
        {
            return;
        }

        PlayerPrefs.SetInt(achievementKey, 1);
        Debug.Log("Unlocked " + value.PoiName);
    }
}
    