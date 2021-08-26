using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Type_Writer_Script : MonoBehaviour
{
    public float delay = 0.01f;
    private string currentText = "";
    public Text dialogueUI;

    IEnumerator ShowText1()
    {
        string text1 = "God this beet farming life is miserable!";

        for (int i = 0; i <= text1.Length; i++)
        {
            currentText = text1.Substring(0, i);
            dialogueUI.GetComponentInChildren<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator ShowText2()
    {
        string text2 = "Its a good thing my great uncle passed away";

        for (int i = 0; i <= text2.Length; i++)
        {
            currentText = text2.Substring(0, i);
            dialogueUI.GetComponentInChildren<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator ShowText3()
    {
        string text3 = "And left me a job at his old firm!";

        for (int i = 0; i <= text3.Length; i++)
        {
            currentText = text3.Substring(0, i);
            dialogueUI.GetComponentInChildren<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator ShowText4()
    {
        string text3 = "Time to go to the big city and live my corporate dream life";

        for (int i = 0; i <= text3.Length; i++)
        {
            currentText = text3.Substring(0, i);
            dialogueUI.GetComponentInChildren<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
