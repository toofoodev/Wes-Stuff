using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomMessage : MonoBehaviour
{
    [Header("Random Message - WesGoof")]
    public TextMeshPro messageText;
    public List<string> messages;

    private void Start()
    {
        messageText.text = messages[UnityEngine.Random.Range(0, messages.Count)];
    }
}