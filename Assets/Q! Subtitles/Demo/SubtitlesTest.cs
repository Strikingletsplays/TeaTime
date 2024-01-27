using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitlesTest : MonoBehaviour
{
    [Tooltip("Custom font to show in the test scene.")] public Font alternateFont;
    [Tooltip("Custom clip to play in the test scene.")] public AudioClip testTrack;
    [Tooltip("Subtitle related variables. Do not modify.")] public InputField input, delay;

    public void Print(int index)
    {
        if (!float.TryParse(delay.text, out float t)) t = 3f;
        Subtitles.Show(input.text, t, (SubtitleEffect)index);
        input.text = delay.text = "";
    }

    public void Randomize()
    {
        switch (Random.Range(0, 10))
        {
            case 0:
                Subtitles.Show("<color=red>[A]:</color> Welcome to the Q! Subtitle system!", 5f, SubtitleEffect.Fade);
                break;
            case 1:
                Subtitles.Show("<color=blue>[B]:</color> You can use rich text to change color!", 5f, SubtitleEffect.Fade);
                break;
            case 2:
                Subtitles.Show("<color=green>[C]:</color> You can use rich text to change <size=30>size</size>!", 5f, SubtitleEffect.Fade);
                break;
            case 3:
                Subtitles.Show("<color=magenta>[D]:</color> Well hello there!", 5f, SubtitleEffect.Fade);
                break;
            case 4:
                Subtitles.Show("<color=yellow>[E]:</color> You can choose not to have fading effect!", 5f, SubtitleEffect.None);
                break;
            case 5:
                Subtitles.Show("<color=orange>[F]:</color> You can choose type the text!", 5f, SubtitleEffect.Type);
                break;
            case 6:
                Subtitles.Show("<color=purple>[G]:</color> You can choose fade <b>and</b> type the text!", 5f, SubtitleEffect.Both);
                break;
            case 7:
                Subtitles.Show("<color=aqua>[H]:</color> You use another font!", 5f, SubtitleEffect.Fade, 20, alternateFont);
                break;
            case 8:
                Subtitles.Show("<color=lightBlue>[I]:</color> You can alternate size!", 5f, SubtitleEffect.Fade, 40);
                break;
            case 9:
                Subtitles.Show("<color=grey>[J]:</color> You can use sounds!", 5f, SubtitleEffect.Fade, 20, null, testTrack);
                break;
        }
    }
}
