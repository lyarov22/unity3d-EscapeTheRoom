using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public TextMesh level1;
    public TextMesh level2;
    private void Start()
    {
        // ��������� ���������� �� ������� �� �����
        LevelData levelData = LoadLevelData();

        // ���������� ���������� �� �������
        if (levelData.level1Passed)
        {
            // ��������, ���� ������� 1 �������
            level1.text = "������: �������";
        }
        else
        {
            // ��������, ���� ������� 1 �� �������
            level1.text = "������: �� �������";
        }

        if (levelData.level2Passed)
        {
            // ��������, ���� ������� 2 �������
            level2.text = "������: �������";
        }
        else
        {
            // ��������, ���� ������� 2 �� �������
            level2.text = "������: �� �������";
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

