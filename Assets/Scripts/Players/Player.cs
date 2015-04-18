using UnityEngine;
using System.Collections;
using System;
using DG.Tweening;

public class Player : MonoBehaviour 
{
    [SerializeField]
    private float bobSpeed = 0.1f;

    private KeyCode nextKey = KeyCode.A;

    private float lastKeyTime = 0;

	void Update () 
    {
        CheckKeys();
	}

    private void CheckKeys()
    {
        if (Input.GetKeyUp(nextKey))
        {
            if (nextKey == KeyCode.A)
            {
                transform.DORotate(new Vector3(0, 0, 45f), bobSpeed);
                nextKey = KeyCode.D;
            }
            else if (nextKey == KeyCode.D)
            {
                transform.DORotate(new Vector3(0, 0, -45f), bobSpeed);
                nextKey = KeyCode.A;
            }
        }
    }
}
