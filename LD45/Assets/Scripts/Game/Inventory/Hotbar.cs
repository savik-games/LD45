﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hotbar : Inventory {
	public byte SelectedSlotId;
	public UnityEvent OnSelectionChange;

	void Awake() {
		SelectedSlotId = 0;
	}

	void Start() {
		OnSelectionChange?.Invoke();
	}

	public void SetSelection(int id) { //Arrr!111! Unity dont show it in editor if [id] is [byte]
		SelectedSlotId = (byte)id;
		GameManager.Instance.Player.Equipment.EquipItem(Items[SelectedSlotId]);
		OnSelectionChange?.Invoke();
	}
}
