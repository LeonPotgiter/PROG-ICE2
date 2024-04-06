﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace prjWordle.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WordController : ControllerBase
	{
		static List<string> words = new List<string>
		{
			"cigar", "rebut", "sissy","humph",  "awake", "blush",  "focal",  "evade",  "naval",  "serve",  "heath",  "dwarf",
  "model",  "karma",  "stink",  "grade",  "quiet",  "bench",  "abate",  "feign",  "major",  "death",  "fresh",  "crust",  "stool",
  "colon",  "abase",  "marry",  "react",  "batty",  "pride",  "floss",  "helix",  "croak",  "staff",  "paper",  "unfed",  "whelp",
  "trawl",  "outdo", "adobe",  "crazy",  "sower",  "repay",  "digit",  "crate",  "cluck",  "spike",  "mimic",  "pound",  "maxim",  "linen",
  "unmet",  "flesh",  "booby",  "forth",  "first",  "stand",  "belly",  "ivory",  "seedy",  "print",  "yearn",  "drain",  "bribe",  "stout",
  "panel",  "crass",  "flume",  "offal",  "agree",  "error",  "swirl",  "argue",  "bleed",  "delta",  "flick",  "totem",  "wooer",
  "front",  "shrub",  "parry",  "biome",  "lapel",  "start",  "greet",  "goner",  "golem",  "lusty",  "loopy",  "round",  "audit",  "lying",
  "gamma",  "labor",  "islet",  "civic",  "forge",  "corny",  "moult",  "basic",  "salad",  "agate",  "spicy",  "spray",  "essay",  "fjord",
  "spend",  "kebab",  "guild",  "aback",  "motor",  "alone",  "hatch",  "hyper",  "thumb",  "dowry",  "ought",  "belh",  "dutch",  "pilot",
  "tweed",  "comet",  "jaunt",  "enema",  "steed",  "abyss",  "growl",  "fling",  "dozen",  "boozy",  "erode",  "world",  "gouge",  "click",
  "briar",  "great",  "altar",  "pulpy", "blurt",  "coast",  "duchy",  "groin",  "fixer",  "group",  "rogue",  "badly",  "smart",  "pithy",
  "gaudy",  "chill",  "heron",  "vodka",  "finer",  "surer",  "radio",  "rouge",  "perch",  "retch",  "wrote",  "clock",  "tilde",  "store",
  "prove",  "bring",  "solve",  "cheat",  "grime",  "exult",  "usher",  "epoch",  "triad",  "break",  "rhino",  "viral",  "conic",  "masse",
  "sonic",  "vital",  "trace",  "using",  "peach",  "champ",  "baton",  "brake",  "pluck",  "craze",  "gripe",  "weary",  "picky",  "acute",
  "ferry",  "aside",  "tapir",  "troll",  "unify",  "rebus",  "boost",  "truss",  "siege",  "tiger",  "banal",  "slump",  "crank",  "gorge",
  "query",  "drink",  "favor",  "abbey",  "tangy",  "panic",  "solar",  "shire",  "proxy",  "point",  "robot",  "prick",  "wince",  "crimp",
  "knoll",  "sugar",  "whack",  "mount",  "perky",  "could",  "wrung",  "light",  "those",  "moist",  "shard",  "pleat",  "aloft",  "skill",
  "elder",  "frame",  "humor",  "pause",  "ulcer",  "ultra",  "robin",  "cynic",  "agora",  "aroma",  "caulk",  "shake",  "pupal",  "dodge",
  "swill",  "tacit",  "other",  "thorn",  "trove",  "bloke",  "vivid",  "spill",  "chant",  "choke",  "rupee",  "nasty",  "mourn",  "ahead",
  "brine",  "cloth",  "hoard",  "sweet",  "month",  "lapse",  "watch",  "today",  "focus",  "smelt",  "tease",  "cater",  "movie",  "lynch",
  "saute",  "allow",  "renew",  "their",  "slosh",  "purge",  "chest",  "depot",  "epoxy",  "nymph",  "found",  "shall",  "harry",  "stove",
  "lowly",  "snout",  "trope",  "fewer",  "shawl",  "natal",  "fibre",  "comma",  "foray",  "scare",  "stair",  "black",  "squad",  "royal",
  "chunk",  "mince",  "slave",  "shame",  "cheek",  "ample",  "flair",  "foyer",  "cargo",  "oxide",  "plant",  "olive",  "inert",  "askew",
  "heist",  "shown",  "zesty",  "hasty",  "trash",  "fella",  "larva",  "forgo",  "story",  "hairy",  "train",  "homer",  "badge",  "midst",
  "canny",  "fetus",  "butch",  "farce",  "slung",  "tipsy",  "metal",  "yield",  "delve",  "being",  "scour",  "glass",  "gamer",  "scrap",
  "money",

		};
		Random rand = new Random();
		Words word = new Words();
		

		[HttpPost]
		public string GenerateWord()
		{
			word.GeneratedWord = words[rand.Next(0, words.Count)];
			return word.GeneratedWord;
		}

		[HttpGet]
		public string CheckWord(string impWord, string guessWord)
		{

			string guessedLetters = "";

			foreach (char c in guessWord)
			{
				if (impWord.Contains(c))
				{
					guessedLetters += c;
				}
			}
			return guessedLetters;
		}



	}
}
