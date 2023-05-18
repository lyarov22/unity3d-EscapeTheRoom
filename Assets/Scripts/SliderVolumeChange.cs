using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class SliderVolumeChange : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider MasterVolumeSlider;
    public Slider MusicSlider;

    private void Start()
    {
        MasterVolumeSlider.onValueChanged.AddListener(OnSlider1ValueChanged);
        MusicSlider.onValueChanged.AddListener(OnSlider2ValueChanged);
    }

    private void OnSlider1ValueChanged(float value)
    {
        float mappedValue = Remap(value, 0f, 1f, -80f, 0f); // Преобразование значения слайдера в диапазон громкости микшера
        mixer.SetFloat("MasterVolume", mappedValue); // Замените "Parameter1" на имя вашего параметра в микшере
    }

    private void OnSlider2ValueChanged(float value)
    {
        float mappedValue = Remap(value, 0f, 1f, -80f, 0f); // Преобразование значения слайдера в диапазон громкости микшера
        mixer.SetFloat("MusicVolume", mappedValue); // Замените "Parameter2" на имя вашего параметра в микшере
    }

    // Метод для преобразования значения из одного диапазона в другой
    private float Remap(float value, float inputMin, float inputMax, float outputMin, float outputMax)
    {
        return outputMin + (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin);
    }
}
