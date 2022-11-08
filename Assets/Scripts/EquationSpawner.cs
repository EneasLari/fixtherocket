using Assets.Scripts.PersistentData;
using Assets.Scripts.UserSystem.GlobalData;
using Entities.MathEquations;
using PathCreation.PathFollower;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static MathematicalProblems;

public enum QuestionType
{
    Substraction, Addition, Multiply, Divide, MathProblem
}
public class EquationSpawner : MonoBehaviour
{
    public GameObject LaunchTheRocketPanel;
    public GameObject CalculationGamePanel;

    public Text resultTextA;
    public Text resultTextB;
    public Text QuestionText;
    public Text NumQuestionsFinishedText;

    private int score = 0;
    public Text ScoreText;

    public Button AnswerAButton;
    public Button AnswerBButton;

    public QuestionType questionType;
    public int questionsRemaining = 3;

    private int _questionsRemaining;
    private int CorrectAnswer;
    private int CalcListIndex = 0;



    private User currentUser;

    void Start()
    {
        currentUser = GlobalData.UsersManager.GetUser(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType);
        StartCoroutine(getMathQuestion(0));
        AnswerAButton.onClick.AddListener(TaskOnClick);
        AnswerBButton.onClick.AddListener(TaskOnClick);
        NumQuestionsFinishedText.text = questionsRemaining.ToString();
        _questionsRemaining = questionsRemaining;
    }


    public void TaskOnClick()
    {
        string clicked = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        EventSystem.current.SetSelectedGameObject(null);
        if (clicked.Equals(""))
        {
            return;
        }

        if (questionsRemaining >= 1)
        {
            if ((questionType==QuestionType.MathProblem && MathematicalProblems.MathProblems[CalcListIndex - 1].Answers[CorrectAnswer].Equals(clicked)))
            {
                //we put that here so if the counter is 1 and the aswer is correct we go out of calc play
                if (questionsRemaining == 1)
                {
                    currentUser.Score += score;
                    currentUser.Score += _questionsRemaining;
                    score += _questionsRemaining;
                    ScoreText.text = score.ToString();
                    if (CalculationGamePanel != null)
                    {
                        CalculationGamePanel.SetActive(false);
                    }
                    if (LaunchTheRocketPanel != null)
                    {
                        LaunchTheRocketPanel.SetActive(true);
                    }
                }

                resultTextA.text = "";
                resultTextB.text = "";
                QuestionText.text = QuestionText.text + " " + clicked;
                StartCoroutine(getMathQuestion(1));
            }
            else
            {
                resultTextA.text = "";
                resultTextB.text = "";
                QuestionText.text = QuestionText.text + " " + clicked;
                StartCoroutine(getMathQuestion(1));
            }
            questionsRemaining--;
            NumQuestionsFinishedText.text = questionsRemaining.ToString();
            score += CalcListIndex;
            ScoreText.text = score.ToString();
        }
        else
        {
            currentUser.Score += score;
            currentUser.Score += _questionsRemaining;
            score += _questionsRemaining;
            ScoreText.text = score.ToString();
            if (CalculationGamePanel != null)
            {
                CalculationGamePanel.SetActive(false);
            }
            if (LaunchTheRocketPanel != null)
            {
                LaunchTheRocketPanel.SetActive(true);
            }
        }

    }

    void OnApplicationQuit()
    {
        GlobalData.SerializeAll();
    }

    public void ReplayLevel()
    {
        RocketPathFollower.rocketState = RocketState.None;
        CanvasManager.panelState = PanelState.InGameMenu;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainLevel()
    {
        RocketPathFollower.rocketState = RocketState.None;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
    }


    public IEnumerator getMathQuestion(int secstowait)
    {
        yield return new WaitForSeconds(secstowait);
        if (questionType==QuestionType.MathProblem)
        {
            getMathProblem();
        }
        else
        {
            getCalculation();
        }
    }

    #region MATH PROPBLEMS

    private void getMathProblem()
    {
        string varvalA;
        string varvalB;
        MathProblem acalc = MathematicalProblems.MathProblems[CalcListIndex];
        varvalA = acalc.Answers[0];
        varvalB = acalc.Answers[1];
        CorrectAnswer = acalc.CorrectAnswerIndex;
        resultTextA.text = varvalA;
        resultTextB.text = varvalB;
        QuestionText.text = acalc.Problem;
        if (CalcListIndex == 0)
        {
            QuestionText.fontSize = QuestionText.fontSize / 2;
        }
        CalcListIndex++;
    }

    #endregion

    #region MATHEMATICAL CALCULATIONS
    public void getNextAddition()
    {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        varvalA = Random.Range(1, 10);
        varvalB = Random.Range(1, 10);
        int correctresult = varvalA + varvalB;
        CorrectAnswer = correctresult;
        int randposition = Random.Range(0, 2);
        if (randposition == 0)
        {
            resultValueA = correctresult;
            resultValueB = correctresult + Random.Range(-2, 2);
            while (resultValueA == resultValueB)
            {
                resultValueB = correctresult + Random.Range(-2, 2);
            }
        }
        else
        {
            resultValueB = correctresult;
            resultValueA = correctresult + Random.Range(-2, 2);
            while (resultValueB == resultValueA)
            {
                resultValueA = correctresult + Random.Range(-2, 2);
            }
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        QuestionText.text = varvalA.ToString() + "+" + varvalB.ToString() + "=";
    }

    public void getNextSubtraction()
    {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        varvalA = Random.Range(1, 10);
        varvalB = Random.Range(1, 10);
        int correctresult = varvalA - varvalB;
        if (correctresult < 0)
        {
            correctresult = correctresult * (-1);
        }
        CorrectAnswer = correctresult;
        int randposition = Random.Range(0, 2);
        if (randposition == 0)
        {
            resultValueA = correctresult;
            resultValueB = correctresult + Random.Range(-2, 2);
            while (resultValueA == resultValueB)
            {
                resultValueB = correctresult + Random.Range(-2, 2);
            }
        }
        else
        {
            resultValueB = correctresult;
            resultValueA = correctresult + Random.Range(-2, 2);
            while (resultValueB == resultValueA)
            {
                resultValueA = correctresult + Random.Range(-2, 2);
            }
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        if (varvalA > varvalB)
        {
            QuestionText.text = varvalA.ToString() + "-" + varvalB.ToString() + "=";
        }
        else
        {
            QuestionText.text = varvalB.ToString() + "-" + varvalA.ToString() + "=";
        }
    }

    public void getNextMultiply()
    {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        varvalA = Random.Range(1, 10);
        varvalB = Random.Range(1, 10);
        int correctresult = varvalA * varvalB;
        CorrectAnswer = correctresult;
        int randposition = Random.Range(0, 2);
        if (randposition == 0)
        {
            resultValueA = correctresult;
            resultValueB = correctresult + Random.Range(-2, 2);
            while (resultValueA == resultValueB)
            {
                resultValueB = correctresult + Random.Range(-2, 2);
            }
        }
        else
        {
            resultValueB = correctresult;
            resultValueA = correctresult + Random.Range(-2, 2);
            while (resultValueB == resultValueA)
            {
                resultValueA = correctresult + Random.Range(-2, 2);
            }
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        QuestionText.text = varvalA.ToString() + "x" + varvalB.ToString() + "=";
    }

    public void getNextDivision()
    {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        varvalA = Random.Range(1, 100);
        varvalB = Random.Range(1, varvalA);
        while ((varvalA % varvalB) != 0)
        {
            /*arvalB--;*/
            varvalA = Random.Range(1, 100);
            varvalB = Random.Range(1, varvalA);
        }
        int correctresult = varvalA / varvalB;
        CorrectAnswer = correctresult;
        int randposition = Random.Range(0, 2);
        if (randposition == 0)
        {
            resultValueA = correctresult;
            resultValueB = correctresult + Random.Range(-2, 2);
            while (resultValueA == resultValueB)
            {
                resultValueB = correctresult + Random.Range(-2, 2);
            }
        }
        else
        {
            resultValueB = correctresult;
            resultValueA = correctresult + Random.Range(-2, 2);
            while (resultValueB == resultValueA)
            {
                resultValueA = correctresult + Random.Range(-2, 2);
            }
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        QuestionText.text = varvalA.ToString() + "÷" + varvalB.ToString() + "=";
    }
    
    private void getCalculationFromFile()
    {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        Calculation acalc = HandleTextFile.CalculationsList[CalcListIndex];
        CalcListIndex++;
        varvalA = acalc.OperandA;
        varvalB = acalc.OperandB;
        CorrectAnswer = acalc.CorrectRes;
        int rand = Random.Range(0, 100);
        if (rand > 50f)
        {
            resultValueA = acalc.WrongRes;
            resultValueB = acalc.CorrectRes;
        }
        else
        {
            resultValueB = acalc.WrongRes;
            resultValueA = acalc.CorrectRes;
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        QuestionText.text = varvalA.ToString() + acalc.CalcOperator + varvalB.ToString() + "=";
    }
    private void getCalculation()
    {

        if (questionType == QuestionType.Addition)
        {
            getNextAddition();
        }
        else if (questionType == QuestionType.Divide)
        {
            getNextDivision();
        }
        else if (questionType == QuestionType.Substraction)
        {
            getNextSubtraction();
        }
        else if (questionType == QuestionType.Multiply)
        {
            getNextMultiply();
        }

    }

    #endregion

}
