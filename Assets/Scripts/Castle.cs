using UnityEngine;
using System.Collections;

public class Castle : MonoBehaviour
 {
    private Animator animator;

    private Track track;

    private AudioSource audioSource;

    private bool destroyed = false;

	void Awake() 
    {
        animator = GetComponent<Animator>();
	    audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        track = transform.root.GetComponent<Track>();    
    }

	void Update () 
    {
        if (track.distanceTravelled >= GameController.TrackDistance && !destroyed)
        {
            animator.SetBool("Destroyed", true);
            audioSource.Play();
            destroyed = true;
        }
	}
}
