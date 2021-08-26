using UnityEngine;

namespace InfallibleCode.Completed
{
    public class Door : MonoBehaviour, IInteractable
    {
        private static readonly int IsOpen = Animator.StringToHash("IsOpen");
        
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void Open()
        {
            _animator.SetBool(IsOpen, true);
        }

        public void Interact()
        {
            Open();
        }
    }
}