using UnityEngine;
using TMPro;

public class scriptbtn : MonoBehaviour
{
    [SerializeField] GameObject Start;
    [SerializeField] GameObject Skip;
    [SerializeField] GameObject DialogueBoxContainer;
    [SerializeField] GameObject parent;
    public void Click(){
        Destroy(Start);

        var dialogue = Instantiate(DialogueBoxContainer);
        dialogue.transform.SetParent(parent.transform);
        var dialrect = dialogue.GetComponent<RectTransform>();
        dialrect.localPosition = new Vector3(0.5f, -398f, 0f);

        var skip = Instantiate(Skip);
        skip.transform.SetParent(parent.transform);
        var skiprect = skip.GetComponent<RectTransform>(); 
        skiprect.localPosition = new Vector3(1017f, -564f, 0f);
    }
}
