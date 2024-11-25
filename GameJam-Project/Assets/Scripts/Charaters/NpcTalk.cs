using NodeCanvas.DialogueTrees;
using NodeCanvas.DialogueTrees.UI.Examples;
using UnityEngine;

public class NpcTalk : MonoBehaviour
{
    public HUD hud;
    public DialogueUGUI ugui;
    [SerializeField] DialogueTreeController dialogue;
    private bool isEnter;
    public GameObject nameUI;



    private void Awake()
    {
        hud = FindObjectOfType<HUD>();
        ugui = FindObjectOfType<DialogueUGUI>();

    }

    private void Update()
    {
        if(isEnter&&Input.GetKeyDown(KeyCode.F))
        {
            dialogue.StartDialogue();
            nameUI.SetActive(false);
            hud.talkUI.SetActive(false);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            isEnter = true;
            nameUI.SetActive(true);
            hud.talkUI.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            isEnter = false;
            nameUI.SetActive(false);
            hud.talkUI.SetActive(false);
        }
    }
}
