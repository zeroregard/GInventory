﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GInventory
{
    public enum EquippableSlotType
    {
        Head,
        Chest,
        Legs,
        Feet
    }
    [CreateAssetMenu(fileName = "New equippable", menuName = "GInventory/Equippable")]
    public class EquippableType : ItemType
    {
        public EquippableSlotType Slot;
        public override bool CanMove(ItemInstance itemInstance)
        {
            var asEquippable = itemInstance.ItemType.Value as EquippableType;
            if(itemInstance.ItemType.Value == null)
            {
                return true;
            }
            if(asEquippable != null)
            {
                if(asEquippable.Slot == Slot)
                {
                    return true;
                }
            }
            return false;
        }
    }
}