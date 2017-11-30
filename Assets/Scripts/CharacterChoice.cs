using UnityEngine;
using UnityEngine.UI;

namespace Dota2
{
    public class CharacterChoice : MonoBehaviour
    {
        private GameObject hero;
        public GameObject spawnPoint;

        private PlayerHero newPlayer;

        public Text strengthText;
        public Text agilityText;
        public Text intelligenceText;
        public Text moveSpeedText;
        public Text baseDamageText;
        public Text heroName;

        private void Start()
        {
            newPlayer = new PlayerHero();
        }

        public void ChoiceCapsule()
        {
            newPlayer.PlayerName = "Capsule";
            if (hero == null)
            {
                hero = Instantiate(Resources.Load("Prefabs/" + newPlayer.PlayerName), spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }

            else if (hero != null)
            {
                DestroyGameObject(hero);
                hero = Instantiate(Resources.Load("Prefabs/" + newPlayer.PlayerName), spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }
            newPlayer.PlayerClass = new CapsuleHero();
            newPlayer.Strenght = newPlayer.PlayerClass.Strenght;
            newPlayer.Agility = newPlayer.PlayerClass.Agility;
            newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.HitPoint = newPlayer.PlayerClass.HitPoint;
            newPlayer.ManaPoint = newPlayer.PlayerClass.ManaPoint;
            newPlayer.HPRegen = newPlayer.PlayerClass.HPRegen;
            newPlayer.MPRegen = newPlayer.PlayerClass.MPRegen;
            newPlayer.MoveSpeed = newPlayer.PlayerClass.MoveSpeed;
            newPlayer.Attack = newPlayer.PlayerClass.Attack;
            UpdateUI();
        }

        public void ChoiceCube()
        {
            newPlayer.PlayerName = "Cube";
            if (hero == null)
            {
                hero = Instantiate(Resources.Load("Prefabs/" + newPlayer.PlayerName), spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }

            else if (hero != null)
            {
                DestroyGameObject(hero);
                hero = Instantiate(Resources.Load("Prefabs/" + newPlayer.PlayerName), spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }
            newPlayer.PlayerClass = new CubeHero();
            newPlayer.Strenght = newPlayer.PlayerClass.Strenght;
            newPlayer.Agility = newPlayer.PlayerClass.Agility;
            newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.HitPoint = newPlayer.PlayerClass.HitPoint;
            newPlayer.ManaPoint = newPlayer.PlayerClass.ManaPoint;
            newPlayer.HPRegen = newPlayer.PlayerClass.HPRegen;
            newPlayer.MPRegen = newPlayer.PlayerClass.MPRegen;
            newPlayer.MoveSpeed = newPlayer.PlayerClass.MoveSpeed;
            newPlayer.Attack = newPlayer.PlayerClass.Attack;
            UpdateUI();
        }

        public void ChoiceCylinder()
        {
            newPlayer.PlayerName = "Cylinder";
            if (hero == null)
            {
                hero = Instantiate(Resources.Load("Prefabs/" + newPlayer.PlayerName), spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }

            else if (hero != null)
            {
                DestroyGameObject(hero);
                hero = Instantiate(Resources.Load("Prefabs/" + newPlayer.PlayerName), spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }
            newPlayer.PlayerClass = new  CylinderHero();
            newPlayer.Strenght = newPlayer.PlayerClass.Strenght;
            newPlayer.Agility = newPlayer.PlayerClass.Agility;
            newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.HitPoint = newPlayer.PlayerClass.HitPoint;
            newPlayer.ManaPoint = newPlayer.PlayerClass.ManaPoint;
            newPlayer.HPRegen = newPlayer.PlayerClass.HPRegen;
            newPlayer.MPRegen = newPlayer.PlayerClass.MPRegen;
            newPlayer.MoveSpeed = newPlayer.PlayerClass.MoveSpeed;
            newPlayer.Attack = newPlayer.PlayerClass.Attack;
            UpdateUI();
        }

        public void ChoiceSphere()
        {
            newPlayer.PlayerName = "Sphere";
            if (hero == null)
            {
                hero = Instantiate(Resources.Load("Prefabs/" + newPlayer.PlayerName), spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }

            else if (hero != null)
            {
                DestroyGameObject(hero);
                hero = Instantiate(Resources.Load("Prefabs/" + newPlayer.PlayerName), spawnPoint.transform.position, Quaternion.identity) as GameObject;
            }
            newPlayer.PlayerClass = new SphereHero();
            newPlayer.Strenght = newPlayer.PlayerClass.Strenght;
            newPlayer.Agility = newPlayer.PlayerClass.Agility;
            newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
            newPlayer.HitPoint = newPlayer.PlayerClass.HitPoint;
            newPlayer.ManaPoint = newPlayer.PlayerClass.ManaPoint;
            newPlayer.HPRegen = newPlayer.PlayerClass.HPRegen;
            newPlayer.MPRegen = newPlayer.PlayerClass.MPRegen;
            newPlayer.MoveSpeed = newPlayer.PlayerClass.MoveSpeed;
            newPlayer.Attack = newPlayer.PlayerClass.Attack;
            UpdateUI();
        }

        private void UpdateUI()
        {
            heroName.text = newPlayer.PlayerName;
            strengthText.text = newPlayer.Strenght.ToString();
            agilityText.text = newPlayer.Agility.ToString();
            intelligenceText.text = newPlayer.Intelligence.ToString();
            moveSpeedText.text = newPlayer.MoveSpeed.ToString();
            baseDamageText.text = newPlayer.Attack.ToString();
    }

        private void DestroyGameObject(GameObject go)
        {
            Destroy(go);
        }
    }
}

