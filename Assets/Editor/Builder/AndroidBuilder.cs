using UnityEditor;
class AndroidBuilder
{
    static void ProductionBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/Scene1.unity", "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "E:\MyProjects\CICD\Builds\builds\CICDTest.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}