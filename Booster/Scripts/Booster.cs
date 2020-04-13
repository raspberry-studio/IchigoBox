
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Booster : UdonSharpBehaviour
{
    VRCPlayerApi local;
    GameObject common;
    PlayerMoveCore playerMoveCore;
    bool boost;

    [SerializeField]
    float boostPower = 4.0f;

    [SerializeField]
    ForceMode forceMode = ForceMode.Acceleration;

    void Start()
    {
        local = Networking.LocalPlayer;
        common = GameObject.Find("[IchigoCommon]");
        playerMoveCore = common.GetComponentInChildren<PlayerMoveCore>();
    }

    public override void OnPickupUseDown()
    {
        boost = true;
    }

    public override void OnPickupUseUp()
    {
        boost = true;
    }

    private void FixedUpdate()
    {
        playerMoveCore.AddForce(transform.forward * boostPower, forceMode);
    }
}
