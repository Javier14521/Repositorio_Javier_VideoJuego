using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    private Rigidbody rig;
    [SerializeField] private float velocidad;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rig.AddForce(new Vector3(horizontal, 0, 0) * velocidad *  Time.deltaTime);
    }
}
