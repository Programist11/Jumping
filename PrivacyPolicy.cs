using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyPolicy : MonoBehaviour
{
    public void OpenPrivacyPolicy()
    {
        Application.OpenURL("https://sites.google.com/view/jumping-privacy-policy/home");
    }
}
