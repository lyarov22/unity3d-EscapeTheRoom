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
        // Загружаем информацию об уровнях из файла
        LevelData levelData = LoadLevelData();

        // Используем информацию об уровнях
        if (levelData.level1Passed)
        {
            level1.SetText("Статус: пройден");
        }
        else
        {
            level1.SetText("Статус: не пройден");
        }

        if (levelData.level2Passed)
        {
            level2.SetText("Статус: пройден");
        }
        else
        {
            level2.SetText("Статус: не пройден");
        }

        // И так далее...
    }

    private LevelData LoadLevelData()
    {
        // Загружаем текст из файла
        string levelDataString = File.ReadAllText("Assets/LevelData.txt");

        // Разделяем строку на значения для каждого уровня
        string[] levelDataValues = levelDataString.Split(',');

        // Создаем объект LevelData и присваиваем значения
        LevelData levelData = new LevelData();
        levelData.level1Passed = bool.Parse(levelDataValues[0]);
        levelData.level2Passed = bool.Parse(levelDataValues[1]);
        levelData.level3Passed = bool.Parse(levelDataValues[2]);

        return levelData;
    }

     
}

