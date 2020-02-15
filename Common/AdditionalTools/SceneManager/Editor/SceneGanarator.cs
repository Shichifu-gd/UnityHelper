using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class SceneGanarator
{
    static SceneGanarator()
    {
        EditorSceneManager.newSceneCreated += SceneCreating;
    }

    public static void SceneCreating(Scene scene, NewSceneSetup setup, NewSceneMode mode)
    {
        var cameraGO = Camera.main.transform;
        var lightGO = GameObject.Find("Directional Light").transform;

        var setupFolder = new GameObject("[SETUP]").transform;
        var light = new GameObject("Light").transform;
        var camera = new GameObject("Cameras").transform;
        light.parent = setupFolder;
        lightGO.parent = light;
        camera.parent = setupFolder;
        cameraGO.parent = camera;

        var worldFolder = new GameObject("[World]").transform;
        new GameObject("Static").transform.parent = worldFolder;
        new GameObject("Dynamic").transform.parent = worldFolder;

        new GameObject("[UI]");
        Debug.Log("NewScene");
    }
}