using System.IO;
using UnityEngine;
 

public class LevelDataWriter : MonoBehaviour
{
    private string filePath = "Assets/LevelData.txt"; // Путь к файлу

    private void Start()
    {
        // Создаем пример информации об уровнях
        LevelData levelData = new LevelData();
        levelData.level1Passed = false;
        levelData.level2Passed = false;
        levelData.level3Passed = false;

        // Записываем информацию в файл
        WriteLevelDataToFile(levelData);
    }

    private void WriteLevelDataToFile(LevelData data)
    {
        // Преобразуем информацию об уровнях в строку
        string levelDataString = data.level1Passed.ToString() + "," +
                                 data.level2Passed.ToString() + "," +
                                 data.level3Passed.ToString();

        // Записываем строку в файл
        File.WriteAllText(filePath, levelDataString);
    }
}

public class LevelData
{
    public bool level1Passed;
    public bool level2Passed;
    public bool level3Passed;
}

