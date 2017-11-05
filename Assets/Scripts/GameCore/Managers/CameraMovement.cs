using UnityEngine;

namespace GameCore
{
    [RequireComponent(typeof(Animator))]
    internal class CameraMovement : MonoBehaviour
    {
        private static Animator animator;

        private void Awake()
        {
            animator = gameObject.GetComponent<Animator>();
        }

        // Scroll up to next screen
        internal static void MoveCamera()
        {
            animator.SetTrigger("NextLevel");
        }

        private void Reposition()
        {
            animator.transform.parent.position = animator.transform.position;
        }
    }
}