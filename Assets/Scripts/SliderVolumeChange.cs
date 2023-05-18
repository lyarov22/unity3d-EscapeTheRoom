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
        float mappedValue = Remap(value, 0f, 1f, -80f, 0f); // �������������� �������� �������� � �������� ��������� �������
        mixer.SetFloat("MasterVolume", mappedValue); // �������� "Parameter1" �� ��� ������ ��������� � �������
    }

    private void OnSlider2ValueChanged(float value)
    {
        float mappedValue = Remap(value, 0f, 1f, -80f, 0f); // �������������� �������� �������� � �������� ��������� �������
        mixer.SetFloat("MusicVolume", mappedValue); // �������� "Parameter2" �� ��� ������ ��������� � �������
    }

    // ����� ��� �������������� �������� �� ������ ��������� � ������
    private float Remap(float value, float inputMin, float inputMax, float outputMin, float outputMax)
    {
        return outputMin + (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin);
    }
}
