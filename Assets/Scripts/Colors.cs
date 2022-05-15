using UnityEngine;


public class Colors : MonoBehaviour
{
    public static Color RED    = new(1f, .313f, .313f);
    public static Color GREEN  = new(.568f, 1f, .313f);
    public static Color BLUE   = new(.313f, .75f, 1f);
    public static Color YELLOW = new(1f, .8f, .13f);
    
    public static Color32[] ColorOrder =
    {
        new Color32(255,80,80,255),
        new Color32(144,255,80,255),
        new Color32(80,191,255,255),
        new Color32(255,204,33,255),
        new Color32(141, 20, 222,255),
        new Color32(255, 128, 64,255),
        new Color32(190,190,190,255),
        new Color32(114, 196, 174,255)
    };
}