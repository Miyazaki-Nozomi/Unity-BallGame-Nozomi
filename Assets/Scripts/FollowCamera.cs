using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform _target=default;
    private Vector3 _offset;
    void Start()
    {
        _offset = this.transform.position - _target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(_target)
        {
            this.transform.position = _target.position + _offset;
        }
    }
}
