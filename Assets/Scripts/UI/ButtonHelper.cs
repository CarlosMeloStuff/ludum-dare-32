using UnityEngine;
using System.Collections;

public class ButtonHelper : MonoBehaviour 
{
	public void LoadScene(string scene)
    {
        Application.LoadLevel(scene);
    }
}
