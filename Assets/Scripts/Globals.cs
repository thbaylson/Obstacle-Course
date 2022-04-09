using UnityEngine;
using UnityEngine.UI;

public class Globals
{
    public static int Episode = 0;
    public static int Success = 0;
    public static int Fail = 0;
    private static Text debugText = null;

    public static void ScreenText(){
        if(debugText == null){
            debugText = GameObject.Find("DebugText").gameObject.GetComponent<Text>();
        }

        float SuccessPercent = (Success / (float)(Success + Fail)) * 100;
        if(debugText != null){
            debugText.text = string.Format("Episode={0}, Success={1}, Fail={2}, Rate={3}%",
                Episode,
                Success,
                Fail,
                SuccessPercent.ToString("0"));
        }
    }
}
