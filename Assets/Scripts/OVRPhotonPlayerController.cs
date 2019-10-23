using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[RequireComponent(typeof(PhotonView))]
public class OVRPhotonPlayerController : OVRPlayerController
{

    [Tooltip("PhotonView to ...")]
    public PhotonView photonView;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    override public void UpdateMovement()
    {
        if (photonView.IsMine)
        {
            base.UpdateMovement();
        }
        else {
            return;
        }
    }

}
