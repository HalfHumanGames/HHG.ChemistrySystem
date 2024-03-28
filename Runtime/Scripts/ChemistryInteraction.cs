using System;
using UnityEngine;

namespace HHG.ChemistrySystem.Runtime
{
    [Serializable]
    public class ChemistryInteraction
    {
        public ElementAsset Interactor => interactor;
        public ElementAsset Interactee => interactee;
        public ElementAsset Result => result;

        [SerializeField] private ElementAsset interactor;
        [SerializeField] private ElementAsset interactee;
        [SerializeField] private ElementAsset result;
    }
}