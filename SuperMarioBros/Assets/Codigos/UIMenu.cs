using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIMenu : MonoBehaviour
{
    
    private UIDocument menu;
    private Button Jugar;
    private Button Ayuda;
    private Button Creditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        Jugar = root.Q<Button>("Jugar");
        Ayuda = root.Q<Button>("Ayuda");
        Creditos = root.Q<Button>("Creditos");

        //Callback
        Jugar.RegisterCallback<ClickEvent>(AbrirJugar);
      

    }

    private void AbrirJugar (ClickEvent evt)
    {
        SceneManager.LoadScene("SampleScene");
    }

}
