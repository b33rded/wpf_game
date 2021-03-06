﻿namespace Core.Models
{
    public class Weapon : Item
    {
        public int MinDamage { get; }
        public int MaxDamage { get; }
        
        public Weapon(int itemTypeId, string name, int price, int minDamage, int maxDamage) 
            : base(itemTypeId, name, price, true)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinDamage, MaxDamage);
        }
    }
}