using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    //wP = Waypoint

    public static Transform[] wP;

	// Use this for initialization
	void Awake () 
    {
        wP = new Transform[transform.childCount];
        for (int i = 0; i < wP.Length ; i++)
        {
            wP[i] = transform.GetChild(i);
        }
    }
}