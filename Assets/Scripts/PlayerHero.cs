using UnityEngine;

namespace Dota2
{
    public class PlayerHero
    {
        private string playerName;
        private int playerLevel;
        private CharacteristicsHero playerClass;

        private int basedStrenght;
        private int basedAgility;
        private int basedIntelligence;

        private int basedHP;
        private int basedMP;
        private int basedHPRegen;
        private int basedMPRegen;

        private float baseMoveSpeed;
        private float baseAttack;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int PlayerLevel
        {
            get { return playerLevel; }
            set { playerLevel = value; }
        }

        public CharacteristicsHero PlayerClass
        {
            get { return playerClass; }
            set { playerClass = value; }
        }

        public int Strenght
        {
            get { return basedStrenght; }
            set { basedStrenght = value; }
        }

        public int Agility
        {
            get { return basedAgility; }
            set { basedAgility = value; }
        }

        public int Intelligence
        {
            get { return basedIntelligence; }
            set { basedIntelligence = value; }
        }

        public int HitPoint
        {
            get { return basedHP; }
            set { basedHP = value; }
        }

        public int ManaPoint
        {
            get { return basedMP; }
            set { basedMP = value; }
        }

        public int HPRegen
        {
            get { return basedHPRegen; }
            set { basedHPRegen = value; }
        }

        public int MPRegen
        {
            get { return basedMPRegen; }
            set { basedMPRegen = value; }
        }

        public float MoveSpeed
        {
            get { return baseMoveSpeed; }
            set { baseMoveSpeed = value; }
        }

        public float Attack
        {
            get { return baseAttack; }
            set { baseAttack = value; }
        }
    }
}

