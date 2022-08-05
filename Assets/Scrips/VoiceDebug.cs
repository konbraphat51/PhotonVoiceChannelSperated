using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Voice.PUN;
using Photon.Voice.Unity;

public class VoiceDebug : MonoBehaviour
{
    PhotonVoiceNetwork voiceNetwork;
    Recorder recorder;
    // Start is called before the first frame update
    void Start()
    {
        voiceNetwork = GetComponent<PhotonVoiceNetwork>();
        recorder = GetComponent<Recorder>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            byte[] remove = new byte[] { 0,2 };
            byte[] add = new byte[] { 1 };
            voiceNetwork.Client.OpChangeGroups(remove, add);
            recorder.InterestGroup = 1;
            Debug.Log(1);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            byte[] remove = new byte[] { 0,1 };
            byte[] add = new byte[] { 2 };
            voiceNetwork.Client.OpChangeGroups(remove, add);
            recorder.InterestGroup = 2;
            Debug.Log(2);
        }
    }
}
