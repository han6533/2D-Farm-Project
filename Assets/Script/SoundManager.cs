using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    //public AudioMixer mixer;
    //[Header("?????")] public AudioClip SFX;
    //[Header("?? ?????")] public AudioClip Door;

    //public AudioClip TextSFX;
    public AudioClip ButtonSFX;

    [Header("BGM")] public AudioClip[] BgmClip;
    [Header("������ҽ�")] public AudioSource BGMSound;

    //public Slider Master_VoumeSlider;
    //public Slider BGM_VolumeSlider;
    //public Slider SFX_VolumeSlider;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        //if (mixer != null)
        //{
        //mixer.SetFloat("MasterSound", Mathf.Log(PlayerPrefs.GetFloat("MasterSound")) * 20);
        //mixer.SetFloat("BGMSound", Mathf.Log(PlayerPrefs.GetFloat("BGMSound")) * 20);
        //mixer.SetFloat("SFXSound", Mathf.Log(PlayerPrefs.GetFloat("SFXSound")) * 20);

        //    if (BGM_VolumeSlider != null)
        //    {
        //        Master_VoumeSlider.value = PlayerPrefs.GetFloat("MasterSound");
        //        BGM_VolumeSlider.value = PlayerPrefs.GetFloat("BGMSound");
        //        SFX_VolumeSlider.value = PlayerPrefs.GetFloat("SFXSound");
        //    }
        ////}

        if (SceneManager.GetActiveScene().name == "InGameScene")
        {
            //BGMSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGM")[0];
            BGMSound.clip = BgmClip[0];
        }
        BGMSound.Play();
    }
    //public void BattleBGM() //BGM ?�� ???? ???
    //{
    //    BGMSound.Stop();
    //    BGMSound.clip = BgmClip[1];
    //    BGMSound.outputAudioMixerGroup = mixer.FindMatchingGroups("BGM")[0];
    //    BGMSound.Play();
    //}
    public void SFXPlay(string sfxName, AudioClip clip)
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audiosourece = go.AddComponent<AudioSource>();
        //audiosourece.outputAudioMixerGroup = mixer.FindMatchingGroups("SFX")[0];
        audiosourece.clip = clip;
        audiosourece.Play();
        Destroy(go, clip.length);
    }

    //public void SetMasterVolme(float MasterVolume)
    //{
    //    //MasterVolume = Master_VoumeSlider.value += 0.1f;
    //    //mixer.SetFloat("MasterSound", Mathf.Log(MasterVolume) * 20);
    //    PlayerPrefs.SetFloat("MasterSound", MasterVolume);
    //}
    //public void SetBGMVolme(float BGMVolume)
    //{
    //    //BGMVolume = BGM_VolumeSlider.value += 0.1f;
    //    //mixer.SetFloat("BGMSound", Mathf.Log(BGMVolume) * 20);
    //    PlayerPrefs.SetFloat("BGMSound", BGMVolume);
    //}
    //public void SetBGMVolmeDown()
    //{
    //    float BGMVolume = BGM_VolumeSlider.value -= 0.1f;
    //    mixer.SetFloat("BGMSound", Mathf.Log(BGMVolume) * 20);
    //    PlayerPrefs.SetFloat("BGMSound", BGMVolume);
    //}
    //public void SetSFXVolme(float SFXVolume)
    //{
    //    //SFXVolume = SFX_VolumeSlider.value += 0.1f;
    //    //mixer.SetFloat("SFXSound", Mathf.Log(SFXVolume) * 20);
    //    PlayerPrefs.SetFloat("SFXSound", SFXVolume);
    //}
    //public void SetSFXVolmeDown()
    //{
    //    float SFXVolume = SFX_VolumeSlider.value -= 0.1f;
    //    mixer.SetFloat("SFXSound", Mathf.Log10(SFXVolume) * 20);
    //    PlayerPrefs.SetFloat("SFXSound", SFXVolume);
    //}


    //SoundManager.Instance.SFXPlay("Btn", SoundManager.Instance.Btn); SFX ??? ??? ??? 
}
