using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    int count = 0;
    [SerializeField]Text _scoreLabel;
    [SerializeField] GameObject _WinneLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("Item").Length;
        _scoreLabel.text = count.ToString ();
        if(count == 0)
        {
            _WinneLabel.SetActive(true);
        }
    }
}
