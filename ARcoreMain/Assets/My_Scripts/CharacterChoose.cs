using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class CharacterChoose : NetworkBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject network;
    public GameObject canvas;
    public void Bender()
    {
        network.GetComponent<NetworkManager>().playerPrefab = player1;
        canvas.gameObject.SetActive(false);
    }
    public void Dreyar()
    {
        network.GetComponent<NetworkManager>().playerPrefab = player2;
        canvas.gameObject.SetActive(false);
    }
    
}
