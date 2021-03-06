﻿
using UnityEngine;


//------------------------------------------------------------
// TIPS:
// スクリプトが設定されていれば、シーン開始時に
// インスペクターに設定された内容で ItemManager に自身を登録する

public class ItemState : MonoBehaviour {

  ItemManager manager { get { return ItemManager.instance; } }

  [SerializeField]
  Sprite _sprite = null;
  public Sprite sprite { get { return _sprite; } }

  [SerializeField]
  ItemName _itemName = ItemName.Empty;
  public ItemName itemName { get { return _itemName; } }

  [SerializeField]
  [Multiline(2)]
  string _itemInfo = string.Empty;
  public string itemInfo { get { return _itemInfo; } }

  public bool hasItem { get; private set; }
  public void UpdateState(bool newState) { hasItem = newState; }


  void Start() {
    hasItem = false;
    manager.items.Add(_itemName, this);
  }
}
