using System.IO;
using UnityEngine;
 

public class LevelDataWriter : MonoBehaviour
{
    private string filePath = "Assets/LevelData.txt"; // ���� � �����

    private void Start()
    {
        // ������� ������ ���������� �� �������
        LevelData levelData = new LevelData();
        levelData.level1Passed = false;
        levelData.level2Passed = false;
        levelData.level3Passed = false;

        // ���������� ���������� � ����
        WriteLevelDataToFile(levelData);
    }

    private void WriteLevelDataToFile(LevelData data)
    {
        // ����������� ���������� �� ������� � ������
        string levelDataString = data.level1Passed.ToString() + "," +
                                 data.level2Passed.ToString() + "," +
                                 data.level3Passed.ToString();

        // ���������� ������ � ����
        File.WriteAllText(filePath, levelDataString);
    }
}

public class LevelData
{
    public bool level1Passed;
    public bool level2Passed;
    public bool level3Passed;
}

