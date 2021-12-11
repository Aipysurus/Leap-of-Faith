using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private Text textLabel;

    private void Start()
    {
        GetComponent<TypewriterEffect>().Run("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse accumsan quam quis varius scelerisque. Nullam pharetra iaculis purus sed rutrum.", textLabel);
    }
}
