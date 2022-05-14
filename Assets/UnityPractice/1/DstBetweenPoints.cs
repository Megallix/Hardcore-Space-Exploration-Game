using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DstBetweenPoints : MonoBehaviour
{
    int frameCount;

    // Start is called before the first frame update
    void Start()
    {
        print("Start");

        float dst = GetDistanceBetweenTwoPoints(0, 5, 10, 15);
        print(dst);
    }

    // Update is called once per frame
    void Update()
    {
        frameCount += 1;
        //print("Frame count: " + frameCount);
    }

    float GetDistanceBetweenTwoPoints(float x1, float y1, float x2, float y2)
    {
        float dX = x2 - x1;
        float dY = y2 - y1;
        float dstSquared = dX * dX + dY * dY;
        float dst = Mathf.Sqrt(dstSquared);
        return dst;
    }
}
