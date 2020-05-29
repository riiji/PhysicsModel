using UnityEngine;
using UnityEngine.UI;

public class RestartController : MonoBehaviour
{
    private Button _button;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
