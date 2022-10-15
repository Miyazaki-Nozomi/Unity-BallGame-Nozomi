using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{
    // Start is called before the first frame update
    int _sceneIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(_sceneIndex);
        }
    }
}
