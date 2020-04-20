using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using Entities.MathEquations;

public class HandleTextFile : MonoBehaviour
{
    public TextAsset[] textFileArray;     // drop your file here in inspector
    public static List<Calculation> CalculationsList = new List<Calculation>();
    void Awake() {
        ParseFile(textFileArray[0]);
        //print(CalculationsList.Count);
    }

    private void ParseFile(TextAsset textFile) {
        string[] CalculationsLines = textFile.text.Split('\n');  //this is the content as string
        byte[] byteText = textFile.bytes;  //this is the content as byte array
        foreach (string s in CalculationsLines) {
            if (!s.Contains("=")) {
                continue;
            }

            string[] oper = s.Split('+', '-', '*', '/', '=');
            //print(oper.Length);
            int i = 0;
            foreach (string op in oper) {
                oper[i] = op.Trim();
                i++;
            }

            string calcoperator = null;
            int correct = 0;
            if (s.Contains("+")) {
                calcoperator = "+";
                correct = int.Parse(oper[0]) + int.Parse(oper[1]);
            } else if (s.Contains("-")) {
                calcoperator = "-";
                correct = int.Parse(oper[0]) - int.Parse(oper[1]);
            } else if (s.Contains("*")) {
                calcoperator = "*";
                correct = int.Parse(oper[0]) * int.Parse(oper[1]);
            } else if (s.Contains("/")) {
                calcoperator = "/";
                correct = int.Parse(oper[0]) / int.Parse(oper[1]);
            }
            string resulta = oper[2].Split(' ')[0].Trim(' ', ',');
            string resultb = oper[2].Split(' ')[1].Trim(' ', ',');
            int wrong = 0;
            if (int.Parse(resulta) == correct) {
                wrong = int.Parse(resultb);
            } else {
                wrong = int.Parse(resulta);
            }

            Calculation newCalc = new Calculation(int.Parse(oper[0]), int.Parse(oper[1]), calcoperator, correct, wrong);
            CalculationsList.Add(newCalc);
        }
    }
}
