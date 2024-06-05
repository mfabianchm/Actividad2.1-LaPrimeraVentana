using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenYouTube()
    {
        Application.OpenURL("https://www.youtube.com");
    }
    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/mfabianchm");
    }
    public void OpenGoogle()
    {
        Application.OpenURL("https://google.com");
    }
}
