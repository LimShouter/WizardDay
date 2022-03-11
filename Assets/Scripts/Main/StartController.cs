using System;
using Descriptions.SO;
using Player;
using UnityEngine;

namespace Main
{
    public class StartController : MonoBehaviour
    {
        [SerializeField]private PlayerComponent PlayerPrefab;
        [SerializeField]private DescriptionCollectionSo DescriptionCollectionSo;
        private GlobalContext Context;

        private void Awake()
        {
            Context = new GlobalContext(DescriptionCollectionSo);
        }

        void Start()
        {
            var playerComponent = Instantiate(PlayerPrefab);
            var playerController = new PlayerController(Context,Context.PlayerModel,playerComponent);
            playerController.Attach();
        }

        void Update()
        {
            Context.Engine.Update(Time.deltaTime);
        }
    }
}
