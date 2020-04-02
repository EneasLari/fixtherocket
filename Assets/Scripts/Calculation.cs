using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Entities.MathEquations
{
    public class Calculation
    {
        public int OperandA;
        public int OperandB;
        public string CalcOperator;
        public int CorrectRes;
        public int WrongRes;

        public Calculation(int operandA, int operandB, string calcOperator, int correctRes, int wrongRes)
        {
            OperandA = operandA;
            OperandB = operandB;
            CalcOperator = calcOperator;
            CorrectRes = correctRes;
            WrongRes = wrongRes;
        }
    }
}


