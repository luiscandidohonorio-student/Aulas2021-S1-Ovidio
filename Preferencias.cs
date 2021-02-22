using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Preferencias : MonoBehaviour
{
    public InputField ifNome;
    public InputField ifVidas;
    public Dropdown ddDificuldade;
    public Toggle tgSom;
    public Slider slVolume;

    public void SavePrefs() {

        PlayerPrefs.SetString("Nome", ifNome.text);
        PlayerPrefs.SetInt("Vidas", int.Parse(ifVidas.text));
        PlayerPrefs.SetInt("Dificuldade", ddDificuldade.value);
        PlayerPrefs.SetString("Som", tgSom.isOn.ToString());
        PlayerPrefs.SetFloat("Volume", slVolume.value);

    }

    public void LoadPrefs() {

        ifNome.text = PlayerPrefs.GetString("Nome", "Jogador");
        ifVidas.text = PlayerPrefs.GetInt("Vidas", 1).ToString();
        ddDificuldade.value = PlayerPrefs.GetInt("Dificuldade", 1);
        tgSom.isOn = bool.Parse(PlayerPrefs.GetString("Som", true.ToString()));
        slVolume.value = PlayerPrefs.GetFloat("Volume", 0.5f);

    }

    public void SetDefalts() {

        PlayerPrefs.DeleteAll();
        LoadPrefs();

    }

}
