using UnityEngine;
using UnityEditor;
using System.Linq;
public class APKBuild
{

    public static void BuildAndroid()
    {

        //string[] levels = {"Assets/Scene/Level_01.unity", "Assets/Scene/Level_02.unity"};
        string[] levels = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        BuildPipeline.BuildPlayer(levels, "SHAFIK_IS_UNITY.apk", BuildTarget.Android, BuildOptions.None);

    }

}
