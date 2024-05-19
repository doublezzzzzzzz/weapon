using System;
using System.Collections.Generic;

//библиотека 
namespace lab3_THI
{
    public class Division { public List <AbstructWeapon> weaponList =  new List <AbstructWeapon>(); }


    public abstract class AbstructWeapon
    {
        public AbstructWeapon() { }
        protected string _name;
        protected int _size;
        protected float _price;

        public string Name { 
        set {  _name = value; }
        get { return _name; }
        }

        public int Size
        {
            set { _size = value; }
            get { return _size; }
        }

        public float Price
        {
            set { _price = value; }
            get { return _price; }
        }
    }

    public class BladedWeapon : AbstructWeapon 
    {
        public BladedWeapon() { }
        private float _lenght;
        private int _handCount;
        
        public float Lenght {
            set { _lenght = value; }
            get { return _lenght; }
        }
        public int HandCount {
            get { return _handCount; }
            set { _handCount = value; } 
        }

        public void Attack() { Console.WriteLine("Attack"); }
    }

    public class Firearms : AbstructWeapon
    {
        public Firearms() { }
        protected float _calibre;
        protected int _nimberRounds;
        protected int _maxRounds;
       
        public float Calibre {
            get { return _calibre; }
            set { _calibre = value; }
        }
        public int NumberRounds {
            get { return _nimberRounds; }
            set { _nimberRounds = value; }
        }
        public int MaxRounds {
            get { return _maxRounds; }
            set { _maxRounds = value; }
        }
        public void Shoot() { Console.WriteLine("Shoot"); }
        public void Reload() { Console.WriteLine("Reload"); }
    }

    public class HighPrecisionWeapon : Firearms
    {
        public HighPrecisionWeapon() { }
        private float _accurace;
        public float Accuracy {
            get { return _accurace; }
            set { _accurace = value; }
        }
    }
}