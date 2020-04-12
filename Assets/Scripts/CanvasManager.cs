using Assets.Scripts.PersistentData;
using Assets.Scripts.UserSystem.GlobalData;
using PathCreation.PathFollower;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    public Dropdown UserDropDown;
    public InputField NewUserNameInput;
    public Text ScoreText;
    public Text LoggenInUser;
    public GameObject MainCamera;
    public GameObject SkinSelectionPanel;
    public GameObject RocketsCollection;
    public GameObject RocketParent;
    public GameObject RocketParentInGame;
    private List<int> rocketsIndexList;
    private string CurrentSkin = null;
    private int CurrentSkinIndexofIndex = -1;

    private void Awake() {
        GlobalData.SerialType = SerializationType.Binary;
    }

    void Start() {
        
        Initialize();
        SkinSelectionPanel.SetActive(false);
        RocketsCollection.SetActive(false);
        CurrentSkinInitilization();
    }

    public void CurrentSkinInitilization() {
        if (rocketsIndexList==null || rocketsIndexList.Count==0) {
            rocketsIndexList = new List<int>();
            LoadSkinList();
        }
        Transform temptra = RocketParent.transform.Find(GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).SkinSelected);
        GameObject temp = null;
        if (temptra != null) {
            temp = temptra.gameObject;
        }
        if (temp != null) {
            CurrentSkin = temp.name;
            int i = 0;
            foreach (Transform gm in RocketParent.transform) {
                if (gm.gameObject.name.Equals(CurrentSkin)) {
                    CurrentSkinIndexofIndex = rocketsIndexList.FindIndex(x => x == i);
                    print(rocketsIndexList[CurrentSkinIndexofIndex]);
                } 
                i++;
            }
        } else {
            CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[0]).name;
            CurrentSkinIndexofIndex = 0;
            GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).SkinSelected = CurrentSkin;
        }
        for(int j = 0;j < RocketParent.transform.childCount;j++) {
            RocketParent.transform.GetChild(j).gameObject.SetActive(false);
            RocketParentInGame.transform.GetChild(j).gameObject.SetActive(false);
        }
        RocketParent.transform.Find(CurrentSkin).gameObject.SetActive(true);
        RocketParentInGame.transform.Find(CurrentSkin).gameObject.SetActive(true);
    }

    public void SelectRocketOrUnlockIt() {
        //TODO the unlock part

        GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).SkinSelected = CurrentSkin;
    }

    public void EnableCameraPathFollower() {
        MainCamera.GetComponent<CameraPathFollower>().enabled = true;
    }

    public void Initialize() {
        GlobalData.SerialType = SerializationType.Binary;
        InitializeUserDropDown();
        UpdateSelectedUserInDropDown();
        ScoreText.text = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Score.ToString();
        LoggenInUser.text = GlobalData.UsersManager.LoggedInUser;
    }
    public void InitializeUserDropDown() {
        if (UserDropDown.options.Count != 0) {
            return;
        }
        Dropdown.OptionData optiondata;
        List<string> users = GlobalData.UsersManager.UsersNames;
        foreach (string user in users) {
            optiondata = new Dropdown.OptionData();
            optiondata.text = user;
            UserDropDown.options.Add(optiondata);
        }
    }

    public void UpdateSelectedUserInDropDown() {
        // returns a list of the text properties of the options
        List<string> listAvailableStrings = UserDropDown.options.Select(option => option.text).ToList();
        // returns the index of the given string
        UserDropDown.value = listAvailableStrings.IndexOf(GlobalData.UsersManager.LoggedInUser);

    }

    public void OnUserChanged() {
        GlobalData.UsersManager.LoggedInUser = GlobalData.UsersManager.UsersNames.Find(x => x.Equals(UserDropDown.options[UserDropDown.value].text));
        ScoreText.text = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser,GlobalData.SerialType).Score.ToString();
        LoggenInUser.text = GlobalData.UsersManager.LoggedInUser;
    }

    public void OnAddNewUser() {
        bool added = GlobalData.UsersManager.AddNewUser(NewUserNameInput.text, GlobalData.SerialType);
        if (!added) {
            print("USER NOT ADED");
            return;
        }

        string newuseradded = GlobalData.UsersManager.UsersNames.Find(x => x.Equals(NewUserNameInput.text));
        if (newuseradded == null) {
            print("PROBLEMAS");
            return;
        }
        NewUserNameInput.text = "";
        UserDropDown.options.Clear();

        UpdateSelectedUserInDropDown();

        GlobalData.SerializeAll();
        InitializeUserDropDown();
    }
    public void NextSkin() {
        if (CurrentSkinIndexofIndex < (rocketsIndexList.Count - 1)) {

            RocketProperties rockProp = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.GetComponent<RocketProperties>();
            float usersScore = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Score;
            if ((rockProp.PointsToUnlock < usersScore)) {
                RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.SetActive(true);

                RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.SetActive(true);

                CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.name;
                CurrentSkinIndexofIndex++;
                return;
            }

        }
        RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketParent.transform.GetChild(rocketsIndexList[0]).gameObject.SetActive(true);

        RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketParentInGame.transform.GetChild(rocketsIndexList[0]).gameObject.SetActive(true);

        CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[0]).gameObject.name;
        CurrentSkinIndexofIndex = 0;
    }

    public void PreviousSkin() {
        if (CurrentSkinIndexofIndex > 0) {

            RocketProperties rockProp = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.GetComponent<RocketProperties>();
            float usersScore = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Score;
            if ((rockProp.PointsToUnlock < usersScore)) {
                RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.SetActive(true);

                RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.SetActive(true);

                CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.name;
                CurrentSkinIndexofIndex--;
                return;
            }
        }
        RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        int i = 1;
        float point = RocketParent.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.GetComponent<RocketProperties>().PointsToUnlock;
        float playerpoints = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Score;
        while (point > playerpoints) {
            if (i == rocketsIndexList.Count) {
                break;
            }
            i++;
            point = RocketParent.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.GetComponent<RocketProperties>().PointsToUnlock;
        }
        RocketParentInGame.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.SetActive(true);
        RocketParent.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.SetActive(true);

        CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.name;
        CurrentSkinIndexofIndex = rocketsIndexList.Count - i;

    }

    public  void ActivateSkinSelection() {
        SkinSelectionPanel.SetActive(true);
        RocketsCollection.SetActive(true);
    }

    public void LoadSkinList() {
        for (int i = 0; i < RocketParent.transform.childCount; i++) {
            if (RocketParent.transform.GetChild(i).gameObject.name.Contains("ENEASRocket")) {
                rocketsIndexList.Add(i);
            }
        }
    }

    public void RefreshDetails() {
        ScoreText.text = "Πόντοι :" + GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Score + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
