using System.Linq;
using OWML.Common;
using OWML.ModHelper;
using UnityEngine;

namespace ProudHearthians;

public class ProudHearthians : ModBehaviour
{
	private void Awake()
	{
		// You won't be able to access OWML's mod helper in Awake.
		// So you probably don't want to do anything here.
		// Use Start() instead.
	}

	private void Start()
	{
		// Starting here, you'll have access to OWML's mod helper.
		ModHelper.Console.WriteLine($"My mod {nameof(ProudHearthians)} is loaded!", MessageType.Success);


		// Example of accessing game code.
		LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
		{
			if (loadScene != OWScene.SolarSystem) return;
			
			var materials = Resources.FindObjectsOfTypeAll<Material>().Where(x => x.name == "Traveller_HEA_PlayerSuit_mat");
			foreach (var material in materials)
			{
				material.mainTexture = ModHelper.Assets.GetTexture("textures/queer.png");
				material.SetTexture("_BumpMap", ModHelper.Assets.GetTexture("textures/queerNormal.png"));
			}
		};
	}
}

