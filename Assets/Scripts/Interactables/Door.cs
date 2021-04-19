using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MMC
{
    public class Door : MonoBehaviour, IInteractable
    {
        public GameObject pivot;
        private DoorState state;
        private int direction;
        [SerializeField] private float speed = 10;

        enum DoorState
        {
            Open,
            Moving,
            Closed
        }
        void Start()
        {
            this.state = DoorState.Closed;
            direction = 1;
        }

        // Update is called once per frame
        void Update()
        {
            if (this.state == DoorState.Moving)
            {
                Move();
            }
        }

        void IInteractable.StartInteract(PlayerPawn player, Vector3 hitLocation, Vector3 hitNormal)
        {
            this.state = DoorState.Moving;
        }
        void IInteractable.StopInteract() { }
        void Move()
        {
            //Rotate the door around its pivot in the correct direction
            this.transform.RotateAround(pivot.transform.position, pivot.transform.up, 90 * direction * Time.deltaTime * speed);
            if (this.transform.localRotation.eulerAngles.y >= 90)
            {
                //If the door is all the way open, stop at 90 degrees then set the state to open
                this.transform.localEulerAngles = Vector3.up * 90;
                this.state = DoorState.Open;
                direction = -1;
            }
            else if (this.transform.localRotation.eulerAngles.y <= 0)
            {
                //If the door is all the way closed, stop at 0 degrees then set the state to closed
                this.transform.localEulerAngles = Vector3.zero;
                this.state = DoorState.Closed;
                direction = 1;
            }
        }
    }
}