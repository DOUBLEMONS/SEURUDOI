using System.Collections;
using System.Collections.Generic;
using Unity.Services.CloudSave;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    [Header("Title_Screen")]
    public Slider BackgroundMusic_Volume;
    public Slider EffectSound_MusicVolume;

    // Title_Screen
    public async void Title_Screen_SaveSomeData()
    {
        // Music & Sound
        var data = new Dictionary<string, object> { { "BackgroundMusic_Volume", BackgroundMusic_Volume.value } };
        var data1 = new Dictionary<string, object> { { "EffectSound_MusicVolume", EffectSound_MusicVolume.value } };
        await CloudSaveService.Instance.Data.ForceSaveAsync(data);
        await CloudSaveService.Instance.Data.ForceSaveAsync(data1);
    }

    public async void Title_Screen_LoadSomeData()
    {
        // Music & Sound
        Dictionary<string, string> savedData = await CloudSaveService.Instance.Data.LoadAsync(new HashSet<string> { "BackgroundMusic_Volume" });
        Dictionary<string, string> savedData1 = await CloudSaveService.Instance.Data.LoadAsync(new HashSet<string> { "EffectSound_MusicVolume" });

        Debug.Log("Done: " + savedData["BackgroundMusic_Volume"]);
        Debug.Log("Done: " + savedData1["EffectSound_MusicVolume"]);

        float BM = float.Parse(savedData["BackgroundMusic_Volume"]);
        float ES = float.Parse(savedData1["EffectSound_MusicVolume"]);

        BackgroundMusic_Volume.value = BM;
        EffectSound_MusicVolume.value = ES;

        savedData["BackgroundMusic_Volume"].ToString();
        savedData1["EffectSound_MusicVolume"].ToString();
    }

    public async void Title_Screen_DeleteSomeData()
    {
        // Music & Sound
        await CloudSaveService.Instance.Data.ForceDeleteAsync("BackgroundMusic_Volume");
        await CloudSaveService.Instance.Data.ForceDeleteAsync("EffectSound_MusicVolume");
    }
}
