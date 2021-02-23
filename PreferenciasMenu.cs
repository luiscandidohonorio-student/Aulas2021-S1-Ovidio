using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreferenciasMenu : MonoBehaviour
{
    public InputField ifScore;
    public InputField ifLevel;
    public Dropdown ddFase;
    public Toggle tgSom;
    public Slider slVolume;

    public void SavePrefs() {

        PlayerPrefs.SetString("Score", ifScore.text);
        PlayerPrefs.SetInt("Level", int.Parse(ifLevel.text));
        PlayerPrefs.SetInt("Fase", ddFase.value);
        PlayerPrefs.SetString("Som", tgSom.isOn.ToString());
        PlayerPrefs.SetFloat("Volume", slVolume.value);

    }

    public void LoadPrefs() {

        ifScore.text = PlayerPrefs.GetString("Score");
        ifLevel.text = PlayerPrefs.GetInt("Level", 1).ToString();
        ddFase.value = PlayerPrefs.GetInt("Fase", 1);
        tgSom.isOn = bool.Parse(PlayerPrefs.GetString("Som", true.ToString()));
        slVolume.value = PlayerPrefs.GetFloat("Volume", 0.5f);

    }

    public void SetDefalts() {

        PlayerPrefs.DeleteAll();
        LoadPrefs();

    }

}
