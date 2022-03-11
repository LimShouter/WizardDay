using System;
using Player.Camera;
using UnityEngine;
using UnityTemplateProjects.World.Base.Interaction;
using UnityTemplateProjects.World.Base.Movement;

namespace Player
{
	[RequireComponent(typeof(MovementComponent),typeof(InteractionComponent))]
	public class PlayerComponent : MonoBehaviour
	{
		public CameraComponent CameraComponent;
		[NonSerialized]public MovementComponent MovementComponent;
		[NonSerialized]public InteractionComponent InteractionComponent;
	}
}