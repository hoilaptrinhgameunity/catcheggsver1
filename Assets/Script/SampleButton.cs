﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SampleButton : MonoBehaviour {

	public Button button;
	public Text nameLabel;
	public Text priceLabel;
	public Image iconImage;

	private Item item;
	private ShopScrollList scrollList;
	// Use this for initialization
	void Start () 
	{
		button.onClick.AddListener (HandleClick);
	}

	public void Setup(Item currentItem, ShopScrollList currentScrollList)
	{
		item = currentItem;
		nameLabel.text = item.itemName;
		priceLabel.text = item.price.ToString ();
		iconImage.sprite = item.icon;

		scrollList = currentScrollList;
	}

	public void HandleClick()
	{
		scrollList.TryTransferItemToOtherShop (item);
	}
}