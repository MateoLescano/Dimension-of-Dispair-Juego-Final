using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject optionsCanvas;
    [SerializeField] private AudioMixer audioMixer;

    public Resolution resolution;
    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;


    private void Awake()
    {
        Screen.SetResolution(1920, 1080, true);
        
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].height ==Screen.currentResolution.height && resolutions[i].width == Screen.currentResolution.width)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        if(resolutions != null){
            resolution = resolutions[resolutionIndex];
            Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        }else{
            Screen.SetResolution(1920, 1080, true);
        }

    }


    public void GoToOptions()
    {
        mainCanvas.SetActive(false);
        optionsCanvas.SetActive(true);

    }

    public void Fullscreen(bool fullscreen)
    {
       
        Screen.fullScreen = fullscreen;
        Debug.Log(Screen.fullScreen);
    }

    public void SetMasterVolume(float sliderValue)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20f);
    }
}
