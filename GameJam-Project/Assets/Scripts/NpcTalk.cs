using NodeCanvas.DialogueTrees;
using NodeCanvas.DialogueTrees.UI.Examples;
using UnityEngine;

public class NpcTalk : MonoBehaviour
{
    public HUD hud;
    public DialogueUGUI ugui;
    [SerializeField] DialogueTreeController dialogue;


    private void Awake()
    {
        hud = FindObjectOfType<HUD>();
        ugui = FindObjectOfType<DialogueUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            hud.talkUI.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player")&&Input.GetKeyDown(KeyCode.F))
        {
            dialogue.StartDialogue();
            hud.talkUI.SetActive(false);
        }
        if(!ugui.isRunning)
        {
            hud.talkUI.SetActive(true);
        }
  
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            hud.talkUI.SetActive(false);
        }
    }
}
