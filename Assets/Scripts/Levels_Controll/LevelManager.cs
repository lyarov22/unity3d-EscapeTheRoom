using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{

    public TextMeshPro level1;
    public TextMeshPro level2;
    private void Start()
    {
        // ��������� ���������� �� ������� �� �����
        LevelData levelData = LoadLevelData();

        // ���������� ���������� �� �������
        if (levelData.level1Passed)
        {
            level1.SetText("������: �������");
        }
        else
        {
            level1.SetText("������: �� �������");
        }

        if (levelData.level2Passed)
        {
            level2.SetText("������: �������");
        }
        else
        {
            level2.SetText("������: �� �������");
        }

        // � ��� �����...
    }

    private LevelData LoadLevelData()
    {
        // ��������� ����� �� �����
        string levelDataString = File.ReadAllText("Assets/LevelData.txt");

        // ��������� ������ �� �������� ��� ������� ������
        string[] levelDataValues = levelDataString.Split(',');

        // ������� ������ LevelData � ����������� ��������
        LevelData levelData = new LevelData();
        levelData.level1Passed = bool.Parse(levelDataValues[0]);
        levelData.level2Passed = bool.Parse(levelDataValues[1]);
        levelData.level3Passed = bool.Parse(levelDataValues[2]);

        return levelData;
    }

     
}

