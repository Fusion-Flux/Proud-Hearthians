using System.Linq;
using OWML.Common;
using OWML.ModHelper;
using UnityEngine;

namespace LGBTQIAMod;

public class LGBTQIAMod : ModBehaviour
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
		ModHelper.Console.WriteLine($"My mod {nameof(LGBTQIAMod)} is loaded!", MessageType.Success);


		// Example of accessing game code.
		LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
		{
			if (loadScene != OWScene.SolarSystem) return;

			//GameObject.Find("Player_Body/Traveller_HEA_Player_v2/Traveller_Mesh_v01:Traveller_Geo/Traveller_Mesh_v01:PlayerSuit_Body");
			Resources.FindObjectsOfTypeAll<Material>().First(x=> x.name == "Traveller_HEA_PlayerSuit_mat").mainTexture = ModHelper.Assets.GetTexture("queer.png");
			Resources.FindObjectsOfTypeAll<Material>().First(x=> x.name == "Traveller_HEA_PlayerSuit_mat").SetTexture("_BumpMap", ModHelper.Assets.GetTexture("queerNormal.png"));
			//GetComponent<Renderer>().sharedMaterial.mainTexture = ModHelper.Assets.GetTexture("ourple.png");
			
		};
	}
}

