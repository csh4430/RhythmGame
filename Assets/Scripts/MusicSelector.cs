using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSelector : MonoBehaviour
{
    public int Tag { get; private set; }
    public Button MusicSelectButton { get; private set; }
    public Text MusicName { get; private set; }
    public Text ComposerName { get; private set; }
    public Text ClearText { get; private set; }

    private void Awake()
    {
        Tag = 0;
        MusicSelectButton = GetComponent<Button>();
        MusicName = transform.GetChild(0).GetChild(0).GetComponent<Text>();
        ComposerName = transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<Text>();
        ClearText = transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<Text>();
    }

    public void WriteDesc(int tag, string title, string composer, bool clear)
    {
        Tag = tag;
        MusicName.text = title;
        ComposerName.text = composer;
        ClearText.text = clear ? "Clear" : "";
    }
}
