using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BushesContainer : MonoBehaviour 
{
    [SerializeField]
    private Transform foregroundBushes;

    [SerializeField]
    private Transform backgroundBushes;

    private void Start()
    {
        for (int i = -32; i <= 640; i += 32)
        {
            Transform newSign = Instantiate(foregroundBushes, new Vector2(i, 0), Quaternion.identity) as Transform;
            newSign.parent = transform;
        }

        for (int i = -32; i <= 640; i += 32)
        {
            Transform newSign = Instantiate(backgroundBushes, new Vector2(i - 0.5f, 0.1f), Quaternion.identity) as Transform;
            newSign.parent = transform;
        }
    }
}
