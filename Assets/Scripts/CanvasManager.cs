using Assets.Scripts.PersistentData;
using Assets.Scripts.UserSystem.GlobalData;
using PathCreation.PathFollower;
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
    void Start()
    {
        Initialize();
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
        GlobalData.UsersManager.LoggedInUser = newuseradded;
        GlobalData.SerializeAll();
        InitializeUserDropDown();
    }

    public void RefreshDetails() {
        ScoreText.text = "Πόντοι :" + GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Score + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
