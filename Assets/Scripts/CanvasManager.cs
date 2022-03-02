using Assets.Scripts.PersistentData;
using Assets.Scripts.UserSystem.GlobalData;
using PathCreation.PathFollower;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour 
{

    public TMP_Dropdown UserDropDown;
    public TMP_InputField NewUserNameInput;
    public TMP_Text ScoreText;
    public TMP_Text LoggenInUser;
    public TMP_Text ScoreText_UnlockPanel;
    public TMP_Text YourScore_UnlockPanel;
    public TMP_Text MessageForUnlock;
    public GameObject MainCamera;

    public GameObject SkinSelectionPanel;
    public GameObject OnLosePanel;
    public GameObject MainMenuPanel;
    public GameObject GamePlayPanel;

    public GameObject RocketsCollection;
    public GameObject RocketsParentToUnlock;
    public GameObject RocketsParentInGame;
    public GameObject[] ChapterSelectionToggles;
    public static PanelState panelState;

    public SerializationType SerializationType;

    private List<int> rocketsIndexList;
    private string CurrentSkin = null;
    private int CurrentSkinIndexofIndex = -1;
    private User currentUser;
    



    #region INITIALIZATION
    private void Awake()
    {
        GlobalData.SerialType = SerializationType;
        currentUser = GlobalData.UsersManager.GetUser(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType);
        Enums.CrashStateChanged += Enums_CrashStateChanged;
    }

    private void Enums_CrashStateChanged(CrashState obj)
    {
        Invoke("LoadOnLosePanel", 2f);
    }

    private void LoadOnLosePanel()
    {
        OnLosePanel.SetActive(true);
    }

    //Remove the method from the list o events subscribed to CrashStateChanged
    //when the game shuts down or switches to another Scene
    void OnDestroy()
    {
        Debug.Log("OnDestroyCanvasManager");
        Enums.CrashStateChanged -= Enums_CrashStateChanged;
    }

    void Start() {
        
        Initialize();
        SkinSelectionPanel.SetActive(false);
        RocketsCollection.SetActive(false);
        if (panelState == PanelState.InGameMenu) {
            MainMenuPanel.SetActive(false);
            GamePlayPanel.SetActive(true);
            panelState = PanelState.InMainMenu;
        }
        CurrentSkinInitilization();
        YourScore_UnlockPanel.text = YourScore_UnlockPanel.text+ currentUser.Score.ToString();
    }

    private void Initialize()
    {
        InitializeUserDropDown();
        UpdateSelectedUserInDropDown();
        BindToggles();
        BindTogglesWithProblems();
        ScoreText.text = currentUser.Score.ToString();
        LoggenInUser.text = GlobalData.UsersManager.LoggedInUser;
    }

    private void InitializeUserDropDown()
    {
        if (UserDropDown.options.Count != 0)
        {
            return;
        }
        TMP_Dropdown.OptionData optiondata;
        List<string> users = GlobalData.UsersManager.UsersNames;
        foreach (string user in users)
        {
            optiondata = new TMP_Dropdown.OptionData();
            optiondata.text = user;
            UserDropDown.options.Add(optiondata);
        }
    }

    public void CurrentSkinInitilization()
    {
        if (rocketsIndexList == null || rocketsIndexList.Count == 0)
        {
            rocketsIndexList = new List<int>();
            LoadSkinList();
        }
        Transform temptra = RocketsParentToUnlock.transform.Find(currentUser.SkinSelected);
        GameObject temp = null;
        if (temptra != null)
        {
            temp = temptra.gameObject;
        }
        if (temp != null)
        {
            CurrentSkin = temp.name;
            int i = 0;
            foreach (Transform gm in RocketsParentToUnlock.transform)
            {
                if (gm.gameObject.name.Equals(CurrentSkin))
                {
                    CurrentSkinIndexofIndex = rocketsIndexList.FindIndex(x => x == i);
                    //print(rocketsIndexList[CurrentSkinIndexofIndex]);
                }
                i++;
            }
        }
        else
        {
            CurrentSkin = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[0]).name;
            CurrentSkinIndexofIndex = 0;
            currentUser.SkinSelected = CurrentSkin;
        }
        for (int j = 0; j < RocketsParentToUnlock.transform.childCount; j++)
        {
            RocketsParentToUnlock.transform.GetChild(j).gameObject.SetActive(false);
            RocketsParentInGame.transform.GetChild(j).gameObject.SetActive(false);
        }
        RocketsParentToUnlock.transform.Find(CurrentSkin).gameObject.SetActive(true);
        RocketsParentInGame.transform.Find(CurrentSkin).gameObject.SetActive(true);
        ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": " + RocketsParentToUnlock.transform.Find(CurrentSkin).gameObject.GetComponent<RocketProperties>().PointsToUnlock;
    }

    #endregion



    #region CHAPTERS SELECTION
    public void BindToggles()
    {
            foreach (GameObject toggle in ChapterSelectionToggles)
            {
                //print(child.gameObject.name+" dsfd");
                Toggle tog = toggle.GetComponent<Toggle>();
                if (tog != null)
                {
                    InitializeToglesByName(tog);
                    tog.onValueChanged.AddListener(delegate { TogleOnValueChange(tog); });
                }

            }
    }

    public void TogleOnValueChange(Toggle gameobjtogle)
    {
        if (gameobjtogle.gameObject.name.Equals("taksi3enotita1"))
        {
            currentUser.Chapters.taksi3enotita1 = gameobjtogle.isOn;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita2"))
        {
            currentUser.Chapters.taksi3enotita2 = gameobjtogle.isOn;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita3"))
        {
            currentUser.Chapters.taksi3enotita3 = gameobjtogle.isOn;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita4"))
        {
            currentUser.Chapters.taksi3enotita4 = gameobjtogle.isOn;
        }
    }

    public void BindTogglesWithProblems()
    {
        //print(gameObject.name);
        foreach (GameObject toggle in ChapterSelectionToggles)
        {
            //print(child.gameObject.name+" dsfd");
            Toggle tog = toggle.GetComponent<Toggle>();
            if (tog != null)
            {
                AllProblems.AddTaksiEnotita(tog.isOn, tog.gameObject.name);
            }

        }

    }

    public void InitializeToglesByName(Toggle gameobjtogle)
    {
        if (gameobjtogle.gameObject.name.Equals("taksi3enotita1"))
        {
            gameobjtogle.isOn = currentUser.Chapters.taksi3enotita1;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita2"))
        {
            gameobjtogle.isOn = currentUser.Chapters.taksi3enotita2;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita3"))
        {
            gameobjtogle.isOn = currentUser.Chapters.taksi3enotita3;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita4"))
        {
            gameobjtogle.isOn = currentUser.Chapters.taksi3enotita4;
        }
    }

    #endregion


    public void SaveData() {
        GlobalData.SerializeAll();
    }

    public void SelectRocketOrUnlockIt() {
        float usersScore = currentUser.Score;
        if (RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.GetComponent<RocketProperties>().PointsToUnlock > usersScore) {
            MessageForUnlock.text = "Δεν εχεις αρκετούς πόντους για αυτό το σκάφος";
            return;
        }
        MessageForUnlock.text = "Αυτό είναι το νέο σου σκάφος!";
        currentUser.SkinSelected = CurrentSkin;
    }

    public void EnableCameraPathFollower() {
        MainCamera.GetComponent<CameraPathFollower>().enabled = true;
    }



    public void UpdateSelectedUserInDropDown() {
        // returns a list of the text properties of the options
        List<string> listAvailableStrings = UserDropDown.options.Select(option => option.text).ToList();
        // returns the index of the given string
        UserDropDown.value = listAvailableStrings.IndexOf(GlobalData.UsersManager.LoggedInUser);

    }

    public void OnUserChanged() {
        GlobalData.UsersManager.LoggedInUser = GlobalData.UsersManager.UsersNames.Find(x => x.Equals(UserDropDown.options[UserDropDown.value].text));
        currentUser = GlobalData.UsersManager.GetUser(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType);
        ScoreText.text = GlobalData.UsersManager.GetUser(GlobalData.UsersManager.LoggedInUser,GlobalData.SerialType).Score.ToString();
        LoggenInUser.text = GlobalData.UsersManager.LoggedInUser;
    }

    public void OnAddNewUser() {
        bool added = GlobalData.UsersManager.AddNewUser(NewUserNameInput.text, GlobalData.SerialType);
        if (!added) {
            return;
        }

        string newuseradded = GlobalData.UsersManager.UsersNames.Find(x => x.Equals(NewUserNameInput.text));
        if (newuseradded == null) {
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

            RocketProperties rockProp = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.GetComponent<RocketProperties>();
            float usersScore = currentUser.Score;
            ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": "+rockProp.PointsToUnlock;
            MessageForUnlock.text = "";
            //if ((rockProp.PointsToUnlock < usersScore)) {
                RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.SetActive(true);
                
                RocketsParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketsParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.SetActive(true);

                CurrentSkin = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.name;
                CurrentSkinIndexofIndex++;
                return;
            //}

        }
        RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketsParentToUnlock.transform.GetChild(rocketsIndexList[0]).gameObject.SetActive(true);

        RocketsParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketsParentInGame.transform.GetChild(rocketsIndexList[0]).gameObject.SetActive(true);

        CurrentSkin = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[0]).gameObject.name;
        CurrentSkinIndexofIndex = 0;
        RocketProperties rockProp2 = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.GetComponent<RocketProperties>();
        ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": " + rockProp2.PointsToUnlock;
    }

    public void PreviousSkin() {
        if (CurrentSkinIndexofIndex > 0) {

            RocketProperties rockProp = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.GetComponent<RocketProperties>();
            ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": " + rockProp.PointsToUnlock;
            float usersScore = currentUser.Score;
            //if ((rockProp.PointsToUnlock < usersScore)) {
                RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.SetActive(true);

                RocketsParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketsParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.SetActive(true);

                CurrentSkin = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.name;
                CurrentSkinIndexofIndex--;
                return;
            //}
        }
        RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketsParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        int i = 1;
        //float point = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.GetComponent<RocketProperties>().PointsToUnlock;
        //float playerpoints = currentUser.Score;
        //while (point > playerpoints) {
        //    if (i == rocketsIndexList.Count) {
        //        break;
        //    }
        //    i++;
        //    point = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.GetComponent<RocketProperties>().PointsToUnlock;
        //}
        RocketsParentInGame.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.SetActive(true);
        RocketsParentToUnlock.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.SetActive(true);

        CurrentSkin = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.name;
        CurrentSkinIndexofIndex = rocketsIndexList.Count - i;
        RocketProperties rockProp2 = RocketsParentToUnlock.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.GetComponent<RocketProperties>();
        ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": " + rockProp2.PointsToUnlock;

    }

    public  void ActivateSkinSelection() {
        SkinSelectionPanel.SetActive(true);
        RocketsCollection.SetActive(true);
    }

    public void LoadSkinList() {
        for (int i = 0; i < RocketsParentToUnlock.transform.childCount; i++) {
            if (RocketsParentToUnlock.transform.GetChild(i).gameObject.name.Contains("ENEASRocket")) {
                rocketsIndexList.Add(i);
            }
        }
    }

    public void RefreshDetails() {
        ScoreText.text = "Πόντοι :" + currentUser.Score + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
