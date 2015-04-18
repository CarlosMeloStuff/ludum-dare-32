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
    public float distanceTravelled = 0f;

    [SerializeField]
    private Transform signs;

    private string leftKey;
    private string rightKey;
    private string nextKey;

    private GameController gameController;

    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    private void Start()
    {
        leftKey = gameController.GetInputString();
        rightKey = gameController.GetInputString();
        nextKey = rightKey;

        leftInputText.text = leftKey;
        rightInputText.text = rightKey;
        leftInputText.color = new Color(1f, 1f, 1f, 0.5f);
        leftInputText.fontSize = 8;
        //leftInputText.enabled = false;
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
            if (nextKey == leftKey)
            {
                transform.DORotate(new Vector3(0, 0, 30f), bobSpeed);
                nextKey = rightKey;
                leftInputText.color = new Color(1f, 1f, 1f, 0.5f);
                rightInputText.color = new Color(1f, 1f, 1f, 1f);
                leftInputText.fontSize = 8;
                rightInputText.fontSize = 10;
            }
            else if (nextKey == rightKey)
            {
                transform.DORotate(new Vector3(0, 0, -30f), bobSpeed);
                nextKey = leftKey;
                rightInputText.color = new Color(1f, 1f, 1f, 0.5f);
                leftInputText.color = new Color(1f, 1f, 1f, 1f);
                rightInputText.fontSize = 8;
                leftInputText.fontSize = 10;
            }

            distanceTravelled++;
            signs.DOMoveX(-distanceTravelled, .5f);
        }
    }
}
