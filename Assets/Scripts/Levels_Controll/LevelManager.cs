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
        // Загружаем информацию об уровнях из файла
        LevelData levelData = LoadLevelData();

        // Используем информацию об уровнях
        if (levelData.level1Passed)
        {
            // Действия, если уровень 1 пройден
            level1.text = "Статус: пройден";
        }
        else
        {
            // Действия, если уровень 1 не пройден
            level1.text = "Статус: не пройден";
        }

        if (levelData.level2Passed)
        {
            // Действия, если уровень 2 пройден
            level2.text = "Статус: пройден";
        }
        else
        {
            // Действия, если уровень 2 не пройден
            level2.text = "Статус: не пройден";
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

