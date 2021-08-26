using UnityEngine;

namespace InfallibleCode.Start_Here
{
    public class Player : MonoBehaviour
    {
        private Camera _camera;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            var nearestGameObject = GetNearestGameObject();
            if (nearestGameObject == null) return;
            if (Input.GetButtonDown("Fire1"))
            {
                var lightSwitch = nearestGameObject.GetComponent<Lamp>();
                if (lightSwitch != null)
                {
                    lightSwitch.Switch();
                }

                var door = nearestGameObject.GetComponent<Door>();
                if (door != null)
                {
                    door.Open();
                }

                var radio = nearestGameObject.GetComponent<Radio>();
                if (radio != null)
                {
                    radio.Toggle();
                }
            }
        }

        private GameObject GetNearestGameObject()
        {
            GameObject result = null;
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit, 3))
            {
                result = hit.transform.gameObject;
            }
            return result;
        }
    }
}