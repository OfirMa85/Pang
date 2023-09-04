using UnityEngine;

public class MenuView : MonoBehaviour
{
    public void ToggleMenu(int index, bool toggle)
    {
        GameObject child = transform.GetChild(index).gameObject;
        child.SetActive(toggle);
    }
}
