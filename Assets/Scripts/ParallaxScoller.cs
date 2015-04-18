using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ParallaxScoller : MonoBehaviour 
{
    private Player player;

    public float scaling = 1;
	
    private Vector3 startingPosition;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void Start()
    {
        startingPosition = transform.position;
    }

	void Update () 
    {
        transform.DOMoveX(startingPosition.x - player.distanceTravelled * scaling, .5f);
        //transform.localPosition = new Vector3(startingPosition.x - player.distanceTravelled, transform.localPosition.y, transform.localPosition.z);
	}
}
