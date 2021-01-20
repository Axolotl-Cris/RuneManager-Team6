using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Runes
{
    public class RuneMerger : MonoBehaviour
    {
        public List<RuneScriptObjects> SelectedObjects = new List<RuneScriptObjects>();

        public void Merge()
        {
            if (SelectedObjects.Count < 2 && IsOfSameRarity(SelectedObjects))
            {
                return;
            }

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
        }

        public void ClearRunes()
        {
            SelectedObjects.Clear();
        }

        private void UpgradeRune(int chance)
        {
            if (UpgradeChance(chance))
            {
                Debug.Log($"You upgraded a rune with a {chance} percent chance!");
            }
            else
            {
                if (!UpgradeChance(chance))
                {
                    Debug.Log($"You failed to upgrade a rune with a {chance} percent chance!");
                }
            }
        }

        internal bool IsOfSameRarity(List<RuneScriptObjects> selectedRunes)
        {
            if (selectedRunes.Distinct().Count() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
}