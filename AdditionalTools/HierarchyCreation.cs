using System.IO;
using UnityEngine;

public class HierarchyCreation : MonoBehaviour
{
    private void Start()
    {
        CreatePrefabsFolder();
        CreateScriptsFolder();
        CreateOthersFolder();
        CreateDataFolder();
    }

    private void CreatePrefabsFolder()
    {
        if (!File.Exists(Application.dataPath + "/Prefabs")) Directory.CreateDirectory(Application.dataPath + "/Prefabs");
        C_Prefabs_F_Child();
    }

    private void C_Prefabs_F_Child()
    {
        if (!File.Exists(Application.dataPath + "/Prefabs/Pre_Enemy")) Directory.CreateDirectory(Application.dataPath + "/Prefabs/Pre_Enemy");
        if (!File.Exists(Application.dataPath + "/Prefabs/Pre_Other")) Directory.CreateDirectory(Application.dataPath + "/Prefabs/Pre_Other");
        if (!File.Exists(Application.dataPath + "/Prefabs/Pre_UI")) Directory.CreateDirectory(Application.dataPath + "/Prefabs/Pre_UI");
    }

    private void CreateScriptsFolder()
    {
        if (!File.Exists(Application.dataPath + "/Scripts")) Directory.CreateDirectory(Application.dataPath + "/Scripts");
        C_Scripts_F_Child();
    }

    private void C_Scripts_F_Child()
    {
        if (!File.Exists(Application.dataPath + "/Scripts/Scr_Controllers")) Directory.CreateDirectory(Application.dataPath + "/Scripts/Scr_Controllers");
        if (!File.Exists(Application.dataPath + "/Scripts/Scr_Interface")) Directory.CreateDirectory(Application.dataPath + "/Scripts/Scr_Interface");
        if (!File.Exists(Application.dataPath + "/Scripts/Scr_Other")) Directory.CreateDirectory(Application.dataPath + "/Scripts/Scr_Other");
    }

    private void CreateOthersFolder()
    {
        if (!File.Exists(Application.dataPath + "/Other")) Directory.CreateDirectory(Application.dataPath + "/Other");
        C_Others_F_Child();
    }

    private void C_Others_F_Child()
    {
        if (!File.Exists(Application.dataPath + "/Other/Animations")) Directory.CreateDirectory(Application.dataPath + "/Other/Animations");
        if (!File.Exists(Application.dataPath + "/Other/Materials")) Directory.CreateDirectory(Application.dataPath + "/Other/Materials");
        if (!File.Exists(Application.dataPath + "/Other/ScriptableObjects")) Directory.CreateDirectory(Application.dataPath + "/Other/ScriptableObjects");
        if (!File.Exists(Application.dataPath + "/Other/Textures")) Directory.CreateDirectory(Application.dataPath + "/Other/Textures");
        if (!File.Exists(Application.dataPath + "/Other/UI")) Directory.CreateDirectory(Application.dataPath + "/Other/UI");
    }

    private void CreateDataFolder()
    {
        if (!File.Exists(Application.dataPath + "/data")) Directory.CreateDirectory(Application.dataPath + "/data");
    }
}