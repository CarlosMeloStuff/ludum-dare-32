using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SignContainer : MonoBehaviour 
{
    [SerializeField]
    private Transform sign;

	void Start () 
    {
	    for (int i = 0; i <= 500; i += 50)
        { 
            Transform newSign = Instantiate(sign, new Vector2(i, 0), Quaternion.identity) as Transform;

            newSign.GetComponent<Sign>().text = i.ToString() + "M";

            newSign.parent = transform;
        }
	}
}
