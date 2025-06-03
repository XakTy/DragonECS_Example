using System.Collections;
using DCFApixels.DragonECS;
using Game.Scripts.Data;
using Features.Player;
using Features.Farm.Components;
using Features.Farm.Module;
using Features.Farm.Systems;
using Features.Interaction.Module;
using Features.VegatableBox.Module;
using Game.Scripts.Systems;
using Game.Scripts.Tools;
using UnityEngine;

namespace Game.Scripts
{
	public sealed class Game : MonoBehaviour
    {
        [SerializeField] private SceneData _sceneData;
		[SerializeField] private RuntimeData _runtimeData;
		[SerializeField] private StaticData _staticData;

		private EcsPipeline _pipeline;
		private EcsDefaultWorld _world;
        IEnumerator Start()
        {
            _runtimeData = new RuntimeData();


            var ui = Object.Instantiate(_staticData.UIService);
            ui.InitScreens();

            PlantService plantService = new PlantService(_staticData);
            
            _world = new EcsDefaultWorld();
            var eventWorld = new EcsEventWorld();

            _pipeline = EcsPipeline.New()
		            .Add(new InitializeSystem())
		            .Add(new ChangeStateSystem())
		            .Add(new StartGameSystem())
		            .Add(new InitCameraSystem())
		            .AddModule(new PlayerModule())
		            .AddModule(new InteractionModule())
		            .AddModule(new ParasiteModule())
		            
		            .Add(new FarmPlotInteractionSystem())
		            
		            .AddModule(new VegetableBoxModule())
		            
		            .AddModule(new FarmModule())
		            .AddModule(new FarmViewModule())
		            
		            .Add(new FollowSystem())
		            .InjectService(ui)
		            .InjectService(_staticData)
		            .InjectService(_sceneData)
		            .InjectService(_runtimeData)
		            .InjectService(plantService)
	            .Inject(_world, eventWorld)
	            .AutoInject(true)
	            .BuildAndInit();
            
            yield return null;
        }

        void Update()
        {
	        _runtimeData.deltaTime = Time.deltaTime;
	        _pipeline.Run();
        }

        void OnDestroy()
        {
            if (_pipeline != null)
            {
                _pipeline.Destroy();
                _pipeline = null;
                _world.Destroy();
                _world = null;
            }
        }
    }
}