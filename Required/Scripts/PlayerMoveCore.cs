
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMoveCore : UdonSharpBehaviour
{
    Rigidbody rb;
    VRCPlayerApi local;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        local = Networking.LocalPlayer;
    }
    
    void Update()
    {
        local.TeleportTo(transform.position, transform.rotation);
    }

    public void AddForce(Vector3 force, ForceMode mode)
    {
        rb.AddForce(force, mode);
    }

    public void SetVelocity(Vector3 velocity)
    {
        rb.velocity = velocity;
    }
}
