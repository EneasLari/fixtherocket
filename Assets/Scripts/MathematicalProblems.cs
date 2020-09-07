using Assets.Scripts.UserSystem.GlobalData;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class MathematicalProblems : MonoBehaviour
{
    public static List<MathProblem> MathProblems = new List<MathProblem>();
    public GameObject SelectChaptersGameObject;
    

    public void BindToggles() {
        foreach (Transform child in SelectChaptersGameObject.transform) {
            foreach (Transform grandchild in child) {
                //print(child.gameObject.name+" dsfd");
                Toggle tog = grandchild.gameObject.GetComponent<Toggle>();
                if (tog != null) {
                    InitializeToglesByName(tog);
                    tog.onValueChanged.AddListener(delegate { TogleOnValueChange(tog); });
                }
                
            }

        }
       
    }

    public void BindTogglesWithProblems() {
        //print(gameObject.name);
        foreach (Transform child in SelectChaptersGameObject.transform) {
            foreach (Transform grandchild in child) {
                Toggle tog = grandchild.GetComponent<Toggle>();
                if (tog != null) {
                    AddTaksiEnotita(tog.isOn, tog.gameObject.name);
                }
                
            }

        }

    }

    public void InitializeToglesByName(Toggle gameobjtogle) {
        if (gameobjtogle.gameObject.name.Equals("taksi3enotita1")) {
            gameobjtogle.isOn = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser,GlobalData.SerialType).Chapters.taksi3enotita1;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita2")) {
            gameobjtogle.isOn = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Chapters.taksi3enotita2;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita3")) {
            gameobjtogle.isOn = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Chapters.taksi3enotita3;
        }
        else if (gameobjtogle.gameObject.name.Equals("taksi3enotita4")) {
            gameobjtogle.isOn = GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Chapters.taksi3enotita4;
        }
    }


    public void TogleOnValueChange(Toggle gameobjtogle) {
        if (gameobjtogle.gameObject.name.Equals("taksi3enotita1")) {
            GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Chapters.taksi3enotita1= gameobjtogle.isOn;
        } else if (gameobjtogle.gameObject.name.Equals("taksi3enotita2")) {
            GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Chapters.taksi3enotita2= gameobjtogle.isOn;
        } else if (gameobjtogle.gameObject.name.Equals("taksi3enotita3")) {
            GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Chapters.taksi3enotita3= gameobjtogle.isOn;
        } else if (gameobjtogle.gameObject.name.Equals("taksi3enotita4")) {
            GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Chapters.taksi3enotita4=gameobjtogle.isOn;
        }
    }

    public void AddTaksiEnotita(bool canadd,string togglename) {
        if (canadd && togglename.Equals("taksi3enotita1")) {
            //Μαθηματικά Προβλήματα Α Δημοτικού Κεφ.34 Αριθμοί μέχρι το 100
            string problem = "35 …. 37 Ποιος είναι ο αριθμός ανάμεσα;";
            string[] answers = { "34", "36" };
            int correctindex = 1;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Πόσο κάνει 20+10+5;";
            correctindex = 0;
            answers = new string[] { "35", "25" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            //Προβλήματα Α δημοτικού Κεφ.39 Μονάδες Δεκάδες
            problem = "Ποιος αριθμός έχει 4 Δεκάδες (Δ) και 3 Μονάδες (Μ);";
            correctindex = 1;
            answers = new string[] { "34", "43" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ποιος αριθμός έχει 5 Δεκάδες (Δ) και 7 Μονάδες (Μ);";
            correctindex = 1;
            answers = new string[] { "75", "57" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ποιος αριθμός έχει 7 Μονάδες (Μ) και 4 Δεκάδες (Δ);";
            correctindex = 0;
            answers = new string[] { "74", "47" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));
            print(MathProblems.Count);
        }
    }

    void Start() {
        GlobalData.SerialType = Assets.Scripts.PersistentData.SerializationType.Binary;
        BindToggles();
        BindTogglesWithProblems();
        //Μαθηματικά Προβλήματα B Δημοτικού Κεφ.2 Φτιάχνω αριθμούς μέχρι το 100 και τους συγκρίνω

        string problem = "Ένας αριθμός έχει 3 Μονάδες και 7 Δεκάδες. Ποιός αριθμός είναι;";
        int correctindex = 0;
        string[]answers = new string[] { "37" ,"73" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Πόσες δεκάδες έχει ο αριθμός 17;";
        correctindex = 0;
        answers = new string[] { "1", "7" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "34<43. Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σ", "Λ" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        problem = "Αν σε έναν αριθμό με 2 Δεκάδες και 9 Μονάδες προσθέσω 1 Μονάδα ακόμα ποιόν αριθμό θα έχω;";
        correctindex = 0;
        answers = new string[] { "28", "30" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ένας αριθμός έχει 2 Δεκάδες και 3 Μονάδες. Ποιός αριθμός είναι;";
        correctindex = 0;
        answers = new string[] { "23" ,"32" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));
        //print(MathProblems.Count);
    }



    #region MATHPROBLEM class
    public class MathProblem
    {

        public string Problem = null;
        public string[] Answers = null;
        public int CorrectAnswerIndex = 0;

        public MathProblem(string problem, string[] answers, int correctindex) {
            Problem = problem;
            Answers = answers;
            CorrectAnswerIndex = correctindex;
        }

    }
    #endregion
}
