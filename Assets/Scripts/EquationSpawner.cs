using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EquationSpawner : MonoBehaviour {
    public GameObject player;
    //public GameObject enemyplayer;
    public int Corrects = 0;
    public int Wrongs = 0;
    public Text resultTextA;
    private int resultValueA;
    public Text resultTextB;
    private int resultValueB;
    public Text CalculationText;
    private int varvalA;
    private int varvalB;
    public Button resultButA;
    public Button resultButB;
    private int CorrectAnswer;
    public CalculationType TypeOfCalculation;
    public GameObject LaunchTheRocketUI;
    public GameObject CalculationsUI;
    public int calculationsToFinish = 3;

    public enum CalculationType {
        Substraction, Addition, Multiply, Divide
    }
    private float timerSec = 0.0f;//this resets to zero everytime we get nextcalculation
    private int secsPassed = 0;
    public float SecsToResetSpeed = 5;
    public int estimatedTime = 10;
    
    public float speedEnemyWins = 1f;
    public float speedPlayerWins = 1f;
    //https://answers.unity.com/questions/1270907/how-to-assign-a-value-to-buttons-every-button-woul.html
    private int rand;
    //private float pitchgained = 0;
    // Start is called before the first frame update
    private float initialspeed;

    void Start() {
        if (CalculationsUI != null) {
            CalculationsUI.SetActive(true);
        }
        if (LaunchTheRocketUI != null) {
            LaunchTheRocketUI.SetActive(false);
        }
        //initialspeed = player.GetComponent<PlayerMovement>().speed;
        StartCoroutine(getCalculation(0));
        //if (GlobalVars.CalculationType == "Addition") {
        //    TypeOfCalculation = CalculationType.Addition;
        //}
        //if (GlobalVars.CalculationType == "Subtraction") {
        //    TypeOfCalculation = CalculationType.Substraction;
        //}
        //if (GlobalVars.CalculationType == "Multiplication") {
        //    TypeOfCalculation = CalculationType.Multiply;
        //}
        //if (GlobalVars.CalculationType == "Division") {
        //    TypeOfCalculation = CalculationType.Divide;
        //}
        //rand = Random.Range(0, enemyplayer.transform.GetChild(0).childCount - 1);
        //for (int i=0;i< player.transform.GetChild(0).childCount;i++) {
        //    if (i == GlobalVars.playerskinSelected) {
        //        player.transform.GetChild(0).GetChild(i).gameObject.SetActive(true);
        //        player.transform.GetChild(0).GetChild(i).GetComponent<AudioSource>().volume = 0.4f;
        //    } else {
        //        player.transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
        //    }
        //    if (i==rand) {
        //       //// enemyplayer.transform.GetChild(0).GetChild(i).gameObject.SetActive(true);
        //       // enemyplayer.transform.GetChild(0).GetChild(i).GetComponent<AudioSource>().volume = 0.4f;
        //    } else {
        //       // enemyplayer.transform.GetChild(0).GetChild(i).gameObject.SetActive(false);
        //    }
        //}
        resultButA.onClick.AddListener(TaskOnClick);
        resultButB.onClick.AddListener(TaskOnClick);

    }

    void OnApplicationQuit() {
        Debug.Log("Application ending after " + Time.time + " seconds");
        //GlobalVars.Serialize();
    }

    public void TaskOnClick() {
        string clicked = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        if (calculationsToFinish > 1) {
            if (int.Parse(clicked) == CorrectAnswer) {
                Corrects++;
                //EventSystem.current.currentSelectedGameObject.GetComponent<AudioSource>().Play();
                resultTextA.text = "";
                resultTextB.text = "";
                CalculationText.text = CalculationText.text + CorrectAnswer;
                secsPassed = Mathf.RoundToInt(timerSec);
                //print("You found the correct answer in " + secsPassed + " secs");
                float percet = ((float)secsPassed / (float)estimatedTime);
                //player.GetComponent<PlayerMovement>().speed = player.GetComponent<PlayerMovement>().speed + (speedPlayerWins - percet);
                //player.transform.GetChild(0).GetChild(GlobalVars.playerskinSelected).GetComponent<AudioSource>().pitch += (float)0.3;
                //pitchgained += (float)0.3;
                //enemyplayer.GetComponent<PlayerMovement>().speed = enemyplayer.GetComponent<PlayerMovement>().speed + percet;
                StartCoroutine(getCalculation(1));
                calculationsToFinish--;
            } else {
                Wrongs++;
                resultTextA.text = "";
                resultTextB.text = "";
                // enemyplayer.GetComponent<PlayerMovement>().speed = enemyplayer.GetComponent<PlayerMovement>().speed + speedEnemyWins;
                ///enemyplayer.transform.GetChild(0).GetChild(rand).GetComponent<AudioSource>().pitch += (float)0.3;
                StartCoroutine(getCalculation(1));
            }
            
            if (calculationsToFinish == 0) {
                //Show something to tell that the calculations finished
            }
            //print("You have more " + calculationsToFinish + " calcs to finish");
        } else {
            if (CalculationsUI != null) {
                CalculationsUI.SetActive(false);
            }
            if (LaunchTheRocketUI != null) {
                LaunchTheRocketUI.SetActive(true);
            }
        }

    }

    public void getNextAddition() {
        secsPassed = 0;
        timerSec = 0;
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
        secsPassed = 0;
        timerSec = 0;
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
        secsPassed = 0;
        timerSec = 0;
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
        secsPassed = 0;
        timerSec = 0;
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
        if (TypeOfCalculation == CalculationType.Addition) {
            getNextAddition();
        } else if (TypeOfCalculation == CalculationType.Divide) {
            getNextDivision();
        } else if (TypeOfCalculation == CalculationType.Substraction) {
            getNextSubtraction();
        } else if (TypeOfCalculation == CalculationType.Multiply) {
            getNextMultiply();
        }

    }
    public void ReplayLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainLevel() {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void PauseGame() {
        Time.timeScale = 0;
        //Disable scripts that still work while timescale is set to 0
    }
    public void ContinueGame() {
        Time.timeScale = 1;
        //enable the scripts again
    }

    // Update is called once per frame
    void Update() {
        timerSec = (timerSec + Time.deltaTime) % 60;
        //if (!player.GetComponent<PlayerMovement>().finishedRace) {
        //    if (timerSec >= SecsToResetSpeed && (player.GetComponent<PlayerMovement>().speed != initialspeed)) {
        //        //print("reset SPEED");
        //        //enemyplayer.GetComponent<PlayerMovement>().speed = initialspeed;
        //        //player.GetComponent<PlayerMovement>().speed = initialspeed;
        //        //player.transform.GetChild(0).GetChild(GlobalVars.playerskinSelected).GetComponent<AudioSource>().pitch = 1;                          
        //    }
        //}
    }
}
