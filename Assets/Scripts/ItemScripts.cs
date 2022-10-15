using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScripts : MonoBehaviour
{
    //トリガーの接触時によばれる
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"|| other.gameObject.tag == "Muteki")
        {
            Destroy(gameObject);
        }
    }
}