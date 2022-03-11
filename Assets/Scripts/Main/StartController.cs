using Player;
using UnityEngine;

namespace Main
{
    public class StartController : MonoBehaviour
    {
        public PlayerComponent PlayerPrefab;
        void Start()
        {
            var playerComponent = Instantiate(PlayerPrefab);
            var playerModel = new PlayerModel();
            var playerController = new PlayerController(playerModel,playerComponent);
            playerController.Attach();
        }

        void Update()
        {
        
        }
    }
}
