using UnityEngine;
using TMPro;

public class CalculatorUI : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    public TextMeshProUGUI resultText;

    public void AddNumber()
    {
        Calculate("+");
    }

    public void SubstractNumber() 
    {
        Calculate("-");
    }

    public void MultiplyNumber()
    {
        Calculate("*");
    }

    public void DivideNumber()
    {
        Calculate("/");
    }

    void Calculate(string operation)
    {
        if (float.TryParse(inputNum1.text, out float num1) && float.TryParse(inputNum2.text, out float num2))
        {
            float result = 0;
            switch (operation) {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = (num2 != 0) ? num1/num2 : float.NaN;
                    break;
            }

            resultText.text = "Result: " + result.ToString();
        }
        else
        {
            resultText.text = "Invalid input!";
        }
    }
}
