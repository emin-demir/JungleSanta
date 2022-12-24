using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot_Item : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private Item ItemTable;
    public Image Ana_icon;
    public GameObject Aciklama_canvas;
    public Text Aciklama;

    HouseSelect houseSelect;

  
    public void OnPointerEnter(PointerEventData eventData)
    {
       Aciklama_canvas.SetActive(true);

    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
       Aciklama_canvas.SetActive(false);
    }


    public void Item_Use()
    {
        Debug.Log(ItemTable.ItemAdi + " İsimli Item Kullanıldı" + " House"+houseSelect.house);
        if(houseSelect.house == int.Parse(ItemTable.ItemAdi))
        {
            Destroy(gameObject);
        }
    }
    public void Item_Remove()
    {
        Debug.Log(ItemTable.ItemAdi + " İsimli Item silindi");
        
    }


    void Start()
    {
       Aciklama_canvas.SetActive(false);
       Ana_icon.sprite=ItemTable.Item_image;
       Aciklama.text = ItemTable.Item_aciklama;
    }

    void Update()
    {
       houseSelect = GameObject.Find(ItemTable.ItemAdi).GetComponent<HouseSelect>();
        
    }
}
