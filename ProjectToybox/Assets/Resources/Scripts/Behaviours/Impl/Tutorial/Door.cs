using Proto.Behaviours;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Proto.Behaviours.Impl.Tutorial
{
    public class Door : AbstractInteractableObject
    {

        public string targetPhase;

        protected override void OnInteract(ICharacterObject interacted)
        {
            NextPhase();
            InteractState = InteractState.EndInteract;
        }

        private void NextPhase()
        {
            SceneManager.LoadSceneAsync(targetPhase);
        }
    }

}