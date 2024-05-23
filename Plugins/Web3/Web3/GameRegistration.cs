using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
// add this back in for production to initialize pop up and registration check
[InitializeOnLoad]
public class Startup : EditorWindow
{
    static Startup()
    {
        if (PlayerPrefs.GetString("Registered") == "")
        {
            Debug.LogError("Project ID Is Required! Please go to canopy.tools/register to obtain a new Project ID");
            // Get existing open window or if none, make a new one:
            EditorApplication.ExecuteMenuItem("Window/CanopyServerSettings");
        }
    }
}
#endif