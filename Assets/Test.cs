using UnityEngine;
using Steamworks;

public class Test : MonoBehaviour
{
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.Label($"Steam name: {SteamClient.Name}");
        GUILayout.EndArea();
    }
}
