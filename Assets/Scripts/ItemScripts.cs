using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScripts : MonoBehaviour
{
    //ƒgƒŠƒK[‚ÌÚG‚É‚æ‚Î‚ê‚é
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"|| other.gameObject.tag == "Muteki")
        {
            Destroy(gameObject);
        }
    }
}