using UnityEngine;
using TMPro;

public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    int damage = 100;
    float time = 30.5f;
    string name = "�ؽ�Ʈ";
    private void Start()
    {
        Debug.Log("�������� ��" + damage);
        Debug.Log("�ð��� ��" + time);
        Debug.Log("�̸�" + name);
        text.text = string.Format($"Only{damage} English{time} is vislble : �����̴�?");
    }
}
