using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathematicalProblems : MonoBehaviour
{
    public static List<MathProblem> MathProblems = new List<MathProblem>();
    void Start() {
        //Μαθηματικά Προβλήματα Α Δημοτικού Κεφ.34 Αριθμοί μέχρι το 100
        string problem = "35 …. 37 Ποιος είναι ο αριθμός ανάμεσα;";
        string[] answers = {"34","36" };
        int correctindex = 1;
        MathProblems.Add(new MathProblem(problem,answers,correctindex));

        problem = "Πόσο κάνει 20+10+5;";
        correctindex = 0;
        answers = new string[] { "35" ,"25" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        //Προβλήματα Α δημοτικού Κεφ.39 Μονάδες Δεκάδες
        problem = "Ποιος αριθμός έχει 4 Δεκάδες (Δ) και 3 Μονάδες (Μ);";
        correctindex = 1;
        answers = new string[] { "34", "43" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιος αριθμός έχει 5 Δεκάδες (Δ) και 7 Μονάδες (Μ);";
        correctindex = 1;
        answers = new string[] { "75" ,"57" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιος αριθμός έχει 7 Μονάδες (Μ) και 4 Δεκάδες (Δ);";
        correctindex = 0;
        answers = new string[] { "74", "47" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        //Μαθηματικά Προβλήματα B Δημοτικού Κεφ.2 Φτιάχνω αριθμούς μέχρι το 100 και τους συγκρίνω

        problem = "Ένας αριθμός έχει 3 Μονάδες και 7 Δεκάδες. Ποιός αριθμός είναι;";
        correctindex = 0;
        answers = new string[] { "37" ,"73" };
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
