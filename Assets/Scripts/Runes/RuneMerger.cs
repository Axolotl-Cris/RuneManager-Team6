using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Runes
{
    public class RuneMerger : MonoBehaviour
    {
        [Header("Selected Runes")]
        public List<RuneScriptObjects> SelectedObjects = new List<RuneScriptObjects>();

        [Header("Runes Sorted by Rarity")]
        public List<RuneRarity> RuneRarities = new List<RuneRarity>();

        [Header("Events")]
        public UnityEvent OnMerge;

        public void Merge()
        {
            //Check if objects selected are more than one, and is of same rarity and not legendary

            switch (SelectedObjects.Count)
            {
                case 2:

                    UpgradeRune(20);

                    break;

                case 3:

                    UpgradeRune(55);

                    break;

                case 4:

                    UpgradeRune(95);

                    break;
            }

            OnMerge.Invoke();
        }

        public void ClearRunes()
        {
            SelectedObjects.Clear();
        }

        private void UpgradeRune(int chance)
        {
            RuneScriptObjects rune = SelectedObjects[Random.Range(0, SelectedObjects.Count - 1)];

            if (UpgradeChance(chance))
            {
                RuneScriptObjects upgradedRune;

                Debug.Log($"You upgraded a rune with a {chance} percent chance!");

                foreach (var newRune in RuneRarities[rune.rarity + 1].Runes)
                {
                    if (newRune.color == rune.color)
                    {
                        Debug.Log($"You recived an upgraded {newRune.name}");
                        upgradedRune = newRune;
                        break;
                    }
                }
            }
            else if (!UpgradeChance(chance))
            {
                Debug.Log($"You failed to upgrade a rune with a {chance} percent chance!");
                Debug.Log($"You recived a {rune.name}");
            }
        }

        internal bool IsOfSameRarity(List<RuneScriptObjects> selectedRunes)
        {
            //Check Rareties
            return false;
        }

        internal bool UpgradeChance(int percentChance)
        {
            int RandomNumber = Random.Range(1, 100);

            if (RandomNumber <= percentChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    [System.Serializable]
    public class RuneRarity
    {
        public string RarityName;

        [Space]
        public int RarityId;

        public List<RuneScriptObjects> Runes = new List<RuneScriptObjects>();
    }
}