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

public class EquationSpawner : MonoBehaviour {
    public GameObject player;
    public GameObject LaunchTheRocketPanel;
    public GameObject MainMenuPanel;
    public GameObject CalculationGamePanel;

    public Text resultTextA;
    public Text resultTextB;
    public Text CalculationText;
    public Text calculationsFinishedText;

    private int score=0;
    public Text ScoreText;

    public Button resultButA;
    public Button resultButB;

    public CalculationType TypeOfCalculation;
    public int calculationsFinished = 3;
    private int calculationsToFinish;
    public int estimatedTimePerCalc = 5;
    public bool getfromFile = false;
    public bool getMathProblems = false;
    public int TotalTimeForResponses = 0;

    private int CorrectAnswer;
    private int CalcListIndex = 0;
    

    private float timer = 0.0f;
    private int timerInSeconds=0;
    private bool counterStopped=true;

    public enum CalculationType {
        Substraction, Addition, Multiply, Divide
    }

    void Start() {
        GlobalData.SerialType = SerializationType.Binary;
        StartCoroutine(getCalculation(0));
        resultButA.onClick.AddListener(TaskOnClick);
        resultButB.onClick.AddListener(TaskOnClick);
        calculationsFinishedText.text = calculationsFinished.ToString();
        calculationsToFinish = calculationsFinished;
    }


    public void TaskOnClick() {
        string clicked = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        EventSystem.current.SetSelectedGameObject(null);
        if (clicked.Equals("")) {
            return;
        }

        if (calculationsFinished > 1) {
            if ((getMathProblems && MathematicalProblems.MathProblems[CalcListIndex-1].Answers[CorrectAnswer].Equals(clicked) )) {
                resultTextA.text = "";
                resultTextB.text = "";
                CalculationText.text = CalculationText.text +" "+ clicked;
                StartCoroutine(getCalculation(1));
                calculationsFinished--;
                calculationsFinishedText.text = calculationsFinished.ToString();
                score += CalcListIndex;
                ScoreText.text = score.ToString();
            } else {
                resultTextA.text = "";
                resultTextB.text = "";
                StartCoroutine(getCalculation(1));
            }
            FlipCounterState();//stopped
            Invoke("FlipCounterState", 1f);//start after 1 sec
            //print("You have more " + calculationsFinished + " calcs to finish");
        } else {
            FlipCounterState();//stop at the end
            TotalTimeForResponses = timerInSeconds;
            GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Score += score;
            GlobalData.UsersManager.GetUserDetails(GlobalData.UsersManager.LoggedInUser, GlobalData.SerialType).Score += calculationsToFinish-(TotalTimeForResponses/estimatedTimePerCalc);
            score += calculationsToFinish - (TotalTimeForResponses / estimatedTimePerCalc); ;
            ScoreText.text = score.ToString();
            if (CalculationGamePanel != null) {
                CalculationGamePanel.SetActive(false);
            }
            if (LaunchTheRocketPanel != null) {
                LaunchTheRocketPanel.SetActive(true);
            }
        }

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
        } else
        {
            resultValueB = acalc.WrongRes;
            resultValueA = acalc.CorrectRes;
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        CalculationText.text = varvalA.ToString() + acalc.CalcOperator + varvalB.ToString() + "=";
    }

    private void getMathProblem() {
        string varvalA;
        string varvalB;
        MathProblem acalc = MathematicalProblems.MathProblems[CalcListIndex];

        varvalA = acalc.Answers[0];
        varvalB = acalc.Answers[1];
        CorrectAnswer = acalc.CorrectAnswerIndex;
        resultTextA.text = varvalA;
        resultTextB.text = varvalB;
        CalculationText.text =acalc.Problem;
        if (CalcListIndex == 0) {
            CalculationText.fontSize = CalculationText.fontSize / 2;
        }
        CalcListIndex++;
        //print(acalc.Problem);
    }


    public void getNextAddition() {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        varvalA = Random.Range(1, 10);
        varvalB = Random.Range(1, 10);
        int correctresult = varvalA + varvalB;
        CorrectAnswer = correctresult;
        int randposition = Random.Range(0, 2);
        if (randposition == 0) {
            resultValueA = correctresult;
            resultValueB = correctresult + Random.Range(-2, 2);
            while (resultValueA == resultValueB) {
                resultValueB = correctresult + Random.Range(-2, 2);
            }
        } else {
            resultValueB = correctresult;
            resultValueA = correctresult + Random.Range(-2, 2);
            while (resultValueB == resultValueA) {
                resultValueA = correctresult + Random.Range(-2, 2);
            }
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        CalculationText.text = varvalA.ToString() + "+" + varvalB.ToString() + "=";
    }


    public void getNextSubtraction() {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        varvalA = Random.Range(1, 10);
        varvalB = Random.Range(1, 10);
        int correctresult = varvalA - varvalB;
        if (correctresult < 0) {
            correctresult = correctresult * (-1);
        }
        CorrectAnswer = correctresult;
        int randposition = Random.Range(0, 2);
        if (randposition == 0) {
            resultValueA = correctresult;
            resultValueB = correctresult + Random.Range(-2, 2);
            while (resultValueA == resultValueB) {
                resultValueB = correctresult + Random.Range(-2, 2);
            }
        } else {
            resultValueB = correctresult;
            resultValueA = correctresult + Random.Range(-2, 2);
            while (resultValueB == resultValueA) {
                resultValueA = correctresult + Random.Range(-2, 2);
            }
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        if (varvalA > varvalB) {
            CalculationText.text = varvalA.ToString() + "-" + varvalB.ToString() + "=";
        } else {
            CalculationText.text = varvalB.ToString() + "-" + varvalA.ToString() + "=";
        }
    }


    public void getNextMultiply() {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        varvalA = Random.Range(1, 10);
        varvalB = Random.Range(1, 10);
        int correctresult = varvalA * varvalB;
        CorrectAnswer = correctresult;
        int randposition = Random.Range(0, 2);
        if (randposition == 0) {
            resultValueA = correctresult;
            resultValueB = correctresult + Random.Range(-2, 2);
            while (resultValueA == resultValueB) {
                resultValueB = correctresult + Random.Range(-2, 2);
            }
        } else {
            resultValueB = correctresult;
            resultValueA = correctresult + Random.Range(-2, 2);
            while (resultValueB == resultValueA) {
                resultValueA = correctresult + Random.Range(-2, 2);
            }
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        CalculationText.text = varvalA.ToString() + "x" + varvalB.ToString() + "=";
    }

    public void getNextDivision() {
        int resultValueA;
        int resultValueB;
        int varvalA;
        int varvalB;
        varvalA = Random.Range(1, 100);
        varvalB = Random.Range(1, varvalA);
        while ((varvalA % varvalB) != 0) {
            /*arvalB--;*/
            varvalA = Random.Range(1, 100);
            varvalB = Random.Range(1, varvalA);
        }
        int correctresult = varvalA / varvalB;
        CorrectAnswer = correctresult;
        int randposition = Random.Range(0, 2);
        if (randposition == 0) {
            resultValueA = correctresult;
            resultValueB = correctresult + Random.Range(-2, 2);
            while (resultValueA == resultValueB) {
                resultValueB = correctresult + Random.Range(-2, 2);
            }
        } else {
            resultValueB = correctresult;
            resultValueA = correctresult + Random.Range(-2, 2);
            while (resultValueB == resultValueA) {
                resultValueA = correctresult + Random.Range(-2, 2);
            }
        }
        resultTextA.text = resultValueA.ToString();
        resultTextB.text = resultValueB.ToString();
        CalculationText.text = varvalA.ToString() + "÷" + varvalB.ToString() + "=";
    }

    public IEnumerator getCalculation(int secstowait) {
        yield return new WaitForSeconds(secstowait);
        if (getMathProblems) {
            getMathProblem();
        } else if (getfromFile) {
            getCalculationFromFile();
        } else if (TypeOfCalculation == CalculationType.Addition) {
            getNextAddition();
        } else if (TypeOfCalculation == CalculationType.Divide) {
            getNextDivision();
        } else if (TypeOfCalculation == CalculationType.Substraction) {
            getNextSubtraction();
        } else if (TypeOfCalculation == CalculationType.Multiply) {
            getNextMultiply();
        }

    }

    void OnApplicationQuit() {
        GlobalData.SerializeAll();
    }

    public void ReplayLevel() {
        RocketPathFollower.rocketState = RocketPathFollower.RocketState.None;
        CanvasManager.panelState = PanelState.InGameMenu;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainLevel() {
        RocketPathFollower.rocketState = RocketPathFollower.RocketState.None;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame() {
        Time.timeScale = 0;
    }
    public void ContinueGame() {
        Time.timeScale = 1;
    }

    public void TimerCount() {
        timer += Time.deltaTime;
        timerInSeconds = (int)(timer % 60);
        //print(timerInSeconds);
    }

    private void FlipCounterState() {
        counterStopped = !counterStopped;
    }

    void Update() {
        if (CalculationGamePanel.activeSelf) {
            FlipCounterState();//start
        }
        if (!counterStopped) {
            TimerCount();
        }
    }
}
