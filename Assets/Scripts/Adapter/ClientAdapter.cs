using UnityEngine;

public class ClientAdapter : MonoBehaviour
{
    public InventoryItem item;
    private InventorySystem inventorySystem;
    private IInventorySystem inventorySystemAdapter;

    private void Awake()
    {
        inventorySystem = new InventorySystem();
        inventorySystemAdapter = new InventorySystemAdapter();
    }

    private void OnGUI()
    {
        if(GUILayout.Button("Add item (no adapter)"))
            inventorySystem.AddItem(item);

        if (GUILayout.Button("Add item (with adapter)"))
            inventorySystemAdapter.AddItem(item, SaveLocation.Both);
    }
}
