using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour{
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private GameObject Skip;


    public void Update(){
        if(scriptbtnnext.indexDialogue > 3){
            textComponent.text = "FIN";
            Destroy(GameObject.Find("ButtonNext(Clone)"));
        }
        else{
            textComponent.text = Dialogues.dialogues[scriptbtnnext.indexDialogue];
            Debug.Log(textComponent.text);
        }
      
    }
}