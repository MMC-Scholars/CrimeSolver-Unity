using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MMC
{
    public class ForensicLight : Tool
    {
        [SerializeField]
        float revealDistance;
        public float RevealDistance { get { return revealDistance; } }

        [SerializeField]
        float revealRadius;
        public float RevealRadius { get { return revealRadius; } }

        [SerializeField]
        float revealHardness;
        public float RevealHardness { get { return revealHardness; } }

        RevealController revealer;
        Vector3 invisible = new Vector3();

        public bool IsLightOn { get; protected set; }

        void Start()
        {
            // make the collision box that checks if we hit invisible evidence not be able to detect

            // set the reveal distance

            // set the reveal radius and hardness
            revealer.SetRadius(RevealRadius);
            revealer.SetHardness(RevealHardness);
        }

        void Update()
        {
            if (IsLightOn)
            {
                // ****** PLACEHOLDER ******** //
                Vector3 LocationOfRevealer = new Vector3();
                // set reveal location
                revealer.SetLocation(LocationOfRevealer);
            }

        }
        public override void Select()
        {
            base.Select();
        }

        public override void Deselect()
        {
            base.Deselect();
        }

        void TurnOff()
        {
            // turn off overlap checking on reveal collision

            // set visibility of light source to off

            // set parameter for sphere mask to be an arbitrary ocation (so nothing is revealed)
            revealer.SetLocation(invisible);
        }

        void TurnOn()
        {
            // turn on overlap checking on reveal collision

            // set visibility of light source to on

        }

        void ToggleLight()
        {
            if (IsLightOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
            IsLightOn = !IsLightOn;
        }

        public override void UseTool()
        {
            ToggleLight();
        }

        // This will probably need to change, in blueprints I made Event UseTool(Aiming) to execute the same thing as UseTool since 
        // the forensic light can't be aimed in but should still be able to toggle on/off if the player is holding the aim button for some reason
        public override void UseToolAiming()
        {
            ToggleLight();
        }

    }
}