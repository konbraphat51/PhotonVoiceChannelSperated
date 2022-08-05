using UnityEngine;
using System.Collections;
using Photon.Pun;
using Photon.Realtime;

public class PunManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.NetworkClientState.ToString());
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions(), TypedLobby.Default);
    }

    //ÉãÅ[ÉÄÇ…ì¸é∫å„Ç…åƒÇ—èoÇ≥ÇÍÇÈ
    public override void OnJoinedRoom()
    {
        GameObject player = PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity, 0);

        Player playerScript = player.GetComponent<Player>();
        playerScript.enabled = true;
        playerScript.Init();
    }
}