using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody = default;
    float x = default;
    float z = default;
    [SerializeField] float speed;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        MutekiOff();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(x, 0, z).normalized * speed);
    }

    void MtekiOn ()
    {
        this.tag = "Muteki";
    }

    void MutekiOff ()
    {
        this.tag = "Player";
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Muteki")
        {
            MtekiOn();
            Invoke(nameof(MutekiOff), 3.0f);
        }
        
    }
}