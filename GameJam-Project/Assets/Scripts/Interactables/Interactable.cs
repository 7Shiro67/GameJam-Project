using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    [Header("Tips")]
    [SerializeField] private GameObject tipsPrefab;
    private GameObject tipsInstance;

    [Header("DialogBox")]
    [SerializeField] private GameObject dialogBox;
    [SerializeField] private Text dialogBoxText;
    [SerializeField] private string text;
    [HideInInspector] public bool canInteract;


    void Start()
    {
        
    }

    void Update()
    {
        dialog();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            if (tipsInstance == null)
            {
                tipsInstance = Instantiate(tipsPrefab, transform.position + new Vector3(0, 3.5f), Quaternion.identity);
            }
            canInteract = true;

            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.canInteract = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            if (tipsInstance != null)
            {
                Destroy(tipsInstance);
                tipsInstance = null;
            }
            canInteract = false;

            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.canInteract = false;
            }
        }

    }
    public void dialog()
    {
        if (Input.GetKeyDown(KeyCode.F) && canInteract)
        {
            dialogBoxText.text = text;
            dialogBox.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            return;
        }
        if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.F))
        {
            dialogBox.SetActive(false);
        }
    }

}
