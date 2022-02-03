using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MainScript : MonoBehaviour
{

    [SerializeField] private InputField inputFieldval1, inputFieldval2;
    [SerializeField] private Text txtResult;



    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;

        result = summandA + summandB;
        txtResult.text = string.Format("{0}", result);
        return result;
    }

    public void GetValues()
    {
        string val1, val2;
        val1 = inputFieldval1.text;
        val2 = inputFieldval2.text;

        int summandA=0, summandB=0;
        try
        {
            summandA = int.Parse(val1);
        }
        catch (System.Exception)
        {
            Debug.Log("Bruh");
            inputFieldval1.GetComponent<InputField>().image.color = Color.red;
            inputFieldval1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte gültige Zahl eingeben.";
            inputFieldval1.text = "";

        }
        try
        {
            summandB = int.Parse(val2);
        }
        catch (System.Exception)
        {
            Debug.Log("Bruh");
            inputFieldval2.GetComponent<InputField>().image.color = Color.red;
            inputFieldval2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Bitte gültige Zahl eingeben.";
            inputFieldval2.text = "";

        }
        txtResult.text = CheckAddition(summandA, summandB).ToString();
       
        try
        {
            summandA = int.Parse(val1);
        }
        catch
        {
            txtResult.text = "Kein Ergebnis.";
        }
        try
        {
            summandB = int.Parse(val2);
        }
        catch
        {
            txtResult.text = "Kein Ergebnis.";
        }


    }

    public void ResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}
