using UnityEditor;
using UnityEngine;

public class BuildClass
{
    public static void Build()
    {
        // �r���h�ΏۃV�[�����X�g
        string[] sceneList = {
            "./Assets/scenes/SampleScene.unity",
        };

        // ���s
        BuildPipeline.BuildPlayer(
            sceneList,                          //!< �r���h�ΏۃV�[�����X�g
            "C:/Unity/Build/Batch/BuildTest/StandaloneWindows/BuildTest.exe",   //!< �o�͐�
            BuildTarget.StandaloneWindows,      //!< �r���h�Ώۃv���b�g�t�H�[��
            BuildOptions.Development            //!< �r���h�I�v�V����
        );

        BuildPipeline.BuildPlayer(
            sceneList,
            "C:/Unity/Build/Batch/BuildTest/iOS",
            BuildTarget.iOS,
            BuildOptions.Development
        );
    }
}
