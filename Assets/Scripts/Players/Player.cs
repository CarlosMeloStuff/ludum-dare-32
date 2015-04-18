using UnityEngine;
using System.Collections;
using System;
using DG.Tweening;
using UnityEngine.UI;

public class Player : MonoBehaviour 
{
    [SerializeField]
    private float bobSpeed = 0.1f;

    [SerializeField]
    private Text leftInputText;

    [SerializeField]
    private Text rightInputText;

    [SerializeField]
    private float distanceTravelled = 0f;

    [SerializeField]
    private Transform signs;

    private string nextKey = "D";

    private void Start()
    {
        leftInputText.text = "A";
        rightInputText.text = "D";
        leftInputText.enabled = false;
    }

	void Update () 
    {
        CheckKeys();
	}

    private void CheckKeys()
    {
        KeyCode nextKeyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), nextKey);

        if (Input.GetKeyUp(nextKeyCode))
        {
            if (nextKeyCode == KeyCode.A)
            {
                transform.DORotate(new Vector3(0, 0, 30f), bobSpeed);
                nextKey = "D";
                leftInputText.enabled = false;
                rightInputText.enabled = true;
            }
            else if (nextKeyCode == KeyCode.D)
            {
                transform.DORotate(new Vector3(0, 0, -30f), bobSpeed);
                nextKey = "A";
                rightInputText.enabled = false;
                leftInputText.enabled = true;
            }

            distanceTravelled++;
            signs.DOMoveX(-distanceTravelled, .5f);
            //signs.localPosition = new Vector3(-distanceTravelled, signs.localPosition.y, signs.localPosition.z);
        }
    }
}
