using Cinemachine;
using Entity;
using UnityEngine;

namespace Descriptions
{
	public interface IPlayerDescription
	{
		IEntityDescription EntityDescription { get; }
		CinemachineStateDrivenCamera CameraPrefab { get;}
	}
}