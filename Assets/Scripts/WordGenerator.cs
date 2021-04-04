﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "jumbled", "yoke", "attend", "face", "arrest", "knowledgeable", "eight", "industry", "ashamed", "depend", "clap", "listen", "robust", "steer", "foregoing", "hulking", "uncovered", "cow", "beef", "enormous", "angry", "title", "shocking", "macabre", "unwritten", "earn", "friend", "toy", "start", "cautious", "provide", "incompetent", "descriptive", "bath", "accurate", "brush", "grab", "drawer", "letters", "peck", "spotty", "obedient", "various", "language", "icicle", "agreeable", "describe", "annoyed", "same", "regular", "hot", "cool", "sheet", "shame", "bake", "motionless", "aspiring", "devilish", "trashy", "zebra", "helpless", "hypnotic", "ocean", "plantation", "bushes", "present", "eggnog", "current", "puny", "torpid", "trick", "wait", "first", "actually", "axiomatic", "underwear", "obnoxious", "veil", "pancake", "fumbling", "awful", "steel", "run", "multiply", "thunder", "well-made", "stiff", "toad", "slave", "bouncy", "cattle", "belligerent", "wreck", "pipe", "library", "seal", "switch", "dislike", "quince", "found", "interrupt", "bitter", "leg", "tired", "sincere", "meeting", "paltry", "boiling", "spiders", "wipe", "connection", "yell", "design", "itch", "head", "grubby", "spare", "burst", "vein", "premium", "soggy", "woman", "bikes", "familiar", "skip", "hammer", "elated", "wide-eyed", "church", "spotted", "three", "income", "moan", "evasive", "learned", "sock", "oranges", "view", "ignore", "ambitious", "voyage", "alcoholic", "uneven", "mouth", "thank", "destroy", "sore", "clip", "passenger", "sign", "suggestion", "try", "trace", "rock", "faithful", "spade", "muddle", "fascinated", "obsequious", "tin", "dad", "big", "pleasure", "shallow", "saw", "furtive", "bucket", "event", "dapper", "vest", "fang", "damage", "kneel", "cactus", "happy", "mean", "plate", "obeisant", "cough", "bedroom", "repair", "unusual", "whispering", "bewildered", "treatment", "evanescent", "stupendous", "nervous", "poke", "mushy", "murder", "own", "hurt", "bomb", "youthful", "magical", "shiny", "key", "left", "chin", "consist", "irate", "radiate", "baby", "plot", "scintillating", "playground", "broad", "vacuous", "birthday", "enchanted", "employ", "puffy", "snow", "coal", "airplane", "marry", "dusty", "exciting", "beautiful", "many", "bells", "lamentable", "compete", "pretend", "launch", "peep", "breath", "greasy", "flippant", "receive", "hydrant", "obtain", "squirrel", "rob", "guard", "eatable", "few", "husky", "transport", "spiky", "chew", "skate", "relax", "discreet", "whip", "stimulating", "appliance", "stay", "border", "crate", "inexpensive", "thing", "canvas", "immense", "standing", "harmonious", "guitar", "stain", "vast", "x-ray", "frantic", "intelligent", "kiss", "stone", "shirt", "bell", "mate", "quiver", "roasted", "false", "pencil", "development", "cute", "stretch", "punish", "accessible", "cows", "ten", "double", "elite", "cub", "ultra", "flood", "gruesome", "base", "breakable", "women", "hollow", "caring", "cabbage", "neighborly", "futuristic", "work", "male", "marked", "brave", "vague", "needless", "careful", "melt", "list", "frogs", "condition", "fair", "cold", "ambiguous", "adhesive", "visit", "cloistered", "wood", "recess", "imaginary", "smooth", "reason", "aberrant", "therapeutic", "mark", "fairies", "sparkle", "introduce", "venomous", "race", "kittens", "announce", "grin", "suffer", "education", "choke", "pets", "toothbrush", "public", "squealing", "page", "suit", "unable", "sprout", "crown", "table", "gullible", "annoy", "grape", "bag", "credit", "subsequent", "berserk", "lively", "craven", "men", "dance", "tenuous", "zinc", "creator", "rice", "control", "sin", "love", "nosy", "noiseless", "hill", "existence", "aware", "push", "experience", "cent", "miniature", "proud", "doubtful", "tawdry", "tug", "wink", "cuddly", "forgetful", "psychotic", "shoe", "dazzling", "fearless", "gentle", "square", "sofa", "thin", "concern", "magic", "squeamish", "clever", "decay", "theory", "acrid", "capable", "mint", "grate", "distinct", "roof", "bare", "songs", "profuse", "mist", "blind", "fax", "post", "malicious", "circle", "four", "wanting", "blush", "wing", "arm", "doubt", "fixed", "smile", "medical", "maniacal", "book", "old-fashioned", "smoggy", "arrive", "fearful", "lick", "loaf", "spy", "military", "merciful", "dream", "trousers", "ear", "territory", "productive", "oval", "guttural", "shoes", "colorful", "quill", "escape", "scene", "blot", "itchy", "talented", "hope", "overjoyed", "advertisement", "drag", "flat", "groovy", "madly", "repulsive", "supply", "scent", "hour", "cherry", "carpenter", "tart", "pastoral", "thirsty", "breathe", "scold", "wheel", "analyze", "realize", "absurd", "fry", "turn", "rigid", "damp", "coil", "remove", "wriggle", "cast", "prevent", "machine", "celery", "earth", "aboriginal", "rescue", "question", "feeling", "matter", "side", "hobbies", "vivacious", "unbiased", "sweltering", "calculating", "week", "fence", "robin", "coach", "kill", "judge", "floor", "nippy", "bashful", "request", "babies", "auspicious", "spiteful", "telephone", "room", "wave", "ticket", "beneficial" };

    public static string GetRandomWord()
    {
        return wordList[Random.Range(0,wordList.Length)];
    }
}