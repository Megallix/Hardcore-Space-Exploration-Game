using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty7
{
    static float secondsToMaxDifficulty = 60;

    public static float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }

}
