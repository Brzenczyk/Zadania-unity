using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIcontroler : MonoBehaviour
{ 
    public Slider _Musicslider, _SFXslider;

    public void ToggleMusic()
    {
        Audiomanager.Instace.ToggleMusic();
    }
    public void ToggleSFX()
    {
        Audiomanager.Instace.ToggleSFX();
    }
    public void MusicVolume()
    {
    Audiomanager.Instace.MusicVolume(_Musicslider.value);

    }
public void SFXVolume()
{
    Audiomanager.Instace.SFXVolume(_SFXslider.value);
}

}
