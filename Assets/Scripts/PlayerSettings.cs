using Assets.Scripts.PersistentData;
using Assets.Scripts.UserSystem.GlobalData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    public UsersManager  PlayerSettingsData = null;
    public Text userName;

    public string LogedInuserName;
    void Awake()
    {
        GlobalData.SerialType = SerializationType.Binary;
        PlayerSettingsData = GlobalData.UsersManager;
        userName.text = PlayerSettingsData.GetUserDetails(PlayerSettingsData.LoggedInUser,GlobalData.SerialType).Name.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
