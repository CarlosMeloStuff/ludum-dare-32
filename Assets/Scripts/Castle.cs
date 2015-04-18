using UnityEngine;
using System.Collections;

public class Castle : MonoBehaviour
 {
    private Animator animator;

    private Track track;

	void Awake() 
    {
        animator = GetComponent<Animator>();
	}

    void Start()
    {
        track = transform.root.GetComponent<Track>();    
    }

	void Update () 
    {
        if (track.distanceTravelled >= GameController.TrackDistance)
        {
            animator.SetBool("Destroyed", true);
        }
	}
}
