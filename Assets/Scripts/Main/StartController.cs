using Descriptions.SO;
using Player;
using UnityEngine;

namespace Main
{
    public class StartController : MonoBehaviour
    {
        public PlayerComponent PlayerPrefab;
        public PlayerDescriptionSo DescriptionSo;
        void Start()
        {
            var playerComponent = Instantiate(PlayerPrefab);
            var playerModel = new PlayerModel(DescriptionSo);
            var playerController = new PlayerController(playerModel,playerComponent);
            playerController.Attach();
        }

        void Update()
        {
        
        }
    }
}
