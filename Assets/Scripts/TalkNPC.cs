using UnityEngine;
using System.IO;

public class TalkNPC : MonoBehaviour
{
    public string[] chat;
    private InputManager _input;
    public int _chatNumber = 0;
    private bool _chatPossible = false;
    void Start()
    {
        _input = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.interactPressed && _chatPossible == true)
        {
                Debug.Log(chat[_chatNumber]);
                _chatPossible = false;
                if(_chatNumber < chat.Length - 1)
                {
                    _chatNumber += 1;
                }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.transform.CompareTag("NPC1"))
        {
            _chatPossible = true;
        }
    }

    private void OnTriggerExit2D (Collider2D coll)
    {
        if (coll.transform.CompareTag("NPC1"))
        {
            _chatPossible = false;
        }
    }
}
