using Assets.Scripts.PersistentData;
using Assets.Scripts.UserSystem.GlobalData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class MathematicalProblems : MonoBehaviour
{
    public static List<MathProblem> MathProblems = new List<MathProblem>();
    public TextAsset questionsJSON;

    [SerializeField]
    private MathProblemsFromJSON mathProblemsFromJSON =new MathProblemsFromJSON();
    private User currentUser;


    void Start() {
        currentUser = GlobalData.UsersManager.GetUser(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType);
        //AllProblems.SetAllProblems();
        //MathProblems.AddRange(AllProblems.MathProblems);

        //mathProblemsFromJSON = JsonUtility.FromJson<MathProblemsFromJSON>(questionsJSON.text);
        //MathProblems.AddRange(mathProblemsFromJSON.taksi1enotita1);

        //Μαθηματικά Προβλήματα B Δημοτικού Κεφ.2 Φτιάχνω αριθμούς μέχρι το 100 και τους συγκρίνω

        //string problem = "Ένας αριθμός έχει 3 Μονάδες και 7 Δεκάδες. Ποιός αριθμός είναι;";
        //int correctindex = 0;
        //string[] answers = new string[] { "37", "73" };
        //MathProblems.Add(new MathProblem(problem, answers, correctindex));

        //problem = "Πόσες δεκάδες έχει ο αριθμός 17;";
        //correctindex = 0;
        //answers = new string[] { "1", "7" };
        //MathProblems.Add(new MathProblem(problem, answers, correctindex));

        //problem = "34<43. Σωστό ή Λάθος;";
        //correctindex = 0;
        //answers = new string[] { "Σ", "Λ" };
        //MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //problem = "Αν σε έναν αριθμό με 2 Δεκάδες και 9 Μονάδες προσθέσω 1 Μονάδα ακόμα ποιόν αριθμό θα έχω;";
        //correctindex = 0;
        //answers = new string[] { "28", "30" };
        //MathProblems.Add(new MathProblem(problem, answers, correctindex));

        //problem = "Ένας αριθμός έχει 2 Δεκάδες και 3 Μονάδες. Ποιός αριθμός είναι;";
        //correctindex = 0;
        //answers = new string[] { "23", "32" };
        //MathProblems.Add(new MathProblem(problem, answers, correctindex));
        //print(MathProblems.Count);





    }



    #region MATHPROBLEM class
    [Serializable]
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

    [Serializable]
    private class MathProblemsFromJSON {

        public MathProblem[] taksi1enotita1;
        public MathProblem[] taksi1enotita2;
        public MathProblem[] taksi1enotita3;
        public MathProblem[] taksi1enotita4;
        public MathProblem[] taksi2enotita1;
        public MathProblem[] taksi2enotita2;
        public MathProblem[] taksi2enotita3;
        public MathProblem[] taksi2enotita4;
        public MathProblem[] taksi3enotita1;
        public MathProblem[] taksi3enotita2;
        public MathProblem[] taksi3enotita3;
        public MathProblem[] taksi3enotita4;
    }

    #endregion
}
