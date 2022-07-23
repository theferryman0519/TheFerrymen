using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneTitleScreen : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button LoadGameButton;
	public Button NewGameButton;

	public int GameSelectionInt;

	public Button OverlayButton;

	public Color OverlayOriginal = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public Color OverlayAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Change Scene
	public ChangeScene Scene03LoadRun;
	public ChangeScene Scene07LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Buttons
		Button LoadGameButtonClick = LoadGameButton.GetComponent<Button>();
		Button NewGameButtonClick = NewGameButton.GetComponent<Button>();

		LoadGameButtonClick.onClick.AddListener(LoadGameButtonClicking);
		NewGameButtonClick.onClick.AddListener(NewGameButtonClicking);

		// Set Game Selection Int
		GameSelectionInt = 0;

		// Overlay Starting Color
		OverlayImage.GetComponent<Image>().color = OverlayOriginal;

		// Play Fade Out Coroutine
		StartCoroutine(OverlayFadeOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	public IEnumerator OverlayFadeOut() {
		// Fade Overlay to Alpha
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayOriginal, OverlayAlpha, ElapsedTime);
			yield return null;
		}

		// Continue Scene
	}

	public IEnumerator OverlayFadeIn() {
		// Fade Overlay to Original
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayOriginal, OverlayAlpha, ElapsedTime);
			yield return null;
		}

		// Load Next Scenes
		if (GameSelectionInt == 1) {
			// Load Player Data

			// Load Gameplay Land Scene
			Scene07LoadRun.Scene07Load();
		}

		else {
			// Set New Data
			SetNewPlayerData();

			// Load Prologue Scene
			Scene03LoadRun.Scene03Load();
		}
	}

	public void LoadGameButtonClicking() {
		// Set Game Selection Int
		GameSelectionInt = 1;

		// Start Coroutine to Fade Overlay In
		StartCoroutine(OverlayFadeIn());
	}

	public void NewGameButtonClicking() {
		// Set Game Selection Int
		GameSelectionInt = 2;

		// Start Coroutine to Fade Overlay In
		StartCoroutine(OverlayFadeIn());
	}

	public void SetNewPlayerData() {
		// Set Player Data
		DataPlayer.PlayerCoins = 0;
		DataPlayer.PlayerFirstName = "xxxx";
		DataPlayer.PlayerGems = 0;
		DataPlayer.PlayerRank = 0;
		DataPlayer.PlayerShipName = "Archi";
		DataPlayer.RiverCoins = 0;
		DataPlayer.RiverSailing = 0;
		DataPlayer.RiverSouls = 0;
		DataPlayer.ShipInPort = false;
		DataPlayer.TimeLeftInPort = 0.0f;
		DataPlayer.TimeLeftOnRiver = 0.0f;
		DataPlayer.TimeLeftSouls = 0.0f;
		DataPlayer.TimeLeftTotal = 0.0f;

		// Set River Data
		DataRivers.RiverUnlockedAcheron = false;
		DataRivers.RiverUnlockedAmazon = false;
		DataRivers.RiverUnlockedAmur = false;
		DataRivers.RiverUnlockedCocytus = false;
		DataRivers.RiverUnlockedColorado = false;
		DataRivers.RiverUnlockedCongo = false;
		DataRivers.RiverUnlockedDanube = false;
		DataRivers.RiverUnlockedDarling = false;
		DataRivers.RiverUnlockedEuphrates = false;
		DataRivers.RiverUnlockedGanges = false;
		DataRivers.RiverUnlockedGila = false;
		DataRivers.RiverUnlockedIndus = false;
		DataRivers.RiverUnlockedIrrawaddy = false;
		DataRivers.RiverUnlockedIshim = false;
		DataRivers.RiverUnlockedLethe = false;
		DataRivers.RiverUnlockedMekong = false;
		DataRivers.RiverUnlockedMississippi = false;
		DataRivers.RiverUnlockedMissouri = false;
		DataRivers.RiverUnlockedNile = false;
		DataRivers.RiverUnlockedOb = false;
		DataRivers.RiverUnlockedOhio = false;
		DataRivers.RiverUnlockedOrinoco = false;
		DataRivers.RiverUnlockedPecos = false;
		DataRivers.RiverUnlockedPhlegethon = false;
		DataRivers.RiverUnlockedPlatte = false;
		DataRivers.RiverUnlockedPracticum = true;
		DataRivers.RiverUnlockedRhine = false;
		DataRivers.RiverUnlockedRhone = false;
		DataRivers.RiverUnlockedRioGrande = false;
		DataRivers.RiverUnlockedSnake = false;
		DataRivers.RiverUnlockedStyx = false;
		DataRivers.RiverUnlockedTarim = false;
		DataRivers.RiverUnlockedTigris = false;
		DataRivers.RiverUnlockedUral = false;
		DataRivers.RiverUnlockedVolga = false;
		DataRivers.RiverUnlockedXijiang = false;
		DataRivers.RiverUnlockedYangtze = false;
		DataRivers.RiverUnlockedYellow = false;
		DataRivers.RiverUnlockedYukon = false;
		DataRivers.RiverUnlockedZambezi = false;

		// Set Ship Data
		DataShip.BaseUpgradeAnchor = false;
		DataShip.BaseUpgradeBarAreas = false;
		DataShip.BaseUpgradeCabins = false;
		DataShip.BaseUpgradeCasino = false;
		DataShip.BaseUpgradeDiningHall = false;
		DataShip.BaseUpgradeGangway = false;
		DataShip.BaseUpgradeHallways = false;
		DataShip.BaseUpgradeHull = false;
		DataShip.BaseUpgradeKitchen = false;
		DataShip.BaseUpgradeLifeboats = false;
		DataShip.BaseUpgradeMast = false;
		DataShip.BaseUpgradeMediaRoom = false;
		DataShip.BaseUpgradePoolsHotTubs = false;
		DataShip.BaseUpgradeRowingOars = false;
		DataShip.BaseUpgradeSail = false;
		DataShip.BaseUpgradeTheater = false;
		DataShip.CadetUpgradeAnchor = false;
		DataShip.CadetUpgradeBarAreas = false;
		DataShip.CadetUpgradeCabins = false;
		DataShip.CadetUpgradeCasino = false;
		DataShip.CadetUpgradeDiningHall = false;
		DataShip.CadetUpgradeGangway = false;
		DataShip.CadetUpgradeHallways = false;
		DataShip.CadetUpgradeHull = false;
		DataShip.CadetUpgradeKitchen = false;
		DataShip.CadetUpgradeLifeboats = false;
		DataShip.CadetUpgradeMast = false;
		DataShip.CadetUpgradeMediaRoom = false;
		DataShip.CadetUpgradePoolsHotTubs = false;
		DataShip.CadetUpgradeRowingOars = false;
		DataShip.CadetUpgradeSail = false;
		DataShip.CadetUpgradeTheater = false;
		DataShip.CaptainUpgradeAnchor = false;
		DataShip.CaptainUpgradeBarAreas = false;
		DataShip.CaptainUpgradeCabins = false;
		DataShip.CaptainUpgradeCasino = false;
		DataShip.CaptainUpgradeDiningHall = false;
		DataShip.CaptainUpgradeGangway = false;
		DataShip.CaptainUpgradeHallways = false;
		DataShip.CaptainUpgradeHull = false;
		DataShip.CaptainUpgradeKitchen = false;
		DataShip.CaptainUpgradeLifeboats = false;
		DataShip.CaptainUpgradeMast = false;
		DataShip.CaptainUpgradeMediaRoom = false;
		DataShip.CaptainUpgradePoolsHotTubs = false;
		DataShip.CaptainUpgradeRowingOars = false;
		DataShip.CaptainUpgradeSail = false;
		DataShip.CaptainUpgradeTheater = false;
		DataShip.FerrymanUpgradeAnchor = false;
		DataShip.FerrymanUpgradeBarAreas = false;
		DataShip.FerrymanUpgradeCabins = false;
		DataShip.FerrymanUpgradeCasino = false;
		DataShip.FerrymanUpgradeDiningHall = false;
		DataShip.FerrymanUpgradeGangway = false;
		DataShip.FerrymanUpgradeHallways = false;
		DataShip.FerrymanUpgradeHull = false;
		DataShip.FerrymanUpgradeKitchen = false;
		DataShip.FerrymanUpgradeLifeboats = false;
		DataShip.FerrymanUpgradeMast = false;
		DataShip.FerrymanUpgradeMediaRoom = false;
		DataShip.FerrymanUpgradePoolsHotTubs = false;
		DataShip.FerrymanUpgradeRowingOars = false;
		DataShip.FerrymanUpgradeSail = false;
		DataShip.FerrymanUpgradeTheater = false;
		DataShip.PilotUpgradeAnchor = false;
		DataShip.PilotUpgradeBarAreas = false;
		DataShip.PilotUpgradeCabins = false;
		DataShip.PilotUpgradeCasino = false;
		DataShip.PilotUpgradeDiningHall = false;
		DataShip.PilotUpgradeGangway = false;
		DataShip.PilotUpgradeHallways = false;
		DataShip.PilotUpgradeHull = false;
		DataShip.PilotUpgradeKitchen = false;
		DataShip.PilotUpgradeLifeboats = false;
		DataShip.PilotUpgradeMast = false;
		DataShip.PilotUpgradeMediaRoom = false;
		DataShip.PilotUpgradePoolsHotTubs = false;
		DataShip.PilotUpgradeRowingOars = false;
		DataShip.PilotUpgradeSail = false;
		DataShip.PilotUpgradeTheater = false;
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}