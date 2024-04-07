using UnityEngine;

namespace BackgroundSetting
{
    public class MoveBackground : MonoBehaviour
    {
        [SerializeField] private float speed;
        private float back_Size;
        private float back_pos;

        private Transform back_Tranform;

        void Start()
        {
            back_Tranform = GetComponent<Transform>();
            back_Size = GetComponent<SpriteRenderer>().bounds.size.y;
        }

        void Update()
        {
            Move();
        }

        public void Move()
        {
            back_pos += speed * Time.deltaTime;
            back_pos = Mathf.Repeat(back_pos, back_Size);
            back_Tranform.position = new Vector3(0, back_pos, 0);
        }
    }
}

