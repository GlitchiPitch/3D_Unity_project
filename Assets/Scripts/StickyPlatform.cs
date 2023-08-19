using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision hitPart)
    {
        if (hitPart.gameObject.name == "Player")
        {
            hitPart.gameObject.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit(Collision hitPart)
    {
        if (hitPart.gameObject.name == "Player")
        {
            hitPart.gameObject.transform.SetParent(null);
        }
    }
}
