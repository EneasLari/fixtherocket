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
    public GameObject RocketsCollection;
    public GameObject RocketParent;
    public GameObject RocketParentInGame;
    public GameObject[] ChapterSelectionToggles;
    public static PanelState panelState;
    public GameObject MainMenuPanel;
    public GameObject CalculationGamePanel;
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
    }
    void Start() {
        
        Initialize();
        SkinSelectionPanel.SetActive(false);
        RocketsCollection.SetActive(false);
        if (panelState == PanelState.InGameMenu) {
            MainMenuPanel.SetActive(false);
            CalculationGamePanel.SetActive(true);
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
        Transform temptra = RocketParent.transform.Find(currentUser.SkinSelected);
        GameObject temp = null;
        if (temptra != null)
        {
            temp = temptra.gameObject;
        }
        if (temp != null)
        {
            CurrentSkin = temp.name;
            int i = 0;
            foreach (Transform gm in RocketParent.transform)
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
            CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[0]).name;
            CurrentSkinIndexofIndex = 0;
            currentUser.SkinSelected = CurrentSkin;
        }
        for (int j = 0; j < RocketParent.transform.childCount; j++)
        {
            RocketParent.transform.GetChild(j).gameObject.SetActive(false);
            RocketParentInGame.transform.GetChild(j).gameObject.SetActive(false);
        }
        RocketParent.transform.Find(CurrentSkin).gameObject.SetActive(true);
        RocketParentInGame.transform.Find(CurrentSkin).gameObject.SetActive(true);
        ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": " + RocketParent.transform.Find(CurrentSkin).gameObject.GetComponent<RocketProperties>().PointsToUnlock;
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
                AddTaksiEnotita(tog.isOn, tog.gameObject.name);
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
    public void AddTaksiEnotita(bool canadd, string togglename)
    {
        if (canadd && togglename.Equals("taksi3enotita1"))
        {
            //Μαθηματικά Προβλήματα Α Δημοτικού Κεφ.34 Αριθμοί μέχρι το 100
            string problem = "35 ... 37 Ποιος είναι ο αριθμός ανάμεσα;";
            string[] answers = { "34", "36" };
            int correctindex = 1;
            MathematicalProblems.MathProblems.Add(new MathematicalProblems.MathProblem(problem, answers, correctindex));

            problem = "Πόσο κάνει 20+10+5;";
            correctindex = 0;
            answers = new string[] { "35", "25" };
            MathematicalProblems.MathProblems.Add(new MathematicalProblems.MathProblem(problem, answers, correctindex));

            //Προβλήματα Α δημοτικού Κεφ.39 Μονάδες Δεκάδες
            problem = "Ποιος αριθμός έχει 4 Δεκάδες (Δ) και 3 Μονάδες (Μ);";
            correctindex = 1;
            answers = new string[] { "34", "43" };
            MathematicalProblems.MathProblems.Add(new MathematicalProblems.MathProblem(problem, answers, correctindex));

            problem = "Ποιος αριθμός έχει 5 Δεκάδες (Δ) και 7 Μονάδες (Μ);";
            correctindex = 1;
            answers = new string[] { "75", "57" };
            MathematicalProblems.MathProblems.Add(new MathematicalProblems.MathProblem(problem, answers, correctindex));

            problem = "Ποιος αριθμός έχει 7 Μονάδες (Μ) και 4 Δεκάδες (Δ);";
            correctindex = 0;
            answers = new string[] { "74", "47" };
            MathematicalProblems.MathProblems.Add(new MathematicalProblems.MathProblem(problem, answers, correctindex));
            print(MathematicalProblems.MathProblems.Count);
        }
    }
    #endregion


    public void SaveData() {
        GlobalData.SerializeAll();
    }

    public void SelectRocketOrUnlockIt() {
        float usersScore = currentUser.Score;
        if (RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.GetComponent<RocketProperties>().PointsToUnlock > usersScore) {
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

            RocketProperties rockProp = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.GetComponent<RocketProperties>();
            float usersScore = currentUser.Score;
            ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": "+rockProp.PointsToUnlock;
            MessageForUnlock.text = "";
            //if ((rockProp.PointsToUnlock < usersScore)) {
                RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.SetActive(true);
                
                RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.SetActive(true);

                CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex + 1]).gameObject.name;
                CurrentSkinIndexofIndex++;
                return;
            //}

        }
        RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketParent.transform.GetChild(rocketsIndexList[0]).gameObject.SetActive(true);

        RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketParentInGame.transform.GetChild(rocketsIndexList[0]).gameObject.SetActive(true);

        CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[0]).gameObject.name;
        CurrentSkinIndexofIndex = 0;
        RocketProperties rockProp2 = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.GetComponent<RocketProperties>();
        ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": " + rockProp2.PointsToUnlock;
    }

    public void PreviousSkin() {
        if (CurrentSkinIndexofIndex > 0) {

            RocketProperties rockProp = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.GetComponent<RocketProperties>();
            ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": " + rockProp.PointsToUnlock;
            float usersScore = currentUser.Score;
            //if ((rockProp.PointsToUnlock < usersScore)) {
                RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.SetActive(true);

                RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
                RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.SetActive(true);

                CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex - 1]).gameObject.name;
                CurrentSkinIndexofIndex--;
                return;
            //}
        }
        RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        RocketParentInGame.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.SetActive(false);
        int i = 1;
        //float point = RocketParent.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.GetComponent<RocketProperties>().PointsToUnlock;
        //float playerpoints = currentUser.Score;
        //while (point > playerpoints) {
        //    if (i == rocketsIndexList.Count) {
        //        break;
        //    }
        //    i++;
        //    point = RocketParent.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.GetComponent<RocketProperties>().PointsToUnlock;
        //}
        RocketParentInGame.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.SetActive(true);
        RocketParent.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.SetActive(true);

        CurrentSkin = RocketParent.transform.GetChild(rocketsIndexList[rocketsIndexList.Count - i]).gameObject.name;
        CurrentSkinIndexofIndex = rocketsIndexList.Count - i;
        RocketProperties rockProp2 = RocketParent.transform.GetChild(rocketsIndexList[CurrentSkinIndexofIndex]).gameObject.GetComponent<RocketProperties>();
        ScoreText_UnlockPanel.text = ScoreText_UnlockPanel.text.Split(':')[0] + ": " + rockProp2.PointsToUnlock;

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
        ScoreText.text = "Πόντοι :" + currentUser.Score + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
