using System.Collections.Generic;

public static class EmojiProvider
{
    private static List<Emoji> emojis = GetEmojis();

    public static List<Emoji> Emojis { get => emojis; }

    private static List<Emoji> GetEmojis()
    {
        List<Emoji> emojis = new List<Emoji>();

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😀",
            Code = "1f600",
            ShortName = "grinning face",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😁",
            Code = "1f601",
            ShortName = "grinning face with smiling eyes",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😂",
            Code = "1f602",
            ShortName = "face with tears of joy",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤣",
            Code = "1f923",
            ShortName = "rolling on the floor laughing",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😃",
            Code = "1f603",
            ShortName = "smiling face with open mouth",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😄",
            Code = "1f604",
            ShortName = "smiling face with open mouth &amp; smiling eyes",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😅",
            Code = "1f605",
            ShortName = "smiling face with open mouth &amp; cold sweat",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😆",
            Code = "1f606",
            ShortName = "smiling face with open mouth &amp; closed eyes",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😉",
            Code = "1f609",
            ShortName = "winking face",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😊",
            Code = "1f60a",
            ShortName = "smiling face with smiling eyes",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😋",
            Code = "1f60b",
            ShortName = "face savouring delicious food",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😎",
            Code = "1f60e",
            ShortName = "smiling face with sunglasses",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😍",
            Code = "1f60d",
            ShortName = "smiling face with heart-eyes",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😘",
            Code = "1f618",
            ShortName = "face blowing a kiss",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😗",
            Code = "1f617",
            ShortName = "kissing face",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😙",
            Code = "1f619",
            ShortName = "kissing face with smiling eyes",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😚",
            Code = "1f61a",
            ShortName = "kissing face with closed eyes",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☺",
            Code = "263a",
            ShortName = "smiling face",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙂",
            Code = "1f642",
            ShortName = "slightly smiling face",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤗",
            Code = "1f917",
            ShortName = "hugging face",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤩",
            Code = "1f929",
            ShortName = "star-struck",
            Category = "face-positive",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤔",
            Code = "1f914",
            ShortName = "thinking face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤨",
            Code = "1f928",
            ShortName = "face with raised eyebrow",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😐",
            Code = "1f610",
            ShortName = "neutral face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😑",
            Code = "1f611",
            ShortName = "expressionless face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😶",
            Code = "1f636",
            ShortName = "face without mouth",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙄",
            Code = "1f644",
            ShortName = "face with rolling eyes",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😏",
            Code = "1f60f",
            ShortName = "smirking face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😣",
            Code = "1f623",
            ShortName = "persevering face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😥",
            Code = "1f625",
            ShortName = "disappointed but relieved face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😮",
            Code = "1f62e",
            ShortName = "face with open mouth",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤐",
            Code = "1f910",
            ShortName = "zipper-mouth face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😯",
            Code = "1f62f",
            ShortName = "hushed face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😪",
            Code = "1f62a",
            ShortName = "sleepy face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😫",
            Code = "1f62b",
            ShortName = "tired face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😴",
            Code = "1f634",
            ShortName = "sleeping face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😌",
            Code = "1f60c",
            ShortName = "relieved face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😛",
            Code = "1f61b",
            ShortName = "face with stuck-out tongue",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😜",
            Code = "1f61c",
            ShortName = "face with stuck-out tongue &amp; winking eye",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😝",
            Code = "1f61d",
            ShortName = "face with stuck-out tongue &amp; closed eyes",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤤",
            Code = "1f924",
            ShortName = "drooling face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😒",
            Code = "1f612",
            ShortName = "unamused face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😓",
            Code = "1f613",
            ShortName = "face with cold sweat",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😔",
            Code = "1f614",
            ShortName = "pensive face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😕",
            Code = "1f615",
            ShortName = "confused face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙃",
            Code = "1f643",
            ShortName = "upside-down face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤑",
            Code = "1f911",
            ShortName = "money-mouth face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😲",
            Code = "1f632",
            ShortName = "astonished face",
            Category = "face-neutral",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☹",
            Code = "2639",
            ShortName = "frowning face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙁",
            Code = "1f641",
            ShortName = "slightly frowning face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😖",
            Code = "1f616",
            ShortName = "confounded face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😞",
            Code = "1f61e",
            ShortName = "disappointed face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😟",
            Code = "1f61f",
            ShortName = "worried face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😤",
            Code = "1f624",
            ShortName = "face with steam from nose",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😢",
            Code = "1f622",
            ShortName = "crying face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😭",
            Code = "1f62d",
            ShortName = "loudly crying face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😦",
            Code = "1f626",
            ShortName = "frowning face with open mouth",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😧",
            Code = "1f627",
            ShortName = "anguished face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😨",
            Code = "1f628",
            ShortName = "fearful face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😩",
            Code = "1f629",
            ShortName = "weary face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤯",
            Code = "1f92f",
            ShortName = "exploding head",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😬",
            Code = "1f62c",
            ShortName = "grimacing face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😰",
            Code = "1f630",
            ShortName = "face with open mouth &amp; cold sweat",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😱",
            Code = "1f631",
            ShortName = "face screaming in fear",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😳",
            Code = "1f633",
            ShortName = "flushed face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤪",
            Code = "1f92a",
            ShortName = "crazy face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😵",
            Code = "1f635",
            ShortName = "dizzy face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😡",
            Code = "1f621",
            ShortName = "pouting face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😠",
            Code = "1f620",
            ShortName = "angry face",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤬",
            Code = "1f92c",
            ShortName = "face with symbols over mouth",
            Category = "face-negative",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😷",
            Code = "1f637",
            ShortName = "face with medical mask",
            Category = "face-sick",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤒",
            Code = "1f912",
            ShortName = "face with thermometer",
            Category = "face-sick",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤕",
            Code = "1f915",
            ShortName = "face with head-bandage",
            Category = "face-sick",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤢",
            Code = "1f922",
            ShortName = "nauseated face",
            Category = "face-sick",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤮",
            Code = "1f92e",
            ShortName = "face vomiting",
            Category = "face-sick",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤧",
            Code = "1f927",
            ShortName = "sneezing face",
            Category = "face-sick",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😇",
            Code = "1f607",
            ShortName = "smiling face with halo",
            Category = "face-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤠",
            Code = "1f920",
            ShortName = "cowboy hat face",
            Category = "face-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤡",
            Code = "1f921",
            ShortName = "clown face",
            Category = "face-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤥",
            Code = "1f925",
            ShortName = "lying face",
            Category = "face-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤫",
            Code = "1f92b",
            ShortName = "shushing face",
            Category = "face-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤭",
            Code = "1f92d",
            ShortName = "face with hand over mouth",
            Category = "face-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧐",
            Code = "1f9d0",
            ShortName = "face with monocle",
            Category = "face-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤓",
            Code = "1f913",
            ShortName = "nerd face",
            Category = "face-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😈",
            Code = "1f608",
            ShortName = "smiling face with horns",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👿",
            Code = "1f47f",
            ShortName = "angry face with horns",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👹",
            Code = "1f479",
            ShortName = "ogre",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👺",
            Code = "1f47a",
            ShortName = "goblin",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💀",
            Code = "1f480",
            ShortName = "skull",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☠",
            Code = "2620",
            ShortName = "skull and crossbones",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👻",
            Code = "1f47b",
            ShortName = "ghost",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👽",
            Code = "1f47d",
            ShortName = "alien",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👾",
            Code = "1f47e",
            ShortName = "alien monster",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤖",
            Code = "1f916",
            ShortName = "robot face",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💩",
            Code = "1f4a9",
            ShortName = "pile of poo",
            Category = "face-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😺",
            Code = "1f63a",
            ShortName = "smiling cat face with open mouth",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😸",
            Code = "1f638",
            ShortName = "grinning cat face with smiling eyes",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😹",
            Code = "1f639",
            ShortName = "cat face with tears of joy",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😻",
            Code = "1f63b",
            ShortName = "smiling cat face with heart-eyes",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😼",
            Code = "1f63c",
            ShortName = "cat face with wry smile",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😽",
            Code = "1f63d",
            ShortName = "kissing cat face with closed eyes",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙀",
            Code = "1f640",
            ShortName = "weary cat face",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😿",
            Code = "1f63f",
            ShortName = "crying cat face",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "😾",
            Code = "1f63e",
            ShortName = "pouting cat face",
            Category = "cat-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙈",
            Code = "1f648",
            ShortName = "see-no-evil monkey",
            Category = "monkey-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙉",
            Code = "1f649",
            ShortName = "hear-no-evil monkey",
            Category = "monkey-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙊",
            Code = "1f64a",
            ShortName = "speak-no-evil monkey",
            Category = "monkey-face",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👶",
            Code = "1f476",
            ShortName = "baby",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👶🏻",
            Code = "1f476_1f3fb",
            ShortName = "baby: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👶🏼",
            Code = "1f476_1f3fc",
            ShortName = "baby: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👶🏽",
            Code = "1f476_1f3fd",
            ShortName = "baby: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👶🏾",
            Code = "1f476_1f3fe",
            ShortName = "baby: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👶🏿",
            Code = "1f476_1f3ff",
            ShortName = "baby: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧒",
            Code = "1f9d2",
            ShortName = "child",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧒🏻",
            Code = "1f9d2_1f3fb",
            ShortName = "child: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧒🏼",
            Code = "1f9d2_1f3fc",
            ShortName = "child: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧒🏽",
            Code = "1f9d2_1f3fd",
            ShortName = "child: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧒🏾",
            Code = "1f9d2_1f3fe",
            ShortName = "child: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧒🏿",
            Code = "1f9d2_1f3ff",
            ShortName = "child: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👦",
            Code = "1f466",
            ShortName = "boy",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👦🏻",
            Code = "1f466_1f3fb",
            ShortName = "boy: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👦🏼",
            Code = "1f466_1f3fc",
            ShortName = "boy: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👦🏽",
            Code = "1f466_1f3fd",
            ShortName = "boy: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👦🏾",
            Code = "1f466_1f3fe",
            ShortName = "boy: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👦🏿",
            Code = "1f466_1f3ff",
            ShortName = "boy: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👧",
            Code = "1f467",
            ShortName = "girl",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👧🏻",
            Code = "1f467_1f3fb",
            ShortName = "girl: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👧🏼",
            Code = "1f467_1f3fc",
            ShortName = "girl: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👧🏽",
            Code = "1f467_1f3fd",
            ShortName = "girl: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👧🏾",
            Code = "1f467_1f3fe",
            ShortName = "girl: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👧🏿",
            Code = "1f467_1f3ff",
            ShortName = "girl: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧑",
            Code = "1f9d1",
            ShortName = "adult",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧑🏻",
            Code = "1f9d1_1f3fb",
            ShortName = "adult: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧑🏼",
            Code = "1f9d1_1f3fc",
            ShortName = "adult: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧑🏽",
            Code = "1f9d1_1f3fd",
            ShortName = "adult: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧑🏾",
            Code = "1f9d1_1f3fe",
            ShortName = "adult: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧑🏿",
            Code = "1f9d1_1f3ff",
            ShortName = "adult: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨",
            Code = "1f468",
            ShortName = "man",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻",
            Code = "1f468_1f3fb",
            ShortName = "man: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼",
            Code = "1f468_1f3fc",
            ShortName = "man: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽",
            Code = "1f468_1f3fd",
            ShortName = "man: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾",
            Code = "1f468_1f3fe",
            ShortName = "man: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿",
            Code = "1f468_1f3ff",
            ShortName = "man: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩",
            Code = "1f469",
            ShortName = "woman",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻",
            Code = "1f469_1f3fb",
            ShortName = "woman: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼",
            Code = "1f469_1f3fc",
            ShortName = "woman: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽",
            Code = "1f469_1f3fd",
            ShortName = "woman: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾",
            Code = "1f469_1f3fe",
            ShortName = "woman: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿",
            Code = "1f469_1f3ff",
            ShortName = "woman: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧓",
            Code = "1f9d3",
            ShortName = "older adult",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧓🏻",
            Code = "1f9d3_1f3fb",
            ShortName = "older adult: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧓🏼",
            Code = "1f9d3_1f3fc",
            ShortName = "older adult: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧓🏽",
            Code = "1f9d3_1f3fd",
            ShortName = "older adult: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧓🏾",
            Code = "1f9d3_1f3fe",
            ShortName = "older adult: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧓🏿",
            Code = "1f9d3_1f3ff",
            ShortName = "older adult: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👴",
            Code = "1f474",
            ShortName = "old man",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👴🏻",
            Code = "1f474_1f3fb",
            ShortName = "old man: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👴🏼",
            Code = "1f474_1f3fc",
            ShortName = "old man: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👴🏽",
            Code = "1f474_1f3fd",
            ShortName = "old man: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👴🏾",
            Code = "1f474_1f3fe",
            ShortName = "old man: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👴🏿",
            Code = "1f474_1f3ff",
            ShortName = "old man: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👵",
            Code = "1f475",
            ShortName = "old woman",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👵🏻",
            Code = "1f475_1f3fb",
            ShortName = "old woman: light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👵🏼",
            Code = "1f475_1f3fc",
            ShortName = "old woman: medium-light skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👵🏽",
            Code = "1f475_1f3fd",
            ShortName = "old woman: medium skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👵🏾",
            Code = "1f475_1f3fe",
            ShortName = "old woman: medium-dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👵🏿",
            Code = "1f475_1f3ff",
            ShortName = "old woman: dark skin tone",
            Category = "person",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍⚕️",
            Code = "1f468_200d_2695_fe0f",
            ShortName = "man health worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍⚕️",
            Code = "1f468_1f3fb_200d_2695_fe0f",
            ShortName = "man health worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍⚕️",
            Code = "1f468_1f3fc_200d_2695_fe0f",
            ShortName = "man health worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍⚕️",
            Code = "1f468_1f3fd_200d_2695_fe0f",
            ShortName = "man health worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍⚕️",
            Code = "1f468_1f3fe_200d_2695_fe0f",
            ShortName = "man health worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍⚕️",
            Code = "1f468_1f3ff_200d_2695_fe0f",
            ShortName = "man health worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍⚕️",
            Code = "1f469_200d_2695_fe0f",
            ShortName = "woman health worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍⚕️",
            Code = "1f469_1f3fb_200d_2695_fe0f",
            ShortName = "woman health worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍⚕️",
            Code = "1f469_1f3fc_200d_2695_fe0f",
            ShortName = "woman health worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍⚕️",
            Code = "1f469_1f3fd_200d_2695_fe0f",
            ShortName = "woman health worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍⚕️",
            Code = "1f469_1f3fe_200d_2695_fe0f",
            ShortName = "woman health worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍⚕️",
            Code = "1f469_1f3ff_200d_2695_fe0f",
            ShortName = "woman health worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🎓",
            Code = "1f468_200d_1f393",
            ShortName = "man student",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🎓",
            Code = "1f468_1f3fb_200d_1f393",
            ShortName = "man student: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🎓",
            Code = "1f468_1f3fc_200d_1f393",
            ShortName = "man student: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🎓",
            Code = "1f468_1f3fd_200d_1f393",
            ShortName = "man student: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🎓",
            Code = "1f468_1f3fe_200d_1f393",
            ShortName = "man student: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🎓",
            Code = "1f468_1f3ff_200d_1f393",
            ShortName = "man student: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🎓",
            Code = "1f469_200d_1f393",
            ShortName = "woman student",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🎓",
            Code = "1f469_1f3fb_200d_1f393",
            ShortName = "woman student: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🎓",
            Code = "1f469_1f3fc_200d_1f393",
            ShortName = "woman student: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🎓",
            Code = "1f469_1f3fd_200d_1f393",
            ShortName = "woman student: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🎓",
            Code = "1f469_1f3fe_200d_1f393",
            ShortName = "woman student: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🎓",
            Code = "1f469_1f3ff_200d_1f393",
            ShortName = "woman student: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🏫",
            Code = "1f468_200d_1f3eb",
            ShortName = "man teacher",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🏫",
            Code = "1f468_1f3fb_200d_1f3eb",
            ShortName = "man teacher: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🏫",
            Code = "1f468_1f3fc_200d_1f3eb",
            ShortName = "man teacher: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🏫",
            Code = "1f468_1f3fd_200d_1f3eb",
            ShortName = "man teacher: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🏫",
            Code = "1f468_1f3fe_200d_1f3eb",
            ShortName = "man teacher: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🏫",
            Code = "1f468_1f3ff_200d_1f3eb",
            ShortName = "man teacher: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🏫",
            Code = "1f469_200d_1f3eb",
            ShortName = "woman teacher",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🏫",
            Code = "1f469_1f3fb_200d_1f3eb",
            ShortName = "woman teacher: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🏫",
            Code = "1f469_1f3fc_200d_1f3eb",
            ShortName = "woman teacher: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🏫",
            Code = "1f469_1f3fd_200d_1f3eb",
            ShortName = "woman teacher: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🏫",
            Code = "1f469_1f3fe_200d_1f3eb",
            ShortName = "woman teacher: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🏫",
            Code = "1f469_1f3ff_200d_1f3eb",
            ShortName = "woman teacher: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍⚖️",
            Code = "1f468_200d_2696_fe0f",
            ShortName = "man judge",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍⚖️",
            Code = "1f468_1f3fb_200d_2696_fe0f",
            ShortName = "man judge: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍⚖️",
            Code = "1f468_1f3fc_200d_2696_fe0f",
            ShortName = "man judge: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍⚖️",
            Code = "1f468_1f3fd_200d_2696_fe0f",
            ShortName = "man judge: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍⚖️",
            Code = "1f468_1f3fe_200d_2696_fe0f",
            ShortName = "man judge: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍⚖️",
            Code = "1f468_1f3ff_200d_2696_fe0f",
            ShortName = "man judge: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍⚖️",
            Code = "1f469_200d_2696_fe0f",
            ShortName = "woman judge",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍⚖️",
            Code = "1f469_1f3fb_200d_2696_fe0f",
            ShortName = "woman judge: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍⚖️",
            Code = "1f469_1f3fc_200d_2696_fe0f",
            ShortName = "woman judge: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍⚖️",
            Code = "1f469_1f3fd_200d_2696_fe0f",
            ShortName = "woman judge: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍⚖️",
            Code = "1f469_1f3fe_200d_2696_fe0f",
            ShortName = "woman judge: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍⚖️",
            Code = "1f469_1f3ff_200d_2696_fe0f",
            ShortName = "woman judge: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🌾",
            Code = "1f468_200d_1f33e",
            ShortName = "man farmer",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🌾",
            Code = "1f468_1f3fb_200d_1f33e",
            ShortName = "man farmer: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🌾",
            Code = "1f468_1f3fc_200d_1f33e",
            ShortName = "man farmer: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🌾",
            Code = "1f468_1f3fd_200d_1f33e",
            ShortName = "man farmer: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🌾",
            Code = "1f468_1f3fe_200d_1f33e",
            ShortName = "man farmer: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🌾",
            Code = "1f468_1f3ff_200d_1f33e",
            ShortName = "man farmer: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🌾",
            Code = "1f469_200d_1f33e",
            ShortName = "woman farmer",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🌾",
            Code = "1f469_1f3fb_200d_1f33e",
            ShortName = "woman farmer: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🌾",
            Code = "1f469_1f3fc_200d_1f33e",
            ShortName = "woman farmer: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🌾",
            Code = "1f469_1f3fd_200d_1f33e",
            ShortName = "woman farmer: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🌾",
            Code = "1f469_1f3fe_200d_1f33e",
            ShortName = "woman farmer: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🌾",
            Code = "1f469_1f3ff_200d_1f33e",
            ShortName = "woman farmer: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🍳",
            Code = "1f468_200d_1f373",
            ShortName = "man cook",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🍳",
            Code = "1f468_1f3fb_200d_1f373",
            ShortName = "man cook: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🍳",
            Code = "1f468_1f3fc_200d_1f373",
            ShortName = "man cook: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🍳",
            Code = "1f468_1f3fd_200d_1f373",
            ShortName = "man cook: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🍳",
            Code = "1f468_1f3fe_200d_1f373",
            ShortName = "man cook: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🍳",
            Code = "1f468_1f3ff_200d_1f373",
            ShortName = "man cook: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🍳",
            Code = "1f469_200d_1f373",
            ShortName = "woman cook",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🍳",
            Code = "1f469_1f3fb_200d_1f373",
            ShortName = "woman cook: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🍳",
            Code = "1f469_1f3fc_200d_1f373",
            ShortName = "woman cook: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🍳",
            Code = "1f469_1f3fd_200d_1f373",
            ShortName = "woman cook: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🍳",
            Code = "1f469_1f3fe_200d_1f373",
            ShortName = "woman cook: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🍳",
            Code = "1f469_1f3ff_200d_1f373",
            ShortName = "woman cook: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🔧",
            Code = "1f468_200d_1f527",
            ShortName = "man mechanic",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🔧",
            Code = "1f468_1f3fb_200d_1f527",
            ShortName = "man mechanic: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🔧",
            Code = "1f468_1f3fc_200d_1f527",
            ShortName = "man mechanic: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🔧",
            Code = "1f468_1f3fd_200d_1f527",
            ShortName = "man mechanic: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🔧",
            Code = "1f468_1f3fe_200d_1f527",
            ShortName = "man mechanic: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🔧",
            Code = "1f468_1f3ff_200d_1f527",
            ShortName = "man mechanic: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🔧",
            Code = "1f469_200d_1f527",
            ShortName = "woman mechanic",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🔧",
            Code = "1f469_1f3fb_200d_1f527",
            ShortName = "woman mechanic: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🔧",
            Code = "1f469_1f3fc_200d_1f527",
            ShortName = "woman mechanic: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🔧",
            Code = "1f469_1f3fd_200d_1f527",
            ShortName = "woman mechanic: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🔧",
            Code = "1f469_1f3fe_200d_1f527",
            ShortName = "woman mechanic: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🔧",
            Code = "1f469_1f3ff_200d_1f527",
            ShortName = "woman mechanic: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🏭",
            Code = "1f468_200d_1f3ed",
            ShortName = "man factory worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🏭",
            Code = "1f468_1f3fb_200d_1f3ed",
            ShortName = "man factory worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🏭",
            Code = "1f468_1f3fc_200d_1f3ed",
            ShortName = "man factory worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🏭",
            Code = "1f468_1f3fd_200d_1f3ed",
            ShortName = "man factory worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🏭",
            Code = "1f468_1f3fe_200d_1f3ed",
            ShortName = "man factory worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🏭",
            Code = "1f468_1f3ff_200d_1f3ed",
            ShortName = "man factory worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🏭",
            Code = "1f469_200d_1f3ed",
            ShortName = "woman factory worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🏭",
            Code = "1f469_1f3fb_200d_1f3ed",
            ShortName = "woman factory worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🏭",
            Code = "1f469_1f3fc_200d_1f3ed",
            ShortName = "woman factory worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🏭",
            Code = "1f469_1f3fd_200d_1f3ed",
            ShortName = "woman factory worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🏭",
            Code = "1f469_1f3fe_200d_1f3ed",
            ShortName = "woman factory worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🏭",
            Code = "1f469_1f3ff_200d_1f3ed",
            ShortName = "woman factory worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍💼",
            Code = "1f468_200d_1f4bc",
            ShortName = "man office worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍💼",
            Code = "1f468_1f3fb_200d_1f4bc",
            ShortName = "man office worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍💼",
            Code = "1f468_1f3fc_200d_1f4bc",
            ShortName = "man office worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍💼",
            Code = "1f468_1f3fd_200d_1f4bc",
            ShortName = "man office worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍💼",
            Code = "1f468_1f3fe_200d_1f4bc",
            ShortName = "man office worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍💼",
            Code = "1f468_1f3ff_200d_1f4bc",
            ShortName = "man office worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍💼",
            Code = "1f469_200d_1f4bc",
            ShortName = "woman office worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍💼",
            Code = "1f469_1f3fb_200d_1f4bc",
            ShortName = "woman office worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍💼",
            Code = "1f469_1f3fc_200d_1f4bc",
            ShortName = "woman office worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍💼",
            Code = "1f469_1f3fd_200d_1f4bc",
            ShortName = "woman office worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍💼",
            Code = "1f469_1f3fe_200d_1f4bc",
            ShortName = "woman office worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍💼",
            Code = "1f469_1f3ff_200d_1f4bc",
            ShortName = "woman office worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🔬",
            Code = "1f468_200d_1f52c",
            ShortName = "man scientist",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🔬",
            Code = "1f468_1f3fb_200d_1f52c",
            ShortName = "man scientist: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🔬",
            Code = "1f468_1f3fc_200d_1f52c",
            ShortName = "man scientist: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🔬",
            Code = "1f468_1f3fd_200d_1f52c",
            ShortName = "man scientist: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🔬",
            Code = "1f468_1f3fe_200d_1f52c",
            ShortName = "man scientist: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🔬",
            Code = "1f468_1f3ff_200d_1f52c",
            ShortName = "man scientist: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🔬",
            Code = "1f469_200d_1f52c",
            ShortName = "woman scientist",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🔬",
            Code = "1f469_1f3fb_200d_1f52c",
            ShortName = "woman scientist: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🔬",
            Code = "1f469_1f3fc_200d_1f52c",
            ShortName = "woman scientist: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🔬",
            Code = "1f469_1f3fd_200d_1f52c",
            ShortName = "woman scientist: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🔬",
            Code = "1f469_1f3fe_200d_1f52c",
            ShortName = "woman scientist: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🔬",
            Code = "1f469_1f3ff_200d_1f52c",
            ShortName = "woman scientist: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍💻",
            Code = "1f468_200d_1f4bb",
            ShortName = "man technologist",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍💻",
            Code = "1f468_1f3fb_200d_1f4bb",
            ShortName = "man technologist: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍💻",
            Code = "1f468_1f3fc_200d_1f4bb",
            ShortName = "man technologist: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍💻",
            Code = "1f468_1f3fd_200d_1f4bb",
            ShortName = "man technologist: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍💻",
            Code = "1f468_1f3fe_200d_1f4bb",
            ShortName = "man technologist: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍💻",
            Code = "1f468_1f3ff_200d_1f4bb",
            ShortName = "man technologist: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍💻",
            Code = "1f469_200d_1f4bb",
            ShortName = "woman technologist",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍💻",
            Code = "1f469_1f3fb_200d_1f4bb",
            ShortName = "woman technologist: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍💻",
            Code = "1f469_1f3fc_200d_1f4bb",
            ShortName = "woman technologist: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍💻",
            Code = "1f469_1f3fd_200d_1f4bb",
            ShortName = "woman technologist: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍💻",
            Code = "1f469_1f3fe_200d_1f4bb",
            ShortName = "woman technologist: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍💻",
            Code = "1f469_1f3ff_200d_1f4bb",
            ShortName = "woman technologist: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🎤",
            Code = "1f468_200d_1f3a4",
            ShortName = "man singer",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🎤",
            Code = "1f468_1f3fb_200d_1f3a4",
            ShortName = "man singer: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🎤",
            Code = "1f468_1f3fc_200d_1f3a4",
            ShortName = "man singer: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🎤",
            Code = "1f468_1f3fd_200d_1f3a4",
            ShortName = "man singer: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🎤",
            Code = "1f468_1f3fe_200d_1f3a4",
            ShortName = "man singer: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🎤",
            Code = "1f468_1f3ff_200d_1f3a4",
            ShortName = "man singer: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🎤",
            Code = "1f469_200d_1f3a4",
            ShortName = "woman singer",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🎤",
            Code = "1f469_1f3fb_200d_1f3a4",
            ShortName = "woman singer: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🎤",
            Code = "1f469_1f3fc_200d_1f3a4",
            ShortName = "woman singer: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🎤",
            Code = "1f469_1f3fd_200d_1f3a4",
            ShortName = "woman singer: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🎤",
            Code = "1f469_1f3fe_200d_1f3a4",
            ShortName = "woman singer: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🎤",
            Code = "1f469_1f3ff_200d_1f3a4",
            ShortName = "woman singer: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🎨",
            Code = "1f468_200d_1f3a8",
            ShortName = "man artist",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🎨",
            Code = "1f468_1f3fb_200d_1f3a8",
            ShortName = "man artist: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🎨",
            Code = "1f468_1f3fc_200d_1f3a8",
            ShortName = "man artist: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🎨",
            Code = "1f468_1f3fd_200d_1f3a8",
            ShortName = "man artist: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🎨",
            Code = "1f468_1f3fe_200d_1f3a8",
            ShortName = "man artist: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🎨",
            Code = "1f468_1f3ff_200d_1f3a8",
            ShortName = "man artist: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🎨",
            Code = "1f469_200d_1f3a8",
            ShortName = "woman artist",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🎨",
            Code = "1f469_1f3fb_200d_1f3a8",
            ShortName = "woman artist: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🎨",
            Code = "1f469_1f3fc_200d_1f3a8",
            ShortName = "woman artist: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🎨",
            Code = "1f469_1f3fd_200d_1f3a8",
            ShortName = "woman artist: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🎨",
            Code = "1f469_1f3fe_200d_1f3a8",
            ShortName = "woman artist: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🎨",
            Code = "1f469_1f3ff_200d_1f3a8",
            ShortName = "woman artist: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍✈️",
            Code = "1f468_200d_2708_fe0f",
            ShortName = "man pilot",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍✈️",
            Code = "1f468_1f3fb_200d_2708_fe0f",
            ShortName = "man pilot: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍✈️",
            Code = "1f468_1f3fc_200d_2708_fe0f",
            ShortName = "man pilot: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍✈️",
            Code = "1f468_1f3fd_200d_2708_fe0f",
            ShortName = "man pilot: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍✈️",
            Code = "1f468_1f3fe_200d_2708_fe0f",
            ShortName = "man pilot: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍✈️",
            Code = "1f468_1f3ff_200d_2708_fe0f",
            ShortName = "man pilot: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍✈️",
            Code = "1f469_200d_2708_fe0f",
            ShortName = "woman pilot",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍✈️",
            Code = "1f469_1f3fb_200d_2708_fe0f",
            ShortName = "woman pilot: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍✈️",
            Code = "1f469_1f3fc_200d_2708_fe0f",
            ShortName = "woman pilot: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍✈️",
            Code = "1f469_1f3fd_200d_2708_fe0f",
            ShortName = "woman pilot: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍✈️",
            Code = "1f469_1f3fe_200d_2708_fe0f",
            ShortName = "woman pilot: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍✈️",
            Code = "1f469_1f3ff_200d_2708_fe0f",
            ShortName = "woman pilot: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🚀",
            Code = "1f468_200d_1f680",
            ShortName = "man astronaut",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🚀",
            Code = "1f468_1f3fb_200d_1f680",
            ShortName = "man astronaut: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🚀",
            Code = "1f468_1f3fc_200d_1f680",
            ShortName = "man astronaut: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🚀",
            Code = "1f468_1f3fd_200d_1f680",
            ShortName = "man astronaut: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🚀",
            Code = "1f468_1f3fe_200d_1f680",
            ShortName = "man astronaut: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🚀",
            Code = "1f468_1f3ff_200d_1f680",
            ShortName = "man astronaut: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🚀",
            Code = "1f469_200d_1f680",
            ShortName = "woman astronaut",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🚀",
            Code = "1f469_1f3fb_200d_1f680",
            ShortName = "woman astronaut: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🚀",
            Code = "1f469_1f3fc_200d_1f680",
            ShortName = "woman astronaut: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🚀",
            Code = "1f469_1f3fd_200d_1f680",
            ShortName = "woman astronaut: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🚀",
            Code = "1f469_1f3fe_200d_1f680",
            ShortName = "woman astronaut: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🚀",
            Code = "1f469_1f3ff_200d_1f680",
            ShortName = "woman astronaut: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍🚒",
            Code = "1f468_200d_1f692",
            ShortName = "man firefighter",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏻‍🚒",
            Code = "1f468_1f3fb_200d_1f692",
            ShortName = "man firefighter: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏼‍🚒",
            Code = "1f468_1f3fc_200d_1f692",
            ShortName = "man firefighter: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏽‍🚒",
            Code = "1f468_1f3fd_200d_1f692",
            ShortName = "man firefighter: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏾‍🚒",
            Code = "1f468_1f3fe_200d_1f692",
            ShortName = "man firefighter: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨🏿‍🚒",
            Code = "1f468_1f3ff_200d_1f692",
            ShortName = "man firefighter: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍🚒",
            Code = "1f469_200d_1f692",
            ShortName = "woman firefighter",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏻‍🚒",
            Code = "1f469_1f3fb_200d_1f692",
            ShortName = "woman firefighter: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏼‍🚒",
            Code = "1f469_1f3fc_200d_1f692",
            ShortName = "woman firefighter: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏽‍🚒",
            Code = "1f469_1f3fd_200d_1f692",
            ShortName = "woman firefighter: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏾‍🚒",
            Code = "1f469_1f3fe_200d_1f692",
            ShortName = "woman firefighter: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩🏿‍🚒",
            Code = "1f469_1f3ff_200d_1f692",
            ShortName = "woman firefighter: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮",
            Code = "1f46e",
            ShortName = "police officer",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏻",
            Code = "1f46e_1f3fb",
            ShortName = "police officer: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏼",
            Code = "1f46e_1f3fc",
            ShortName = "police officer: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏽",
            Code = "1f46e_1f3fd",
            ShortName = "police officer: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏾",
            Code = "1f46e_1f3fe",
            ShortName = "police officer: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏿",
            Code = "1f46e_1f3ff",
            ShortName = "police officer: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮‍♂️",
            Code = "1f46e_200d_2642_fe0f",
            ShortName = "man police officer",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏻‍♂️",
            Code = "1f46e_1f3fb_200d_2642_fe0f",
            ShortName = "man police officer: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏼‍♂️",
            Code = "1f46e_1f3fc_200d_2642_fe0f",
            ShortName = "man police officer: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏽‍♂️",
            Code = "1f46e_1f3fd_200d_2642_fe0f",
            ShortName = "man police officer: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏾‍♂️",
            Code = "1f46e_1f3fe_200d_2642_fe0f",
            ShortName = "man police officer: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏿‍♂️",
            Code = "1f46e_1f3ff_200d_2642_fe0f",
            ShortName = "man police officer: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮‍♀️",
            Code = "1f46e_200d_2640_fe0f",
            ShortName = "woman police officer",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏻‍♀️",
            Code = "1f46e_1f3fb_200d_2640_fe0f",
            ShortName = "woman police officer: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏼‍♀️",
            Code = "1f46e_1f3fc_200d_2640_fe0f",
            ShortName = "woman police officer: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏽‍♀️",
            Code = "1f46e_1f3fd_200d_2640_fe0f",
            ShortName = "woman police officer: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏾‍♀️",
            Code = "1f46e_1f3fe_200d_2640_fe0f",
            ShortName = "woman police officer: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👮🏿‍♀️",
            Code = "1f46e_1f3ff_200d_2640_fe0f",
            ShortName = "woman police officer: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵",
            Code = "1f575",
            ShortName = "detective",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏻",
            Code = "1f575_1f3fb",
            ShortName = "detective: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏼",
            Code = "1f575_1f3fc",
            ShortName = "detective: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏽",
            Code = "1f575_1f3fd",
            ShortName = "detective: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏾",
            Code = "1f575_1f3fe",
            ShortName = "detective: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏿",
            Code = "1f575_1f3ff",
            ShortName = "detective: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵️‍♂️",
            Code = "1f575_fe0f_200d_2642_fe0f",
            ShortName = "man detective",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏻‍♂️",
            Code = "1f575_1f3fb_200d_2642_fe0f",
            ShortName = "man detective: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏼‍♂️",
            Code = "1f575_1f3fc_200d_2642_fe0f",
            ShortName = "man detective: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏽‍♂️",
            Code = "1f575_1f3fd_200d_2642_fe0f",
            ShortName = "man detective: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏾‍♂️",
            Code = "1f575_1f3fe_200d_2642_fe0f",
            ShortName = "man detective: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏿‍♂️",
            Code = "1f575_1f3ff_200d_2642_fe0f",
            ShortName = "man detective: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵️‍♀️",
            Code = "1f575_fe0f_200d_2640_fe0f",
            ShortName = "woman detective",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏻‍♀️",
            Code = "1f575_1f3fb_200d_2640_fe0f",
            ShortName = "woman detective: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏼‍♀️",
            Code = "1f575_1f3fc_200d_2640_fe0f",
            ShortName = "woman detective: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏽‍♀️",
            Code = "1f575_1f3fd_200d_2640_fe0f",
            ShortName = "woman detective: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏾‍♀️",
            Code = "1f575_1f3fe_200d_2640_fe0f",
            ShortName = "woman detective: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕵🏿‍♀️",
            Code = "1f575_1f3ff_200d_2640_fe0f",
            ShortName = "woman detective: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂",
            Code = "1f482",
            ShortName = "guard",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏻",
            Code = "1f482_1f3fb",
            ShortName = "guard: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏼",
            Code = "1f482_1f3fc",
            ShortName = "guard: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏽",
            Code = "1f482_1f3fd",
            ShortName = "guard: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏾",
            Code = "1f482_1f3fe",
            ShortName = "guard: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏿",
            Code = "1f482_1f3ff",
            ShortName = "guard: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂‍♂️",
            Code = "1f482_200d_2642_fe0f",
            ShortName = "man guard",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏻‍♂️",
            Code = "1f482_1f3fb_200d_2642_fe0f",
            ShortName = "man guard: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏼‍♂️",
            Code = "1f482_1f3fc_200d_2642_fe0f",
            ShortName = "man guard: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏽‍♂️",
            Code = "1f482_1f3fd_200d_2642_fe0f",
            ShortName = "man guard: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏾‍♂️",
            Code = "1f482_1f3fe_200d_2642_fe0f",
            ShortName = "man guard: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏿‍♂️",
            Code = "1f482_1f3ff_200d_2642_fe0f",
            ShortName = "man guard: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂‍♀️",
            Code = "1f482_200d_2640_fe0f",
            ShortName = "woman guard",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏻‍♀️",
            Code = "1f482_1f3fb_200d_2640_fe0f",
            ShortName = "woman guard: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏼‍♀️",
            Code = "1f482_1f3fc_200d_2640_fe0f",
            ShortName = "woman guard: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏽‍♀️",
            Code = "1f482_1f3fd_200d_2640_fe0f",
            ShortName = "woman guard: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏾‍♀️",
            Code = "1f482_1f3fe_200d_2640_fe0f",
            ShortName = "woman guard: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💂🏿‍♀️",
            Code = "1f482_1f3ff_200d_2640_fe0f",
            ShortName = "woman guard: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷",
            Code = "1f477",
            ShortName = "construction worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏻",
            Code = "1f477_1f3fb",
            ShortName = "construction worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏼",
            Code = "1f477_1f3fc",
            ShortName = "construction worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏽",
            Code = "1f477_1f3fd",
            ShortName = "construction worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏾",
            Code = "1f477_1f3fe",
            ShortName = "construction worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏿",
            Code = "1f477_1f3ff",
            ShortName = "construction worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷‍♂️",
            Code = "1f477_200d_2642_fe0f",
            ShortName = "man construction worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏻‍♂️",
            Code = "1f477_1f3fb_200d_2642_fe0f",
            ShortName = "man construction worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏼‍♂️",
            Code = "1f477_1f3fc_200d_2642_fe0f",
            ShortName = "man construction worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏽‍♂️",
            Code = "1f477_1f3fd_200d_2642_fe0f",
            ShortName = "man construction worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏾‍♂️",
            Code = "1f477_1f3fe_200d_2642_fe0f",
            ShortName = "man construction worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏿‍♂️",
            Code = "1f477_1f3ff_200d_2642_fe0f",
            ShortName = "man construction worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷‍♀️",
            Code = "1f477_200d_2640_fe0f",
            ShortName = "woman construction worker",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏻‍♀️",
            Code = "1f477_1f3fb_200d_2640_fe0f",
            ShortName = "woman construction worker: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏼‍♀️",
            Code = "1f477_1f3fc_200d_2640_fe0f",
            ShortName = "woman construction worker: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏽‍♀️",
            Code = "1f477_1f3fd_200d_2640_fe0f",
            ShortName = "woman construction worker: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏾‍♀️",
            Code = "1f477_1f3fe_200d_2640_fe0f",
            ShortName = "woman construction worker: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👷🏿‍♀️",
            Code = "1f477_1f3ff_200d_2640_fe0f",
            ShortName = "woman construction worker: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤴",
            Code = "1f934",
            ShortName = "prince",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤴🏻",
            Code = "1f934_1f3fb",
            ShortName = "prince: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤴🏼",
            Code = "1f934_1f3fc",
            ShortName = "prince: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤴🏽",
            Code = "1f934_1f3fd",
            ShortName = "prince: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤴🏾",
            Code = "1f934_1f3fe",
            ShortName = "prince: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤴🏿",
            Code = "1f934_1f3ff",
            ShortName = "prince: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👸",
            Code = "1f478",
            ShortName = "princess",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👸🏻",
            Code = "1f478_1f3fb",
            ShortName = "princess: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👸🏼",
            Code = "1f478_1f3fc",
            ShortName = "princess: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👸🏽",
            Code = "1f478_1f3fd",
            ShortName = "princess: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👸🏾",
            Code = "1f478_1f3fe",
            ShortName = "princess: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👸🏿",
            Code = "1f478_1f3ff",
            ShortName = "princess: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳",
            Code = "1f473",
            ShortName = "person wearing turban",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏻",
            Code = "1f473_1f3fb",
            ShortName = "person wearing turban: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏼",
            Code = "1f473_1f3fc",
            ShortName = "person wearing turban: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏽",
            Code = "1f473_1f3fd",
            ShortName = "person wearing turban: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏾",
            Code = "1f473_1f3fe",
            ShortName = "person wearing turban: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏿",
            Code = "1f473_1f3ff",
            ShortName = "person wearing turban: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳‍♂️",
            Code = "1f473_200d_2642_fe0f",
            ShortName = "man wearing turban",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏻‍♂️",
            Code = "1f473_1f3fb_200d_2642_fe0f",
            ShortName = "man wearing turban: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏼‍♂️",
            Code = "1f473_1f3fc_200d_2642_fe0f",
            ShortName = "man wearing turban: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏽‍♂️",
            Code = "1f473_1f3fd_200d_2642_fe0f",
            ShortName = "man wearing turban: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏾‍♂️",
            Code = "1f473_1f3fe_200d_2642_fe0f",
            ShortName = "man wearing turban: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏿‍♂️",
            Code = "1f473_1f3ff_200d_2642_fe0f",
            ShortName = "man wearing turban: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳‍♀️",
            Code = "1f473_200d_2640_fe0f",
            ShortName = "woman wearing turban",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏻‍♀️",
            Code = "1f473_1f3fb_200d_2640_fe0f",
            ShortName = "woman wearing turban: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏼‍♀️",
            Code = "1f473_1f3fc_200d_2640_fe0f",
            ShortName = "woman wearing turban: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏽‍♀️",
            Code = "1f473_1f3fd_200d_2640_fe0f",
            ShortName = "woman wearing turban: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏾‍♀️",
            Code = "1f473_1f3fe_200d_2640_fe0f",
            ShortName = "woman wearing turban: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👳🏿‍♀️",
            Code = "1f473_1f3ff_200d_2640_fe0f",
            ShortName = "woman wearing turban: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👲",
            Code = "1f472",
            ShortName = "man with Chinese cap",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👲🏻",
            Code = "1f472_1f3fb",
            ShortName = "man with Chinese cap: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👲🏼",
            Code = "1f472_1f3fc",
            ShortName = "man with Chinese cap: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👲🏽",
            Code = "1f472_1f3fd",
            ShortName = "man with Chinese cap: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👲🏾",
            Code = "1f472_1f3fe",
            ShortName = "man with Chinese cap: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👲🏿",
            Code = "1f472_1f3ff",
            ShortName = "man with Chinese cap: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧕",
            Code = "1f9d5",
            ShortName = "woman with headscarf",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧕🏻",
            Code = "1f9d5_1f3fb",
            ShortName = "woman with headscarf: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧕🏼",
            Code = "1f9d5_1f3fc",
            ShortName = "woman with headscarf: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧕🏽",
            Code = "1f9d5_1f3fd",
            ShortName = "woman with headscarf: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧕🏾",
            Code = "1f9d5_1f3fe",
            ShortName = "woman with headscarf: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧕🏿",
            Code = "1f9d5_1f3ff",
            ShortName = "woman with headscarf: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧔",
            Code = "1f9d4",
            ShortName = "bearded person",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧔🏻",
            Code = "1f9d4_1f3fb",
            ShortName = "bearded person: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧔🏼",
            Code = "1f9d4_1f3fc",
            ShortName = "bearded person: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧔🏽",
            Code = "1f9d4_1f3fd",
            ShortName = "bearded person: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧔🏾",
            Code = "1f9d4_1f3fe",
            ShortName = "bearded person: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧔🏿",
            Code = "1f9d4_1f3ff",
            ShortName = "bearded person: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱",
            Code = "1f471",
            ShortName = "blond-haired person",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏻",
            Code = "1f471_1f3fb",
            ShortName = "blond-haired person: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏼",
            Code = "1f471_1f3fc",
            ShortName = "blond-haired person: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏽",
            Code = "1f471_1f3fd",
            ShortName = "blond-haired person: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏾",
            Code = "1f471_1f3fe",
            ShortName = "blond-haired person: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏿",
            Code = "1f471_1f3ff",
            ShortName = "blond-haired person: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱‍♂️",
            Code = "1f471_200d_2642_fe0f",
            ShortName = "blond-haired man",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏻‍♂️",
            Code = "1f471_1f3fb_200d_2642_fe0f",
            ShortName = "blond-haired man: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏼‍♂️",
            Code = "1f471_1f3fc_200d_2642_fe0f",
            ShortName = "blond-haired man: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏽‍♂️",
            Code = "1f471_1f3fd_200d_2642_fe0f",
            ShortName = "blond-haired man: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏾‍♂️",
            Code = "1f471_1f3fe_200d_2642_fe0f",
            ShortName = "blond-haired man: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏿‍♂️",
            Code = "1f471_1f3ff_200d_2642_fe0f",
            ShortName = "blond-haired man: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱‍♀️",
            Code = "1f471_200d_2640_fe0f",
            ShortName = "blond-haired woman",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏻‍♀️",
            Code = "1f471_1f3fb_200d_2640_fe0f",
            ShortName = "blond-haired woman: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏼‍♀️",
            Code = "1f471_1f3fc_200d_2640_fe0f",
            ShortName = "blond-haired woman: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏽‍♀️",
            Code = "1f471_1f3fd_200d_2640_fe0f",
            ShortName = "blond-haired woman: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏾‍♀️",
            Code = "1f471_1f3fe_200d_2640_fe0f",
            ShortName = "blond-haired woman: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👱🏿‍♀️",
            Code = "1f471_1f3ff_200d_2640_fe0f",
            ShortName = "blond-haired woman: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤵",
            Code = "1f935",
            ShortName = "man in tuxedo",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤵🏻",
            Code = "1f935_1f3fb",
            ShortName = "man in tuxedo: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤵🏼",
            Code = "1f935_1f3fc",
            ShortName = "man in tuxedo: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤵🏽",
            Code = "1f935_1f3fd",
            ShortName = "man in tuxedo: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤵🏾",
            Code = "1f935_1f3fe",
            ShortName = "man in tuxedo: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤵🏿",
            Code = "1f935_1f3ff",
            ShortName = "man in tuxedo: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👰",
            Code = "1f470",
            ShortName = "bride with veil",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👰🏻",
            Code = "1f470_1f3fb",
            ShortName = "bride with veil: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👰🏼",
            Code = "1f470_1f3fc",
            ShortName = "bride with veil: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👰🏽",
            Code = "1f470_1f3fd",
            ShortName = "bride with veil: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👰🏾",
            Code = "1f470_1f3fe",
            ShortName = "bride with veil: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👰🏿",
            Code = "1f470_1f3ff",
            ShortName = "bride with veil: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤰",
            Code = "1f930",
            ShortName = "pregnant woman",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤰🏻",
            Code = "1f930_1f3fb",
            ShortName = "pregnant woman: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤰🏼",
            Code = "1f930_1f3fc",
            ShortName = "pregnant woman: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤰🏽",
            Code = "1f930_1f3fd",
            ShortName = "pregnant woman: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤰🏾",
            Code = "1f930_1f3fe",
            ShortName = "pregnant woman: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤰🏿",
            Code = "1f930_1f3ff",
            ShortName = "pregnant woman: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤱",
            Code = "1f931",
            ShortName = "breast-feeding",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤱🏻",
            Code = "1f931_1f3fb",
            ShortName = "breast-feeding: light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤱🏼",
            Code = "1f931_1f3fc",
            ShortName = "breast-feeding: medium-light skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤱🏽",
            Code = "1f931_1f3fd",
            ShortName = "breast-feeding: medium skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤱🏾",
            Code = "1f931_1f3fe",
            ShortName = "breast-feeding: medium-dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤱🏿",
            Code = "1f931_1f3ff",
            ShortName = "breast-feeding: dark skin tone",
            Category = "person-role",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👼",
            Code = "1f47c",
            ShortName = "baby angel",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👼🏻",
            Code = "1f47c_1f3fb",
            ShortName = "baby angel: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👼🏼",
            Code = "1f47c_1f3fc",
            ShortName = "baby angel: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👼🏽",
            Code = "1f47c_1f3fd",
            ShortName = "baby angel: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👼🏾",
            Code = "1f47c_1f3fe",
            ShortName = "baby angel: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👼🏿",
            Code = "1f47c_1f3ff",
            ShortName = "baby angel: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎅",
            Code = "1f385",
            ShortName = "Santa Claus",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎅🏻",
            Code = "1f385_1f3fb",
            ShortName = "Santa Claus: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎅🏼",
            Code = "1f385_1f3fc",
            ShortName = "Santa Claus: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎅🏽",
            Code = "1f385_1f3fd",
            ShortName = "Santa Claus: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎅🏾",
            Code = "1f385_1f3fe",
            ShortName = "Santa Claus: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎅🏿",
            Code = "1f385_1f3ff",
            ShortName = "Santa Claus: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤶",
            Code = "1f936",
            ShortName = "Mrs. Claus",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤶🏻",
            Code = "1f936_1f3fb",
            ShortName = "Mrs. Claus: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤶🏼",
            Code = "1f936_1f3fc",
            ShortName = "Mrs. Claus: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤶🏽",
            Code = "1f936_1f3fd",
            ShortName = "Mrs. Claus: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤶🏾",
            Code = "1f936_1f3fe",
            ShortName = "Mrs. Claus: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤶🏿",
            Code = "1f936_1f3ff",
            ShortName = "Mrs. Claus: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙",
            Code = "1f9d9",
            ShortName = "mage",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏻",
            Code = "1f9d9_1f3fb",
            ShortName = "mage: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏼",
            Code = "1f9d9_1f3fc",
            ShortName = "mage: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏽",
            Code = "1f9d9_1f3fd",
            ShortName = "mage: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏾",
            Code = "1f9d9_1f3fe",
            ShortName = "mage: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏿",
            Code = "1f9d9_1f3ff",
            ShortName = "mage: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙‍♀️",
            Code = "1f9d9_200d_2640_fe0f",
            ShortName = "woman mage",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏻‍♀️",
            Code = "1f9d9_1f3fb_200d_2640_fe0f",
            ShortName = "woman mage: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏼‍♀️",
            Code = "1f9d9_1f3fc_200d_2640_fe0f",
            ShortName = "woman mage: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏽‍♀️",
            Code = "1f9d9_1f3fd_200d_2640_fe0f",
            ShortName = "woman mage: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏾‍♀️",
            Code = "1f9d9_1f3fe_200d_2640_fe0f",
            ShortName = "woman mage: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏿‍♀️",
            Code = "1f9d9_1f3ff_200d_2640_fe0f",
            ShortName = "woman mage: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙‍♂️",
            Code = "1f9d9_200d_2642_fe0f",
            ShortName = "man mage",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏻‍♂️",
            Code = "1f9d9_1f3fb_200d_2642_fe0f",
            ShortName = "man mage: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏼‍♂️",
            Code = "1f9d9_1f3fc_200d_2642_fe0f",
            ShortName = "man mage: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏽‍♂️",
            Code = "1f9d9_1f3fd_200d_2642_fe0f",
            ShortName = "man mage: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏾‍♂️",
            Code = "1f9d9_1f3fe_200d_2642_fe0f",
            ShortName = "man mage: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧙🏿‍♂️",
            Code = "1f9d9_1f3ff_200d_2642_fe0f",
            ShortName = "man mage: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚",
            Code = "1f9da",
            ShortName = "fairy",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏻",
            Code = "1f9da_1f3fb",
            ShortName = "fairy: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏼",
            Code = "1f9da_1f3fc",
            ShortName = "fairy: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏽",
            Code = "1f9da_1f3fd",
            ShortName = "fairy: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏾",
            Code = "1f9da_1f3fe",
            ShortName = "fairy: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏿",
            Code = "1f9da_1f3ff",
            ShortName = "fairy: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚‍♀️",
            Code = "1f9da_200d_2640_fe0f",
            ShortName = "woman fairy",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏻‍♀️",
            Code = "1f9da_1f3fb_200d_2640_fe0f",
            ShortName = "woman fairy: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏼‍♀️",
            Code = "1f9da_1f3fc_200d_2640_fe0f",
            ShortName = "woman fairy: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏽‍♀️",
            Code = "1f9da_1f3fd_200d_2640_fe0f",
            ShortName = "woman fairy: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏾‍♀️",
            Code = "1f9da_1f3fe_200d_2640_fe0f",
            ShortName = "woman fairy: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏿‍♀️",
            Code = "1f9da_1f3ff_200d_2640_fe0f",
            ShortName = "woman fairy: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚‍♂️",
            Code = "1f9da_200d_2642_fe0f",
            ShortName = "man fairy",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏻‍♂️",
            Code = "1f9da_1f3fb_200d_2642_fe0f",
            ShortName = "man fairy: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏼‍♂️",
            Code = "1f9da_1f3fc_200d_2642_fe0f",
            ShortName = "man fairy: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏽‍♂️",
            Code = "1f9da_1f3fd_200d_2642_fe0f",
            ShortName = "man fairy: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏾‍♂️",
            Code = "1f9da_1f3fe_200d_2642_fe0f",
            ShortName = "man fairy: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧚🏿‍♂️",
            Code = "1f9da_1f3ff_200d_2642_fe0f",
            ShortName = "man fairy: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛",
            Code = "1f9db",
            ShortName = "vampire",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏻",
            Code = "1f9db_1f3fb",
            ShortName = "vampire: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏼",
            Code = "1f9db_1f3fc",
            ShortName = "vampire: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏽",
            Code = "1f9db_1f3fd",
            ShortName = "vampire: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏾",
            Code = "1f9db_1f3fe",
            ShortName = "vampire: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏿",
            Code = "1f9db_1f3ff",
            ShortName = "vampire: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛‍♀️",
            Code = "1f9db_200d_2640_fe0f",
            ShortName = "woman vampire",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏻‍♀️",
            Code = "1f9db_1f3fb_200d_2640_fe0f",
            ShortName = "woman vampire: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏼‍♀️",
            Code = "1f9db_1f3fc_200d_2640_fe0f",
            ShortName = "woman vampire: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏽‍♀️",
            Code = "1f9db_1f3fd_200d_2640_fe0f",
            ShortName = "woman vampire: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏾‍♀️",
            Code = "1f9db_1f3fe_200d_2640_fe0f",
            ShortName = "woman vampire: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏿‍♀️",
            Code = "1f9db_1f3ff_200d_2640_fe0f",
            ShortName = "woman vampire: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛‍♂️",
            Code = "1f9db_200d_2642_fe0f",
            ShortName = "man vampire",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏻‍♂️",
            Code = "1f9db_1f3fb_200d_2642_fe0f",
            ShortName = "man vampire: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏼‍♂️",
            Code = "1f9db_1f3fc_200d_2642_fe0f",
            ShortName = "man vampire: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏽‍♂️",
            Code = "1f9db_1f3fd_200d_2642_fe0f",
            ShortName = "man vampire: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏾‍♂️",
            Code = "1f9db_1f3fe_200d_2642_fe0f",
            ShortName = "man vampire: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧛🏿‍♂️",
            Code = "1f9db_1f3ff_200d_2642_fe0f",
            ShortName = "man vampire: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜",
            Code = "1f9dc",
            ShortName = "merperson",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏻",
            Code = "1f9dc_1f3fb",
            ShortName = "merperson: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏼",
            Code = "1f9dc_1f3fc",
            ShortName = "merperson: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏽",
            Code = "1f9dc_1f3fd",
            ShortName = "merperson: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏾",
            Code = "1f9dc_1f3fe",
            ShortName = "merperson: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏿",
            Code = "1f9dc_1f3ff",
            ShortName = "merperson: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜‍♀️",
            Code = "1f9dc_200d_2640_fe0f",
            ShortName = "mermaid",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏻‍♀️",
            Code = "1f9dc_1f3fb_200d_2640_fe0f",
            ShortName = "mermaid: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏼‍♀️",
            Code = "1f9dc_1f3fc_200d_2640_fe0f",
            ShortName = "mermaid: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏽‍♀️",
            Code = "1f9dc_1f3fd_200d_2640_fe0f",
            ShortName = "mermaid: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏾‍♀️",
            Code = "1f9dc_1f3fe_200d_2640_fe0f",
            ShortName = "mermaid: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏿‍♀️",
            Code = "1f9dc_1f3ff_200d_2640_fe0f",
            ShortName = "mermaid: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜‍♂️",
            Code = "1f9dc_200d_2642_fe0f",
            ShortName = "merman",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏻‍♂️",
            Code = "1f9dc_1f3fb_200d_2642_fe0f",
            ShortName = "merman: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏼‍♂️",
            Code = "1f9dc_1f3fc_200d_2642_fe0f",
            ShortName = "merman: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏽‍♂️",
            Code = "1f9dc_1f3fd_200d_2642_fe0f",
            ShortName = "merman: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏾‍♂️",
            Code = "1f9dc_1f3fe_200d_2642_fe0f",
            ShortName = "merman: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧜🏿‍♂️",
            Code = "1f9dc_1f3ff_200d_2642_fe0f",
            ShortName = "merman: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝",
            Code = "1f9dd",
            ShortName = "elf",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏻",
            Code = "1f9dd_1f3fb",
            ShortName = "elf: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏼",
            Code = "1f9dd_1f3fc",
            ShortName = "elf: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏽",
            Code = "1f9dd_1f3fd",
            ShortName = "elf: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏾",
            Code = "1f9dd_1f3fe",
            ShortName = "elf: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏿",
            Code = "1f9dd_1f3ff",
            ShortName = "elf: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝‍♀️",
            Code = "1f9dd_200d_2640_fe0f",
            ShortName = "woman elf",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏻‍♀️",
            Code = "1f9dd_1f3fb_200d_2640_fe0f",
            ShortName = "woman elf: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏼‍♀️",
            Code = "1f9dd_1f3fc_200d_2640_fe0f",
            ShortName = "woman elf: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏽‍♀️",
            Code = "1f9dd_1f3fd_200d_2640_fe0f",
            ShortName = "woman elf: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏾‍♀️",
            Code = "1f9dd_1f3fe_200d_2640_fe0f",
            ShortName = "woman elf: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏿‍♀️",
            Code = "1f9dd_1f3ff_200d_2640_fe0f",
            ShortName = "woman elf: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝‍♂️",
            Code = "1f9dd_200d_2642_fe0f",
            ShortName = "man elf",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏻‍♂️",
            Code = "1f9dd_1f3fb_200d_2642_fe0f",
            ShortName = "man elf: light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏼‍♂️",
            Code = "1f9dd_1f3fc_200d_2642_fe0f",
            ShortName = "man elf: medium-light skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏽‍♂️",
            Code = "1f9dd_1f3fd_200d_2642_fe0f",
            ShortName = "man elf: medium skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏾‍♂️",
            Code = "1f9dd_1f3fe_200d_2642_fe0f",
            ShortName = "man elf: medium-dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧝🏿‍♂️",
            Code = "1f9dd_1f3ff_200d_2642_fe0f",
            ShortName = "man elf: dark skin tone",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧞",
            Code = "1f9de",
            ShortName = "genie",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧞‍♀️",
            Code = "1f9de_200d_2640_fe0f",
            ShortName = "woman genie",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧞‍♂️",
            Code = "1f9de_200d_2642_fe0f",
            ShortName = "man genie",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧟",
            Code = "1f9df",
            ShortName = "zombie",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧟‍♀️",
            Code = "1f9df_200d_2640_fe0f",
            ShortName = "woman zombie",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧟‍♂️",
            Code = "1f9df_200d_2642_fe0f",
            ShortName = "man zombie",
            Category = "person-fantasy",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍",
            Code = "1f64d",
            ShortName = "person frowning",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏻",
            Code = "1f64d_1f3fb",
            ShortName = "person frowning: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏼",
            Code = "1f64d_1f3fc",
            ShortName = "person frowning: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏽",
            Code = "1f64d_1f3fd",
            ShortName = "person frowning: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏾",
            Code = "1f64d_1f3fe",
            ShortName = "person frowning: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏿",
            Code = "1f64d_1f3ff",
            ShortName = "person frowning: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍‍♂️",
            Code = "1f64d_200d_2642_fe0f",
            ShortName = "man frowning",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏻‍♂️",
            Code = "1f64d_1f3fb_200d_2642_fe0f",
            ShortName = "man frowning: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏼‍♂️",
            Code = "1f64d_1f3fc_200d_2642_fe0f",
            ShortName = "man frowning: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏽‍♂️",
            Code = "1f64d_1f3fd_200d_2642_fe0f",
            ShortName = "man frowning: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏾‍♂️",
            Code = "1f64d_1f3fe_200d_2642_fe0f",
            ShortName = "man frowning: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏿‍♂️",
            Code = "1f64d_1f3ff_200d_2642_fe0f",
            ShortName = "man frowning: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍‍♀️",
            Code = "1f64d_200d_2640_fe0f",
            ShortName = "woman frowning",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏻‍♀️",
            Code = "1f64d_1f3fb_200d_2640_fe0f",
            ShortName = "woman frowning: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏼‍♀️",
            Code = "1f64d_1f3fc_200d_2640_fe0f",
            ShortName = "woman frowning: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏽‍♀️",
            Code = "1f64d_1f3fd_200d_2640_fe0f",
            ShortName = "woman frowning: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏾‍♀️",
            Code = "1f64d_1f3fe_200d_2640_fe0f",
            ShortName = "woman frowning: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙍🏿‍♀️",
            Code = "1f64d_1f3ff_200d_2640_fe0f",
            ShortName = "woman frowning: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎",
            Code = "1f64e",
            ShortName = "person pouting",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏻",
            Code = "1f64e_1f3fb",
            ShortName = "person pouting: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏼",
            Code = "1f64e_1f3fc",
            ShortName = "person pouting: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏽",
            Code = "1f64e_1f3fd",
            ShortName = "person pouting: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏾",
            Code = "1f64e_1f3fe",
            ShortName = "person pouting: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏿",
            Code = "1f64e_1f3ff",
            ShortName = "person pouting: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎‍♂️",
            Code = "1f64e_200d_2642_fe0f",
            ShortName = "man pouting",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏻‍♂️",
            Code = "1f64e_1f3fb_200d_2642_fe0f",
            ShortName = "man pouting: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏼‍♂️",
            Code = "1f64e_1f3fc_200d_2642_fe0f",
            ShortName = "man pouting: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏽‍♂️",
            Code = "1f64e_1f3fd_200d_2642_fe0f",
            ShortName = "man pouting: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏾‍♂️",
            Code = "1f64e_1f3fe_200d_2642_fe0f",
            ShortName = "man pouting: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏿‍♂️",
            Code = "1f64e_1f3ff_200d_2642_fe0f",
            ShortName = "man pouting: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎‍♀️",
            Code = "1f64e_200d_2640_fe0f",
            ShortName = "woman pouting",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏻‍♀️",
            Code = "1f64e_1f3fb_200d_2640_fe0f",
            ShortName = "woman pouting: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏼‍♀️",
            Code = "1f64e_1f3fc_200d_2640_fe0f",
            ShortName = "woman pouting: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏽‍♀️",
            Code = "1f64e_1f3fd_200d_2640_fe0f",
            ShortName = "woman pouting: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏾‍♀️",
            Code = "1f64e_1f3fe_200d_2640_fe0f",
            ShortName = "woman pouting: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙎🏿‍♀️",
            Code = "1f64e_1f3ff_200d_2640_fe0f",
            ShortName = "woman pouting: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅",
            Code = "1f645",
            ShortName = "person gesturing NO",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏻",
            Code = "1f645_1f3fb",
            ShortName = "person gesturing NO: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏼",
            Code = "1f645_1f3fc",
            ShortName = "person gesturing NO: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏽",
            Code = "1f645_1f3fd",
            ShortName = "person gesturing NO: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏾",
            Code = "1f645_1f3fe",
            ShortName = "person gesturing NO: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏿",
            Code = "1f645_1f3ff",
            ShortName = "person gesturing NO: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅‍♂️",
            Code = "1f645_200d_2642_fe0f",
            ShortName = "man gesturing NO",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏻‍♂️",
            Code = "1f645_1f3fb_200d_2642_fe0f",
            ShortName = "man gesturing NO: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏼‍♂️",
            Code = "1f645_1f3fc_200d_2642_fe0f",
            ShortName = "man gesturing NO: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏽‍♂️",
            Code = "1f645_1f3fd_200d_2642_fe0f",
            ShortName = "man gesturing NO: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏾‍♂️",
            Code = "1f645_1f3fe_200d_2642_fe0f",
            ShortName = "man gesturing NO: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏿‍♂️",
            Code = "1f645_1f3ff_200d_2642_fe0f",
            ShortName = "man gesturing NO: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅‍♀️",
            Code = "1f645_200d_2640_fe0f",
            ShortName = "woman gesturing NO",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏻‍♀️",
            Code = "1f645_1f3fb_200d_2640_fe0f",
            ShortName = "woman gesturing NO: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏼‍♀️",
            Code = "1f645_1f3fc_200d_2640_fe0f",
            ShortName = "woman gesturing NO: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏽‍♀️",
            Code = "1f645_1f3fd_200d_2640_fe0f",
            ShortName = "woman gesturing NO: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏾‍♀️",
            Code = "1f645_1f3fe_200d_2640_fe0f",
            ShortName = "woman gesturing NO: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙅🏿‍♀️",
            Code = "1f645_1f3ff_200d_2640_fe0f",
            ShortName = "woman gesturing NO: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆",
            Code = "1f646",
            ShortName = "person gesturing OK",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏻",
            Code = "1f646_1f3fb",
            ShortName = "person gesturing OK: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏼",
            Code = "1f646_1f3fc",
            ShortName = "person gesturing OK: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏽",
            Code = "1f646_1f3fd",
            ShortName = "person gesturing OK: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏾",
            Code = "1f646_1f3fe",
            ShortName = "person gesturing OK: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏿",
            Code = "1f646_1f3ff",
            ShortName = "person gesturing OK: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆‍♂️",
            Code = "1f646_200d_2642_fe0f",
            ShortName = "man gesturing OK",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏻‍♂️",
            Code = "1f646_1f3fb_200d_2642_fe0f",
            ShortName = "man gesturing OK: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏼‍♂️",
            Code = "1f646_1f3fc_200d_2642_fe0f",
            ShortName = "man gesturing OK: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏽‍♂️",
            Code = "1f646_1f3fd_200d_2642_fe0f",
            ShortName = "man gesturing OK: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏾‍♂️",
            Code = "1f646_1f3fe_200d_2642_fe0f",
            ShortName = "man gesturing OK: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏿‍♂️",
            Code = "1f646_1f3ff_200d_2642_fe0f",
            ShortName = "man gesturing OK: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆‍♀️",
            Code = "1f646_200d_2640_fe0f",
            ShortName = "woman gesturing OK",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏻‍♀️",
            Code = "1f646_1f3fb_200d_2640_fe0f",
            ShortName = "woman gesturing OK: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏼‍♀️",
            Code = "1f646_1f3fc_200d_2640_fe0f",
            ShortName = "woman gesturing OK: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏽‍♀️",
            Code = "1f646_1f3fd_200d_2640_fe0f",
            ShortName = "woman gesturing OK: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏾‍♀️",
            Code = "1f646_1f3fe_200d_2640_fe0f",
            ShortName = "woman gesturing OK: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙆🏿‍♀️",
            Code = "1f646_1f3ff_200d_2640_fe0f",
            ShortName = "woman gesturing OK: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁",
            Code = "1f481",
            ShortName = "person tipping hand",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏻",
            Code = "1f481_1f3fb",
            ShortName = "person tipping hand: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏼",
            Code = "1f481_1f3fc",
            ShortName = "person tipping hand: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏽",
            Code = "1f481_1f3fd",
            ShortName = "person tipping hand: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏾",
            Code = "1f481_1f3fe",
            ShortName = "person tipping hand: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏿",
            Code = "1f481_1f3ff",
            ShortName = "person tipping hand: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁‍♂️",
            Code = "1f481_200d_2642_fe0f",
            ShortName = "man tipping hand",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏻‍♂️",
            Code = "1f481_1f3fb_200d_2642_fe0f",
            ShortName = "man tipping hand: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏼‍♂️",
            Code = "1f481_1f3fc_200d_2642_fe0f",
            ShortName = "man tipping hand: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏽‍♂️",
            Code = "1f481_1f3fd_200d_2642_fe0f",
            ShortName = "man tipping hand: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏾‍♂️",
            Code = "1f481_1f3fe_200d_2642_fe0f",
            ShortName = "man tipping hand: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏿‍♂️",
            Code = "1f481_1f3ff_200d_2642_fe0f",
            ShortName = "man tipping hand: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁‍♀️",
            Code = "1f481_200d_2640_fe0f",
            ShortName = "woman tipping hand",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏻‍♀️",
            Code = "1f481_1f3fb_200d_2640_fe0f",
            ShortName = "woman tipping hand: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏼‍♀️",
            Code = "1f481_1f3fc_200d_2640_fe0f",
            ShortName = "woman tipping hand: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏽‍♀️",
            Code = "1f481_1f3fd_200d_2640_fe0f",
            ShortName = "woman tipping hand: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏾‍♀️",
            Code = "1f481_1f3fe_200d_2640_fe0f",
            ShortName = "woman tipping hand: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💁🏿‍♀️",
            Code = "1f481_1f3ff_200d_2640_fe0f",
            ShortName = "woman tipping hand: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋",
            Code = "1f64b",
            ShortName = "person raising hand",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏻",
            Code = "1f64b_1f3fb",
            ShortName = "person raising hand: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏼",
            Code = "1f64b_1f3fc",
            ShortName = "person raising hand: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏽",
            Code = "1f64b_1f3fd",
            ShortName = "person raising hand: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏾",
            Code = "1f64b_1f3fe",
            ShortName = "person raising hand: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏿",
            Code = "1f64b_1f3ff",
            ShortName = "person raising hand: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋‍♂️",
            Code = "1f64b_200d_2642_fe0f",
            ShortName = "man raising hand",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏻‍♂️",
            Code = "1f64b_1f3fb_200d_2642_fe0f",
            ShortName = "man raising hand: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏼‍♂️",
            Code = "1f64b_1f3fc_200d_2642_fe0f",
            ShortName = "man raising hand: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏽‍♂️",
            Code = "1f64b_1f3fd_200d_2642_fe0f",
            ShortName = "man raising hand: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏾‍♂️",
            Code = "1f64b_1f3fe_200d_2642_fe0f",
            ShortName = "man raising hand: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏿‍♂️",
            Code = "1f64b_1f3ff_200d_2642_fe0f",
            ShortName = "man raising hand: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋‍♀️",
            Code = "1f64b_200d_2640_fe0f",
            ShortName = "woman raising hand",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏻‍♀️",
            Code = "1f64b_1f3fb_200d_2640_fe0f",
            ShortName = "woman raising hand: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏼‍♀️",
            Code = "1f64b_1f3fc_200d_2640_fe0f",
            ShortName = "woman raising hand: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏽‍♀️",
            Code = "1f64b_1f3fd_200d_2640_fe0f",
            ShortName = "woman raising hand: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏾‍♀️",
            Code = "1f64b_1f3fe_200d_2640_fe0f",
            ShortName = "woman raising hand: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙋🏿‍♀️",
            Code = "1f64b_1f3ff_200d_2640_fe0f",
            ShortName = "woman raising hand: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇",
            Code = "1f647",
            ShortName = "person bowing",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏻",
            Code = "1f647_1f3fb",
            ShortName = "person bowing: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏼",
            Code = "1f647_1f3fc",
            ShortName = "person bowing: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏽",
            Code = "1f647_1f3fd",
            ShortName = "person bowing: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏾",
            Code = "1f647_1f3fe",
            ShortName = "person bowing: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏿",
            Code = "1f647_1f3ff",
            ShortName = "person bowing: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇‍♂️",
            Code = "1f647_200d_2642_fe0f",
            ShortName = "man bowing",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏻‍♂️",
            Code = "1f647_1f3fb_200d_2642_fe0f",
            ShortName = "man bowing: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏼‍♂️",
            Code = "1f647_1f3fc_200d_2642_fe0f",
            ShortName = "man bowing: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏽‍♂️",
            Code = "1f647_1f3fd_200d_2642_fe0f",
            ShortName = "man bowing: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏾‍♂️",
            Code = "1f647_1f3fe_200d_2642_fe0f",
            ShortName = "man bowing: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏿‍♂️",
            Code = "1f647_1f3ff_200d_2642_fe0f",
            ShortName = "man bowing: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇‍♀️",
            Code = "1f647_200d_2640_fe0f",
            ShortName = "woman bowing",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏻‍♀️",
            Code = "1f647_1f3fb_200d_2640_fe0f",
            ShortName = "woman bowing: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏼‍♀️",
            Code = "1f647_1f3fc_200d_2640_fe0f",
            ShortName = "woman bowing: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏽‍♀️",
            Code = "1f647_1f3fd_200d_2640_fe0f",
            ShortName = "woman bowing: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏾‍♀️",
            Code = "1f647_1f3fe_200d_2640_fe0f",
            ShortName = "woman bowing: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙇🏿‍♀️",
            Code = "1f647_1f3ff_200d_2640_fe0f",
            ShortName = "woman bowing: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦",
            Code = "1f926",
            ShortName = "person facepalming",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏻",
            Code = "1f926_1f3fb",
            ShortName = "person facepalming: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏼",
            Code = "1f926_1f3fc",
            ShortName = "person facepalming: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏽",
            Code = "1f926_1f3fd",
            ShortName = "person facepalming: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏾",
            Code = "1f926_1f3fe",
            ShortName = "person facepalming: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏿",
            Code = "1f926_1f3ff",
            ShortName = "person facepalming: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦‍♂️",
            Code = "1f926_200d_2642_fe0f",
            ShortName = "man facepalming",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏻‍♂️",
            Code = "1f926_1f3fb_200d_2642_fe0f",
            ShortName = "man facepalming: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏼‍♂️",
            Code = "1f926_1f3fc_200d_2642_fe0f",
            ShortName = "man facepalming: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏽‍♂️",
            Code = "1f926_1f3fd_200d_2642_fe0f",
            ShortName = "man facepalming: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏾‍♂️",
            Code = "1f926_1f3fe_200d_2642_fe0f",
            ShortName = "man facepalming: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏿‍♂️",
            Code = "1f926_1f3ff_200d_2642_fe0f",
            ShortName = "man facepalming: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦‍♀️",
            Code = "1f926_200d_2640_fe0f",
            ShortName = "woman facepalming",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏻‍♀️",
            Code = "1f926_1f3fb_200d_2640_fe0f",
            ShortName = "woman facepalming: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏼‍♀️",
            Code = "1f926_1f3fc_200d_2640_fe0f",
            ShortName = "woman facepalming: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏽‍♀️",
            Code = "1f926_1f3fd_200d_2640_fe0f",
            ShortName = "woman facepalming: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏾‍♀️",
            Code = "1f926_1f3fe_200d_2640_fe0f",
            ShortName = "woman facepalming: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤦🏿‍♀️",
            Code = "1f926_1f3ff_200d_2640_fe0f",
            ShortName = "woman facepalming: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷",
            Code = "1f937",
            ShortName = "person shrugging",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏻",
            Code = "1f937_1f3fb",
            ShortName = "person shrugging: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏼",
            Code = "1f937_1f3fc",
            ShortName = "person shrugging: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏽",
            Code = "1f937_1f3fd",
            ShortName = "person shrugging: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏾",
            Code = "1f937_1f3fe",
            ShortName = "person shrugging: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏿",
            Code = "1f937_1f3ff",
            ShortName = "person shrugging: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷‍♂️",
            Code = "1f937_200d_2642_fe0f",
            ShortName = "man shrugging",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏻‍♂️",
            Code = "1f937_1f3fb_200d_2642_fe0f",
            ShortName = "man shrugging: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏼‍♂️",
            Code = "1f937_1f3fc_200d_2642_fe0f",
            ShortName = "man shrugging: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏽‍♂️",
            Code = "1f937_1f3fd_200d_2642_fe0f",
            ShortName = "man shrugging: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏾‍♂️",
            Code = "1f937_1f3fe_200d_2642_fe0f",
            ShortName = "man shrugging: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏿‍♂️",
            Code = "1f937_1f3ff_200d_2642_fe0f",
            ShortName = "man shrugging: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷‍♀️",
            Code = "1f937_200d_2640_fe0f",
            ShortName = "woman shrugging",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏻‍♀️",
            Code = "1f937_1f3fb_200d_2640_fe0f",
            ShortName = "woman shrugging: light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏼‍♀️",
            Code = "1f937_1f3fc_200d_2640_fe0f",
            ShortName = "woman shrugging: medium-light skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏽‍♀️",
            Code = "1f937_1f3fd_200d_2640_fe0f",
            ShortName = "woman shrugging: medium skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏾‍♀️",
            Code = "1f937_1f3fe_200d_2640_fe0f",
            ShortName = "woman shrugging: medium-dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤷🏿‍♀️",
            Code = "1f937_1f3ff_200d_2640_fe0f",
            ShortName = "woman shrugging: dark skin tone",
            Category = "person-gesture",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆",
            Code = "1f486",
            ShortName = "person getting massage",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏻",
            Code = "1f486_1f3fb",
            ShortName = "person getting massage: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏼",
            Code = "1f486_1f3fc",
            ShortName = "person getting massage: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏽",
            Code = "1f486_1f3fd",
            ShortName = "person getting massage: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏾",
            Code = "1f486_1f3fe",
            ShortName = "person getting massage: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏿",
            Code = "1f486_1f3ff",
            ShortName = "person getting massage: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆‍♂️",
            Code = "1f486_200d_2642_fe0f",
            ShortName = "man getting massage",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏻‍♂️",
            Code = "1f486_1f3fb_200d_2642_fe0f",
            ShortName = "man getting massage: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏼‍♂️",
            Code = "1f486_1f3fc_200d_2642_fe0f",
            ShortName = "man getting massage: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏽‍♂️",
            Code = "1f486_1f3fd_200d_2642_fe0f",
            ShortName = "man getting massage: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏾‍♂️",
            Code = "1f486_1f3fe_200d_2642_fe0f",
            ShortName = "man getting massage: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏿‍♂️",
            Code = "1f486_1f3ff_200d_2642_fe0f",
            ShortName = "man getting massage: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆‍♀️",
            Code = "1f486_200d_2640_fe0f",
            ShortName = "woman getting massage",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏻‍♀️",
            Code = "1f486_1f3fb_200d_2640_fe0f",
            ShortName = "woman getting massage: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏼‍♀️",
            Code = "1f486_1f3fc_200d_2640_fe0f",
            ShortName = "woman getting massage: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏽‍♀️",
            Code = "1f486_1f3fd_200d_2640_fe0f",
            ShortName = "woman getting massage: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏾‍♀️",
            Code = "1f486_1f3fe_200d_2640_fe0f",
            ShortName = "woman getting massage: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💆🏿‍♀️",
            Code = "1f486_1f3ff_200d_2640_fe0f",
            ShortName = "woman getting massage: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇",
            Code = "1f487",
            ShortName = "person getting haircut",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏻",
            Code = "1f487_1f3fb",
            ShortName = "person getting haircut: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏼",
            Code = "1f487_1f3fc",
            ShortName = "person getting haircut: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏽",
            Code = "1f487_1f3fd",
            ShortName = "person getting haircut: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏾",
            Code = "1f487_1f3fe",
            ShortName = "person getting haircut: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏿",
            Code = "1f487_1f3ff",
            ShortName = "person getting haircut: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇‍♂️",
            Code = "1f487_200d_2642_fe0f",
            ShortName = "man getting haircut",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏻‍♂️",
            Code = "1f487_1f3fb_200d_2642_fe0f",
            ShortName = "man getting haircut: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏼‍♂️",
            Code = "1f487_1f3fc_200d_2642_fe0f",
            ShortName = "man getting haircut: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏽‍♂️",
            Code = "1f487_1f3fd_200d_2642_fe0f",
            ShortName = "man getting haircut: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏾‍♂️",
            Code = "1f487_1f3fe_200d_2642_fe0f",
            ShortName = "man getting haircut: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏿‍♂️",
            Code = "1f487_1f3ff_200d_2642_fe0f",
            ShortName = "man getting haircut: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇‍♀️",
            Code = "1f487_200d_2640_fe0f",
            ShortName = "woman getting haircut",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏻‍♀️",
            Code = "1f487_1f3fb_200d_2640_fe0f",
            ShortName = "woman getting haircut: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏼‍♀️",
            Code = "1f487_1f3fc_200d_2640_fe0f",
            ShortName = "woman getting haircut: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏽‍♀️",
            Code = "1f487_1f3fd_200d_2640_fe0f",
            ShortName = "woman getting haircut: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏾‍♀️",
            Code = "1f487_1f3fe_200d_2640_fe0f",
            ShortName = "woman getting haircut: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💇🏿‍♀️",
            Code = "1f487_1f3ff_200d_2640_fe0f",
            ShortName = "woman getting haircut: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶",
            Code = "1f6b6",
            ShortName = "person walking",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏻",
            Code = "1f6b6_1f3fb",
            ShortName = "person walking: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏼",
            Code = "1f6b6_1f3fc",
            ShortName = "person walking: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏽",
            Code = "1f6b6_1f3fd",
            ShortName = "person walking: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏾",
            Code = "1f6b6_1f3fe",
            ShortName = "person walking: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏿",
            Code = "1f6b6_1f3ff",
            ShortName = "person walking: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶‍♂️",
            Code = "1f6b6_200d_2642_fe0f",
            ShortName = "man walking",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏻‍♂️",
            Code = "1f6b6_1f3fb_200d_2642_fe0f",
            ShortName = "man walking: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏼‍♂️",
            Code = "1f6b6_1f3fc_200d_2642_fe0f",
            ShortName = "man walking: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏽‍♂️",
            Code = "1f6b6_1f3fd_200d_2642_fe0f",
            ShortName = "man walking: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏾‍♂️",
            Code = "1f6b6_1f3fe_200d_2642_fe0f",
            ShortName = "man walking: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏿‍♂️",
            Code = "1f6b6_1f3ff_200d_2642_fe0f",
            ShortName = "man walking: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶‍♀️",
            Code = "1f6b6_200d_2640_fe0f",
            ShortName = "woman walking",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏻‍♀️",
            Code = "1f6b6_1f3fb_200d_2640_fe0f",
            ShortName = "woman walking: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏼‍♀️",
            Code = "1f6b6_1f3fc_200d_2640_fe0f",
            ShortName = "woman walking: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏽‍♀️",
            Code = "1f6b6_1f3fd_200d_2640_fe0f",
            ShortName = "woman walking: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏾‍♀️",
            Code = "1f6b6_1f3fe_200d_2640_fe0f",
            ShortName = "woman walking: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚶🏿‍♀️",
            Code = "1f6b6_1f3ff_200d_2640_fe0f",
            ShortName = "woman walking: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃",
            Code = "1f3c3",
            ShortName = "person running",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏻",
            Code = "1f3c3_1f3fb",
            ShortName = "person running: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏼",
            Code = "1f3c3_1f3fc",
            ShortName = "person running: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏽",
            Code = "1f3c3_1f3fd",
            ShortName = "person running: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏾",
            Code = "1f3c3_1f3fe",
            ShortName = "person running: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏿",
            Code = "1f3c3_1f3ff",
            ShortName = "person running: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃‍♂️",
            Code = "1f3c3_200d_2642_fe0f",
            ShortName = "man running",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏻‍♂️",
            Code = "1f3c3_1f3fb_200d_2642_fe0f",
            ShortName = "man running: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏼‍♂️",
            Code = "1f3c3_1f3fc_200d_2642_fe0f",
            ShortName = "man running: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏽‍♂️",
            Code = "1f3c3_1f3fd_200d_2642_fe0f",
            ShortName = "man running: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏾‍♂️",
            Code = "1f3c3_1f3fe_200d_2642_fe0f",
            ShortName = "man running: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏿‍♂️",
            Code = "1f3c3_1f3ff_200d_2642_fe0f",
            ShortName = "man running: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃‍♀️",
            Code = "1f3c3_200d_2640_fe0f",
            ShortName = "woman running",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏻‍♀️",
            Code = "1f3c3_1f3fb_200d_2640_fe0f",
            ShortName = "woman running: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏼‍♀️",
            Code = "1f3c3_1f3fc_200d_2640_fe0f",
            ShortName = "woman running: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏽‍♀️",
            Code = "1f3c3_1f3fd_200d_2640_fe0f",
            ShortName = "woman running: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏾‍♀️",
            Code = "1f3c3_1f3fe_200d_2640_fe0f",
            ShortName = "woman running: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏃🏿‍♀️",
            Code = "1f3c3_1f3ff_200d_2640_fe0f",
            ShortName = "woman running: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💃",
            Code = "1f483",
            ShortName = "woman dancing",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💃🏻",
            Code = "1f483_1f3fb",
            ShortName = "woman dancing: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💃🏼",
            Code = "1f483_1f3fc",
            ShortName = "woman dancing: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💃🏽",
            Code = "1f483_1f3fd",
            ShortName = "woman dancing: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💃🏾",
            Code = "1f483_1f3fe",
            ShortName = "woman dancing: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💃🏿",
            Code = "1f483_1f3ff",
            ShortName = "woman dancing: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕺",
            Code = "1f57a",
            ShortName = "man dancing",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕺🏻",
            Code = "1f57a_1f3fb",
            ShortName = "man dancing: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕺🏼",
            Code = "1f57a_1f3fc",
            ShortName = "man dancing: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕺🏽",
            Code = "1f57a_1f3fd",
            ShortName = "man dancing: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕺🏾",
            Code = "1f57a_1f3fe",
            ShortName = "man dancing: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕺🏿",
            Code = "1f57a_1f3ff",
            ShortName = "man dancing: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👯",
            Code = "1f46f",
            ShortName = "people with bunny ears partying",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👯‍♂️",
            Code = "1f46f_200d_2642_fe0f",
            ShortName = "men with bunny ears partying",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👯‍♀️",
            Code = "1f46f_200d_2640_fe0f",
            ShortName = "women with bunny ears partying",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖",
            Code = "1f9d6",
            ShortName = "person in steamy room",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏻",
            Code = "1f9d6_1f3fb",
            ShortName = "person in steamy room: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏼",
            Code = "1f9d6_1f3fc",
            ShortName = "person in steamy room: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏽",
            Code = "1f9d6_1f3fd",
            ShortName = "person in steamy room: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏾",
            Code = "1f9d6_1f3fe",
            ShortName = "person in steamy room: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏿",
            Code = "1f9d6_1f3ff",
            ShortName = "person in steamy room: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖‍♀️",
            Code = "1f9d6_200d_2640_fe0f",
            ShortName = "woman in steamy room",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏻‍♀️",
            Code = "1f9d6_1f3fb_200d_2640_fe0f",
            ShortName = "woman in steamy room: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏼‍♀️",
            Code = "1f9d6_1f3fc_200d_2640_fe0f",
            ShortName = "woman in steamy room: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏽‍♀️",
            Code = "1f9d6_1f3fd_200d_2640_fe0f",
            ShortName = "woman in steamy room: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏾‍♀️",
            Code = "1f9d6_1f3fe_200d_2640_fe0f",
            ShortName = "woman in steamy room: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏿‍♀️",
            Code = "1f9d6_1f3ff_200d_2640_fe0f",
            ShortName = "woman in steamy room: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖‍♂️",
            Code = "1f9d6_200d_2642_fe0f",
            ShortName = "man in steamy room",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏻‍♂️",
            Code = "1f9d6_1f3fb_200d_2642_fe0f",
            ShortName = "man in steamy room: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏼‍♂️",
            Code = "1f9d6_1f3fc_200d_2642_fe0f",
            ShortName = "man in steamy room: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏽‍♂️",
            Code = "1f9d6_1f3fd_200d_2642_fe0f",
            ShortName = "man in steamy room: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏾‍♂️",
            Code = "1f9d6_1f3fe_200d_2642_fe0f",
            ShortName = "man in steamy room: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧖🏿‍♂️",
            Code = "1f9d6_1f3ff_200d_2642_fe0f",
            ShortName = "man in steamy room: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗",
            Code = "1f9d7",
            ShortName = "person climbing",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏻",
            Code = "1f9d7_1f3fb",
            ShortName = "person climbing: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏼",
            Code = "1f9d7_1f3fc",
            ShortName = "person climbing: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏽",
            Code = "1f9d7_1f3fd",
            ShortName = "person climbing: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏾",
            Code = "1f9d7_1f3fe",
            ShortName = "person climbing: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏿",
            Code = "1f9d7_1f3ff",
            ShortName = "person climbing: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗‍♀️",
            Code = "1f9d7_200d_2640_fe0f",
            ShortName = "woman climbing",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏻‍♀️",
            Code = "1f9d7_1f3fb_200d_2640_fe0f",
            ShortName = "woman climbing: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏼‍♀️",
            Code = "1f9d7_1f3fc_200d_2640_fe0f",
            ShortName = "woman climbing: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏽‍♀️",
            Code = "1f9d7_1f3fd_200d_2640_fe0f",
            ShortName = "woman climbing: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏾‍♀️",
            Code = "1f9d7_1f3fe_200d_2640_fe0f",
            ShortName = "woman climbing: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏿‍♀️",
            Code = "1f9d7_1f3ff_200d_2640_fe0f",
            ShortName = "woman climbing: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗‍♂️",
            Code = "1f9d7_200d_2642_fe0f",
            ShortName = "man climbing",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏻‍♂️",
            Code = "1f9d7_1f3fb_200d_2642_fe0f",
            ShortName = "man climbing: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏼‍♂️",
            Code = "1f9d7_1f3fc_200d_2642_fe0f",
            ShortName = "man climbing: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏽‍♂️",
            Code = "1f9d7_1f3fd_200d_2642_fe0f",
            ShortName = "man climbing: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏾‍♂️",
            Code = "1f9d7_1f3fe_200d_2642_fe0f",
            ShortName = "man climbing: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧗🏿‍♂️",
            Code = "1f9d7_1f3ff_200d_2642_fe0f",
            ShortName = "man climbing: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘",
            Code = "1f9d8",
            ShortName = "person in lotus position",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏻",
            Code = "1f9d8_1f3fb",
            ShortName = "person in lotus position: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏼",
            Code = "1f9d8_1f3fc",
            ShortName = "person in lotus position: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏽",
            Code = "1f9d8_1f3fd",
            ShortName = "person in lotus position: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏾",
            Code = "1f9d8_1f3fe",
            ShortName = "person in lotus position: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏿",
            Code = "1f9d8_1f3ff",
            ShortName = "person in lotus position: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘‍♀️",
            Code = "1f9d8_200d_2640_fe0f",
            ShortName = "woman in lotus position",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏻‍♀️",
            Code = "1f9d8_1f3fb_200d_2640_fe0f",
            ShortName = "woman in lotus position: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏼‍♀️",
            Code = "1f9d8_1f3fc_200d_2640_fe0f",
            ShortName = "woman in lotus position: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏽‍♀️",
            Code = "1f9d8_1f3fd_200d_2640_fe0f",
            ShortName = "woman in lotus position: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏾‍♀️",
            Code = "1f9d8_1f3fe_200d_2640_fe0f",
            ShortName = "woman in lotus position: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏿‍♀️",
            Code = "1f9d8_1f3ff_200d_2640_fe0f",
            ShortName = "woman in lotus position: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘‍♂️",
            Code = "1f9d8_200d_2642_fe0f",
            ShortName = "man in lotus position",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏻‍♂️",
            Code = "1f9d8_1f3fb_200d_2642_fe0f",
            ShortName = "man in lotus position: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏼‍♂️",
            Code = "1f9d8_1f3fc_200d_2642_fe0f",
            ShortName = "man in lotus position: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏽‍♂️",
            Code = "1f9d8_1f3fd_200d_2642_fe0f",
            ShortName = "man in lotus position: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏾‍♂️",
            Code = "1f9d8_1f3fe_200d_2642_fe0f",
            ShortName = "man in lotus position: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧘🏿‍♂️",
            Code = "1f9d8_1f3ff_200d_2642_fe0f",
            ShortName = "man in lotus position: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛀",
            Code = "1f6c0",
            ShortName = "person taking bath",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛀🏻",
            Code = "1f6c0_1f3fb",
            ShortName = "person taking bath: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛀🏼",
            Code = "1f6c0_1f3fc",
            ShortName = "person taking bath: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛀🏽",
            Code = "1f6c0_1f3fd",
            ShortName = "person taking bath: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛀🏾",
            Code = "1f6c0_1f3fe",
            ShortName = "person taking bath: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛀🏿",
            Code = "1f6c0_1f3ff",
            ShortName = "person taking bath: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛌",
            Code = "1f6cc",
            ShortName = "person in bed",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛌🏻",
            Code = "1f6cc_1f3fb",
            ShortName = "person in bed: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛌🏼",
            Code = "1f6cc_1f3fc",
            ShortName = "person in bed: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛌🏽",
            Code = "1f6cc_1f3fd",
            ShortName = "person in bed: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛌🏾",
            Code = "1f6cc_1f3fe",
            ShortName = "person in bed: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛌🏿",
            Code = "1f6cc_1f3ff",
            ShortName = "person in bed: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕴",
            Code = "1f574",
            ShortName = "man in business suit levitating",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕴🏻",
            Code = "1f574_1f3fb",
            ShortName = "man in business suit levitating: light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕴🏼",
            Code = "1f574_1f3fc",
            ShortName = "man in business suit levitating: medium-light skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕴🏽",
            Code = "1f574_1f3fd",
            ShortName = "man in business suit levitating: medium skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕴🏾",
            Code = "1f574_1f3fe",
            ShortName = "man in business suit levitating: medium-dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕴🏿",
            Code = "1f574_1f3ff",
            ShortName = "man in business suit levitating: dark skin tone",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗣",
            Code = "1f5e3",
            ShortName = "speaking head",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👤",
            Code = "1f464",
            ShortName = "bust in silhouette",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👥",
            Code = "1f465",
            ShortName = "busts in silhouette",
            Category = "person-activity",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤺",
            Code = "1f93a",
            ShortName = "person fencing",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏇",
            Code = "1f3c7",
            ShortName = "horse racing",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏇🏻",
            Code = "1f3c7_1f3fb",
            ShortName = "horse racing: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏇🏼",
            Code = "1f3c7_1f3fc",
            ShortName = "horse racing: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏇🏽",
            Code = "1f3c7_1f3fd",
            ShortName = "horse racing: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏇🏾",
            Code = "1f3c7_1f3fe",
            ShortName = "horse racing: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏇🏿",
            Code = "1f3c7_1f3ff",
            ShortName = "horse racing: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛷",
            Code = "26f7",
            ShortName = "skier",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏂",
            Code = "1f3c2",
            ShortName = "snowboarder",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏂🏻",
            Code = "1f3c2_1f3fb",
            ShortName = "snowboarder: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏂🏼",
            Code = "1f3c2_1f3fc",
            ShortName = "snowboarder: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏂🏽",
            Code = "1f3c2_1f3fd",
            ShortName = "snowboarder: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏂🏾",
            Code = "1f3c2_1f3fe",
            ShortName = "snowboarder: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏂🏿",
            Code = "1f3c2_1f3ff",
            ShortName = "snowboarder: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌",
            Code = "1f3cc",
            ShortName = "person golfing",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏻",
            Code = "1f3cc_1f3fb",
            ShortName = "person golfing: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏼",
            Code = "1f3cc_1f3fc",
            ShortName = "person golfing: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏽",
            Code = "1f3cc_1f3fd",
            ShortName = "person golfing: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏾",
            Code = "1f3cc_1f3fe",
            ShortName = "person golfing: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏿",
            Code = "1f3cc_1f3ff",
            ShortName = "person golfing: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌️‍♂️",
            Code = "1f3cc_fe0f_200d_2642_fe0f",
            ShortName = "man golfing",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏻‍♂️",
            Code = "1f3cc_1f3fb_200d_2642_fe0f",
            ShortName = "man golfing: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏼‍♂️",
            Code = "1f3cc_1f3fc_200d_2642_fe0f",
            ShortName = "man golfing: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏽‍♂️",
            Code = "1f3cc_1f3fd_200d_2642_fe0f",
            ShortName = "man golfing: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏾‍♂️",
            Code = "1f3cc_1f3fe_200d_2642_fe0f",
            ShortName = "man golfing: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏿‍♂️",
            Code = "1f3cc_1f3ff_200d_2642_fe0f",
            ShortName = "man golfing: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌️‍♀️",
            Code = "1f3cc_fe0f_200d_2640_fe0f",
            ShortName = "woman golfing",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏻‍♀️",
            Code = "1f3cc_1f3fb_200d_2640_fe0f",
            ShortName = "woman golfing: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏼‍♀️",
            Code = "1f3cc_1f3fc_200d_2640_fe0f",
            ShortName = "woman golfing: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏽‍♀️",
            Code = "1f3cc_1f3fd_200d_2640_fe0f",
            ShortName = "woman golfing: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏾‍♀️",
            Code = "1f3cc_1f3fe_200d_2640_fe0f",
            ShortName = "woman golfing: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏌🏿‍♀️",
            Code = "1f3cc_1f3ff_200d_2640_fe0f",
            ShortName = "woman golfing: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄",
            Code = "1f3c4",
            ShortName = "person surfing",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏻",
            Code = "1f3c4_1f3fb",
            ShortName = "person surfing: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏼",
            Code = "1f3c4_1f3fc",
            ShortName = "person surfing: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏽",
            Code = "1f3c4_1f3fd",
            ShortName = "person surfing: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏾",
            Code = "1f3c4_1f3fe",
            ShortName = "person surfing: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏿",
            Code = "1f3c4_1f3ff",
            ShortName = "person surfing: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄‍♂️",
            Code = "1f3c4_200d_2642_fe0f",
            ShortName = "man surfing",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏻‍♂️",
            Code = "1f3c4_1f3fb_200d_2642_fe0f",
            ShortName = "man surfing: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏼‍♂️",
            Code = "1f3c4_1f3fc_200d_2642_fe0f",
            ShortName = "man surfing: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏽‍♂️",
            Code = "1f3c4_1f3fd_200d_2642_fe0f",
            ShortName = "man surfing: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏾‍♂️",
            Code = "1f3c4_1f3fe_200d_2642_fe0f",
            ShortName = "man surfing: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏿‍♂️",
            Code = "1f3c4_1f3ff_200d_2642_fe0f",
            ShortName = "man surfing: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄‍♀️",
            Code = "1f3c4_200d_2640_fe0f",
            ShortName = "woman surfing",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏻‍♀️",
            Code = "1f3c4_1f3fb_200d_2640_fe0f",
            ShortName = "woman surfing: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏼‍♀️",
            Code = "1f3c4_1f3fc_200d_2640_fe0f",
            ShortName = "woman surfing: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏽‍♀️",
            Code = "1f3c4_1f3fd_200d_2640_fe0f",
            ShortName = "woman surfing: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏾‍♀️",
            Code = "1f3c4_1f3fe_200d_2640_fe0f",
            ShortName = "woman surfing: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏄🏿‍♀️",
            Code = "1f3c4_1f3ff_200d_2640_fe0f",
            ShortName = "woman surfing: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣",
            Code = "1f6a3",
            ShortName = "person rowing boat",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏻",
            Code = "1f6a3_1f3fb",
            ShortName = "person rowing boat: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏼",
            Code = "1f6a3_1f3fc",
            ShortName = "person rowing boat: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏽",
            Code = "1f6a3_1f3fd",
            ShortName = "person rowing boat: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏾",
            Code = "1f6a3_1f3fe",
            ShortName = "person rowing boat: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏿",
            Code = "1f6a3_1f3ff",
            ShortName = "person rowing boat: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣‍♂️",
            Code = "1f6a3_200d_2642_fe0f",
            ShortName = "man rowing boat",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏻‍♂️",
            Code = "1f6a3_1f3fb_200d_2642_fe0f",
            ShortName = "man rowing boat: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏼‍♂️",
            Code = "1f6a3_1f3fc_200d_2642_fe0f",
            ShortName = "man rowing boat: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏽‍♂️",
            Code = "1f6a3_1f3fd_200d_2642_fe0f",
            ShortName = "man rowing boat: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏾‍♂️",
            Code = "1f6a3_1f3fe_200d_2642_fe0f",
            ShortName = "man rowing boat: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏿‍♂️",
            Code = "1f6a3_1f3ff_200d_2642_fe0f",
            ShortName = "man rowing boat: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣‍♀️",
            Code = "1f6a3_200d_2640_fe0f",
            ShortName = "woman rowing boat",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏻‍♀️",
            Code = "1f6a3_1f3fb_200d_2640_fe0f",
            ShortName = "woman rowing boat: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏼‍♀️",
            Code = "1f6a3_1f3fc_200d_2640_fe0f",
            ShortName = "woman rowing boat: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏽‍♀️",
            Code = "1f6a3_1f3fd_200d_2640_fe0f",
            ShortName = "woman rowing boat: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏾‍♀️",
            Code = "1f6a3_1f3fe_200d_2640_fe0f",
            ShortName = "woman rowing boat: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚣🏿‍♀️",
            Code = "1f6a3_1f3ff_200d_2640_fe0f",
            ShortName = "woman rowing boat: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊",
            Code = "1f3ca",
            ShortName = "person swimming",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏻",
            Code = "1f3ca_1f3fb",
            ShortName = "person swimming: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏼",
            Code = "1f3ca_1f3fc",
            ShortName = "person swimming: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏽",
            Code = "1f3ca_1f3fd",
            ShortName = "person swimming: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏾",
            Code = "1f3ca_1f3fe",
            ShortName = "person swimming: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏿",
            Code = "1f3ca_1f3ff",
            ShortName = "person swimming: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊‍♂️",
            Code = "1f3ca_200d_2642_fe0f",
            ShortName = "man swimming",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏻‍♂️",
            Code = "1f3ca_1f3fb_200d_2642_fe0f",
            ShortName = "man swimming: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏼‍♂️",
            Code = "1f3ca_1f3fc_200d_2642_fe0f",
            ShortName = "man swimming: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏽‍♂️",
            Code = "1f3ca_1f3fd_200d_2642_fe0f",
            ShortName = "man swimming: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏾‍♂️",
            Code = "1f3ca_1f3fe_200d_2642_fe0f",
            ShortName = "man swimming: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏿‍♂️",
            Code = "1f3ca_1f3ff_200d_2642_fe0f",
            ShortName = "man swimming: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊‍♀️",
            Code = "1f3ca_200d_2640_fe0f",
            ShortName = "woman swimming",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏻‍♀️",
            Code = "1f3ca_1f3fb_200d_2640_fe0f",
            ShortName = "woman swimming: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏼‍♀️",
            Code = "1f3ca_1f3fc_200d_2640_fe0f",
            ShortName = "woman swimming: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏽‍♀️",
            Code = "1f3ca_1f3fd_200d_2640_fe0f",
            ShortName = "woman swimming: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏾‍♀️",
            Code = "1f3ca_1f3fe_200d_2640_fe0f",
            ShortName = "woman swimming: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏊🏿‍♀️",
            Code = "1f3ca_1f3ff_200d_2640_fe0f",
            ShortName = "woman swimming: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹",
            Code = "26f9",
            ShortName = "person bouncing ball",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏻",
            Code = "26f9_1f3fb",
            ShortName = "person bouncing ball: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏼",
            Code = "26f9_1f3fc",
            ShortName = "person bouncing ball: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏽",
            Code = "26f9_1f3fd",
            ShortName = "person bouncing ball: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏾",
            Code = "26f9_1f3fe",
            ShortName = "person bouncing ball: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏿",
            Code = "26f9_1f3ff",
            ShortName = "person bouncing ball: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹️‍♂️",
            Code = "26f9_fe0f_200d_2642_fe0f",
            ShortName = "man bouncing ball",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏻‍♂️",
            Code = "26f9_1f3fb_200d_2642_fe0f",
            ShortName = "man bouncing ball: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏼‍♂️",
            Code = "26f9_1f3fc_200d_2642_fe0f",
            ShortName = "man bouncing ball: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏽‍♂️",
            Code = "26f9_1f3fd_200d_2642_fe0f",
            ShortName = "man bouncing ball: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏾‍♂️",
            Code = "26f9_1f3fe_200d_2642_fe0f",
            ShortName = "man bouncing ball: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏿‍♂️",
            Code = "26f9_1f3ff_200d_2642_fe0f",
            ShortName = "man bouncing ball: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹️‍♀️",
            Code = "26f9_fe0f_200d_2640_fe0f",
            ShortName = "woman bouncing ball",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏻‍♀️",
            Code = "26f9_1f3fb_200d_2640_fe0f",
            ShortName = "woman bouncing ball: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏼‍♀️",
            Code = "26f9_1f3fc_200d_2640_fe0f",
            ShortName = "woman bouncing ball: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏽‍♀️",
            Code = "26f9_1f3fd_200d_2640_fe0f",
            ShortName = "woman bouncing ball: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏾‍♀️",
            Code = "26f9_1f3fe_200d_2640_fe0f",
            ShortName = "woman bouncing ball: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛹🏿‍♀️",
            Code = "26f9_1f3ff_200d_2640_fe0f",
            ShortName = "woman bouncing ball: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋",
            Code = "1f3cb",
            ShortName = "person lifting weights",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏻",
            Code = "1f3cb_1f3fb",
            ShortName = "person lifting weights: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏼",
            Code = "1f3cb_1f3fc",
            ShortName = "person lifting weights: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏽",
            Code = "1f3cb_1f3fd",
            ShortName = "person lifting weights: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏾",
            Code = "1f3cb_1f3fe",
            ShortName = "person lifting weights: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏿",
            Code = "1f3cb_1f3ff",
            ShortName = "person lifting weights: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋️‍♂️",
            Code = "1f3cb_fe0f_200d_2642_fe0f",
            ShortName = "man lifting weights",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏻‍♂️",
            Code = "1f3cb_1f3fb_200d_2642_fe0f",
            ShortName = "man lifting weights: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏼‍♂️",
            Code = "1f3cb_1f3fc_200d_2642_fe0f",
            ShortName = "man lifting weights: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏽‍♂️",
            Code = "1f3cb_1f3fd_200d_2642_fe0f",
            ShortName = "man lifting weights: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏾‍♂️",
            Code = "1f3cb_1f3fe_200d_2642_fe0f",
            ShortName = "man lifting weights: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏿‍♂️",
            Code = "1f3cb_1f3ff_200d_2642_fe0f",
            ShortName = "man lifting weights: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋️‍♀️",
            Code = "1f3cb_fe0f_200d_2640_fe0f",
            ShortName = "woman lifting weights",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏻‍♀️",
            Code = "1f3cb_1f3fb_200d_2640_fe0f",
            ShortName = "woman lifting weights: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏼‍♀️",
            Code = "1f3cb_1f3fc_200d_2640_fe0f",
            ShortName = "woman lifting weights: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏽‍♀️",
            Code = "1f3cb_1f3fd_200d_2640_fe0f",
            ShortName = "woman lifting weights: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏾‍♀️",
            Code = "1f3cb_1f3fe_200d_2640_fe0f",
            ShortName = "woman lifting weights: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏋🏿‍♀️",
            Code = "1f3cb_1f3ff_200d_2640_fe0f",
            ShortName = "woman lifting weights: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴",
            Code = "1f6b4",
            ShortName = "person biking",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏻",
            Code = "1f6b4_1f3fb",
            ShortName = "person biking: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏼",
            Code = "1f6b4_1f3fc",
            ShortName = "person biking: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏽",
            Code = "1f6b4_1f3fd",
            ShortName = "person biking: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏾",
            Code = "1f6b4_1f3fe",
            ShortName = "person biking: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏿",
            Code = "1f6b4_1f3ff",
            ShortName = "person biking: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴‍♂️",
            Code = "1f6b4_200d_2642_fe0f",
            ShortName = "man biking",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏻‍♂️",
            Code = "1f6b4_1f3fb_200d_2642_fe0f",
            ShortName = "man biking: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏼‍♂️",
            Code = "1f6b4_1f3fc_200d_2642_fe0f",
            ShortName = "man biking: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏽‍♂️",
            Code = "1f6b4_1f3fd_200d_2642_fe0f",
            ShortName = "man biking: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏾‍♂️",
            Code = "1f6b4_1f3fe_200d_2642_fe0f",
            ShortName = "man biking: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏿‍♂️",
            Code = "1f6b4_1f3ff_200d_2642_fe0f",
            ShortName = "man biking: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴‍♀️",
            Code = "1f6b4_200d_2640_fe0f",
            ShortName = "woman biking",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏻‍♀️",
            Code = "1f6b4_1f3fb_200d_2640_fe0f",
            ShortName = "woman biking: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏼‍♀️",
            Code = "1f6b4_1f3fc_200d_2640_fe0f",
            ShortName = "woman biking: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏽‍♀️",
            Code = "1f6b4_1f3fd_200d_2640_fe0f",
            ShortName = "woman biking: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏾‍♀️",
            Code = "1f6b4_1f3fe_200d_2640_fe0f",
            ShortName = "woman biking: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚴🏿‍♀️",
            Code = "1f6b4_1f3ff_200d_2640_fe0f",
            ShortName = "woman biking: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵",
            Code = "1f6b5",
            ShortName = "person mountain biking",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏻",
            Code = "1f6b5_1f3fb",
            ShortName = "person mountain biking: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏼",
            Code = "1f6b5_1f3fc",
            ShortName = "person mountain biking: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏽",
            Code = "1f6b5_1f3fd",
            ShortName = "person mountain biking: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏾",
            Code = "1f6b5_1f3fe",
            ShortName = "person mountain biking: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏿",
            Code = "1f6b5_1f3ff",
            ShortName = "person mountain biking: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵‍♂️",
            Code = "1f6b5_200d_2642_fe0f",
            ShortName = "man mountain biking",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏻‍♂️",
            Code = "1f6b5_1f3fb_200d_2642_fe0f",
            ShortName = "man mountain biking: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏼‍♂️",
            Code = "1f6b5_1f3fc_200d_2642_fe0f",
            ShortName = "man mountain biking: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏽‍♂️",
            Code = "1f6b5_1f3fd_200d_2642_fe0f",
            ShortName = "man mountain biking: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏾‍♂️",
            Code = "1f6b5_1f3fe_200d_2642_fe0f",
            ShortName = "man mountain biking: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏿‍♂️",
            Code = "1f6b5_1f3ff_200d_2642_fe0f",
            ShortName = "man mountain biking: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵‍♀️",
            Code = "1f6b5_200d_2640_fe0f",
            ShortName = "woman mountain biking",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏻‍♀️",
            Code = "1f6b5_1f3fb_200d_2640_fe0f",
            ShortName = "woman mountain biking: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏼‍♀️",
            Code = "1f6b5_1f3fc_200d_2640_fe0f",
            ShortName = "woman mountain biking: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏽‍♀️",
            Code = "1f6b5_1f3fd_200d_2640_fe0f",
            ShortName = "woman mountain biking: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏾‍♀️",
            Code = "1f6b5_1f3fe_200d_2640_fe0f",
            ShortName = "woman mountain biking: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚵🏿‍♀️",
            Code = "1f6b5_1f3ff_200d_2640_fe0f",
            ShortName = "woman mountain biking: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏎",
            Code = "1f3ce",
            ShortName = "racing car",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏍",
            Code = "1f3cd",
            ShortName = "motorcycle",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸",
            Code = "1f938",
            ShortName = "person cartwheeling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏻",
            Code = "1f938_1f3fb",
            ShortName = "person cartwheeling: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏼",
            Code = "1f938_1f3fc",
            ShortName = "person cartwheeling: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏽",
            Code = "1f938_1f3fd",
            ShortName = "person cartwheeling: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏾",
            Code = "1f938_1f3fe",
            ShortName = "person cartwheeling: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏿",
            Code = "1f938_1f3ff",
            ShortName = "person cartwheeling: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸‍♂️",
            Code = "1f938_200d_2642_fe0f",
            ShortName = "man cartwheeling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏻‍♂️",
            Code = "1f938_1f3fb_200d_2642_fe0f",
            ShortName = "man cartwheeling: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏼‍♂️",
            Code = "1f938_1f3fc_200d_2642_fe0f",
            ShortName = "man cartwheeling: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏽‍♂️",
            Code = "1f938_1f3fd_200d_2642_fe0f",
            ShortName = "man cartwheeling: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏾‍♂️",
            Code = "1f938_1f3fe_200d_2642_fe0f",
            ShortName = "man cartwheeling: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏿‍♂️",
            Code = "1f938_1f3ff_200d_2642_fe0f",
            ShortName = "man cartwheeling: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸‍♀️",
            Code = "1f938_200d_2640_fe0f",
            ShortName = "woman cartwheeling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏻‍♀️",
            Code = "1f938_1f3fb_200d_2640_fe0f",
            ShortName = "woman cartwheeling: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏼‍♀️",
            Code = "1f938_1f3fc_200d_2640_fe0f",
            ShortName = "woman cartwheeling: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏽‍♀️",
            Code = "1f938_1f3fd_200d_2640_fe0f",
            ShortName = "woman cartwheeling: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏾‍♀️",
            Code = "1f938_1f3fe_200d_2640_fe0f",
            ShortName = "woman cartwheeling: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤸🏿‍♀️",
            Code = "1f938_1f3ff_200d_2640_fe0f",
            ShortName = "woman cartwheeling: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤼",
            Code = "1f93c",
            ShortName = "people wrestling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤼‍♂️",
            Code = "1f93c_200d_2642_fe0f",
            ShortName = "men wrestling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤼‍♀️",
            Code = "1f93c_200d_2640_fe0f",
            ShortName = "women wrestling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽",
            Code = "1f93d",
            ShortName = "person playing water polo",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏻",
            Code = "1f93d_1f3fb",
            ShortName = "person playing water polo: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏼",
            Code = "1f93d_1f3fc",
            ShortName = "person playing water polo: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏽",
            Code = "1f93d_1f3fd",
            ShortName = "person playing water polo: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏾",
            Code = "1f93d_1f3fe",
            ShortName = "person playing water polo: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏿",
            Code = "1f93d_1f3ff",
            ShortName = "person playing water polo: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽‍♂️",
            Code = "1f93d_200d_2642_fe0f",
            ShortName = "man playing water polo",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏻‍♂️",
            Code = "1f93d_1f3fb_200d_2642_fe0f",
            ShortName = "man playing water polo: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏼‍♂️",
            Code = "1f93d_1f3fc_200d_2642_fe0f",
            ShortName = "man playing water polo: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏽‍♂️",
            Code = "1f93d_1f3fd_200d_2642_fe0f",
            ShortName = "man playing water polo: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏾‍♂️",
            Code = "1f93d_1f3fe_200d_2642_fe0f",
            ShortName = "man playing water polo: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏿‍♂️",
            Code = "1f93d_1f3ff_200d_2642_fe0f",
            ShortName = "man playing water polo: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽‍♀️",
            Code = "1f93d_200d_2640_fe0f",
            ShortName = "woman playing water polo",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏻‍♀️",
            Code = "1f93d_1f3fb_200d_2640_fe0f",
            ShortName = "woman playing water polo: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏼‍♀️",
            Code = "1f93d_1f3fc_200d_2640_fe0f",
            ShortName = "woman playing water polo: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏽‍♀️",
            Code = "1f93d_1f3fd_200d_2640_fe0f",
            ShortName = "woman playing water polo: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏾‍♀️",
            Code = "1f93d_1f3fe_200d_2640_fe0f",
            ShortName = "woman playing water polo: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤽🏿‍♀️",
            Code = "1f93d_1f3ff_200d_2640_fe0f",
            ShortName = "woman playing water polo: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾",
            Code = "1f93e",
            ShortName = "person playing handball",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏻",
            Code = "1f93e_1f3fb",
            ShortName = "person playing handball: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏼",
            Code = "1f93e_1f3fc",
            ShortName = "person playing handball: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏽",
            Code = "1f93e_1f3fd",
            ShortName = "person playing handball: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏾",
            Code = "1f93e_1f3fe",
            ShortName = "person playing handball: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏿",
            Code = "1f93e_1f3ff",
            ShortName = "person playing handball: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾‍♂️",
            Code = "1f93e_200d_2642_fe0f",
            ShortName = "man playing handball",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏻‍♂️",
            Code = "1f93e_1f3fb_200d_2642_fe0f",
            ShortName = "man playing handball: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏼‍♂️",
            Code = "1f93e_1f3fc_200d_2642_fe0f",
            ShortName = "man playing handball: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏽‍♂️",
            Code = "1f93e_1f3fd_200d_2642_fe0f",
            ShortName = "man playing handball: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏾‍♂️",
            Code = "1f93e_1f3fe_200d_2642_fe0f",
            ShortName = "man playing handball: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏿‍♂️",
            Code = "1f93e_1f3ff_200d_2642_fe0f",
            ShortName = "man playing handball: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾‍♀️",
            Code = "1f93e_200d_2640_fe0f",
            ShortName = "woman playing handball",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏻‍♀️",
            Code = "1f93e_1f3fb_200d_2640_fe0f",
            ShortName = "woman playing handball: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏼‍♀️",
            Code = "1f93e_1f3fc_200d_2640_fe0f",
            ShortName = "woman playing handball: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏽‍♀️",
            Code = "1f93e_1f3fd_200d_2640_fe0f",
            ShortName = "woman playing handball: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏾‍♀️",
            Code = "1f93e_1f3fe_200d_2640_fe0f",
            ShortName = "woman playing handball: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤾🏿‍♀️",
            Code = "1f93e_1f3ff_200d_2640_fe0f",
            ShortName = "woman playing handball: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹",
            Code = "1f939",
            ShortName = "person juggling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏻",
            Code = "1f939_1f3fb",
            ShortName = "person juggling: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏼",
            Code = "1f939_1f3fc",
            ShortName = "person juggling: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏽",
            Code = "1f939_1f3fd",
            ShortName = "person juggling: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏾",
            Code = "1f939_1f3fe",
            ShortName = "person juggling: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏿",
            Code = "1f939_1f3ff",
            ShortName = "person juggling: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹‍♂️",
            Code = "1f939_200d_2642_fe0f",
            ShortName = "man juggling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏻‍♂️",
            Code = "1f939_1f3fb_200d_2642_fe0f",
            ShortName = "man juggling: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏼‍♂️",
            Code = "1f939_1f3fc_200d_2642_fe0f",
            ShortName = "man juggling: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏽‍♂️",
            Code = "1f939_1f3fd_200d_2642_fe0f",
            ShortName = "man juggling: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏾‍♂️",
            Code = "1f939_1f3fe_200d_2642_fe0f",
            ShortName = "man juggling: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏿‍♂️",
            Code = "1f939_1f3ff_200d_2642_fe0f",
            ShortName = "man juggling: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹‍♀️",
            Code = "1f939_200d_2640_fe0f",
            ShortName = "woman juggling",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏻‍♀️",
            Code = "1f939_1f3fb_200d_2640_fe0f",
            ShortName = "woman juggling: light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏼‍♀️",
            Code = "1f939_1f3fc_200d_2640_fe0f",
            ShortName = "woman juggling: medium-light skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏽‍♀️",
            Code = "1f939_1f3fd_200d_2640_fe0f",
            ShortName = "woman juggling: medium skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏾‍♀️",
            Code = "1f939_1f3fe_200d_2640_fe0f",
            ShortName = "woman juggling: medium-dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤹🏿‍♀️",
            Code = "1f939_1f3ff_200d_2640_fe0f",
            ShortName = "woman juggling: dark skin tone",
            Category = "person-sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👫",
            Code = "1f46b",
            ShortName = "man and woman holding hands",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👬",
            Code = "1f46c",
            ShortName = "two men holding hands",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👭",
            Code = "1f46d",
            ShortName = "two women holding hands",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💏",
            Code = "1f48f",
            ShortName = "kiss",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍❤️‍💋‍👨",
            Code = "1f469_200d_2764_fe0f_200d_1f48b_200d_1f468",
            ShortName = "kiss: woman, man",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍❤️‍💋‍👨",
            Code = "1f468_200d_2764_fe0f_200d_1f48b_200d_1f468",
            ShortName = "kiss: man, man",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍❤️‍💋‍👩",
            Code = "1f469_200d_2764_fe0f_200d_1f48b_200d_1f469",
            ShortName = "kiss: woman, woman",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💑",
            Code = "1f491",
            ShortName = "couple with heart",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍❤️‍👨",
            Code = "1f469_200d_2764_fe0f_200d_1f468",
            ShortName = "couple with heart: woman, man",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍❤️‍👨",
            Code = "1f468_200d_2764_fe0f_200d_1f468",
            ShortName = "couple with heart: man, man",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍❤️‍👩",
            Code = "1f469_200d_2764_fe0f_200d_1f469",
            ShortName = "couple with heart: woman, woman",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👪",
            Code = "1f46a",
            ShortName = "family",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👩‍👦",
            Code = "1f468_200d_1f469_200d_1f466",
            ShortName = "family: man, woman, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👩‍👧",
            Code = "1f468_200d_1f469_200d_1f467",
            ShortName = "family: man, woman, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👩‍👧‍👦",
            Code = "1f468_200d_1f469_200d_1f467_200d_1f466",
            ShortName = "family: man, woman, girl, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👩‍👦‍👦",
            Code = "1f468_200d_1f469_200d_1f466_200d_1f466",
            ShortName = "family: man, woman, boy, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👩‍👧‍👧",
            Code = "1f468_200d_1f469_200d_1f467_200d_1f467",
            ShortName = "family: man, woman, girl, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👨‍👦",
            Code = "1f468_200d_1f468_200d_1f466",
            ShortName = "family: man, man, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👨‍👧",
            Code = "1f468_200d_1f468_200d_1f467",
            ShortName = "family: man, man, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👨‍👧‍👦",
            Code = "1f468_200d_1f468_200d_1f467_200d_1f466",
            ShortName = "family: man, man, girl, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👨‍👦‍👦",
            Code = "1f468_200d_1f468_200d_1f466_200d_1f466",
            ShortName = "family: man, man, boy, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👨‍👧‍👧",
            Code = "1f468_200d_1f468_200d_1f467_200d_1f467",
            ShortName = "family: man, man, girl, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👩‍👦",
            Code = "1f469_200d_1f469_200d_1f466",
            ShortName = "family: woman, woman, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👩‍👧",
            Code = "1f469_200d_1f469_200d_1f467",
            ShortName = "family: woman, woman, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👩‍👧‍👦",
            Code = "1f469_200d_1f469_200d_1f467_200d_1f466",
            ShortName = "family: woman, woman, girl, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👩‍👦‍👦",
            Code = "1f469_200d_1f469_200d_1f466_200d_1f466",
            ShortName = "family: woman, woman, boy, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👩‍👧‍👧",
            Code = "1f469_200d_1f469_200d_1f467_200d_1f467",
            ShortName = "family: woman, woman, girl, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👦",
            Code = "1f468_200d_1f466",
            ShortName = "family: man, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👦‍👦",
            Code = "1f468_200d_1f466_200d_1f466",
            ShortName = "family: man, boy, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👧",
            Code = "1f468_200d_1f467",
            ShortName = "family: man, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👧‍👦",
            Code = "1f468_200d_1f467_200d_1f466",
            ShortName = "family: man, girl, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👨‍👧‍👧",
            Code = "1f468_200d_1f467_200d_1f467",
            ShortName = "family: man, girl, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👦",
            Code = "1f469_200d_1f466",
            ShortName = "family: woman, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👦‍👦",
            Code = "1f469_200d_1f466_200d_1f466",
            ShortName = "family: woman, boy, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👧",
            Code = "1f469_200d_1f467",
            ShortName = "family: woman, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👧‍👦",
            Code = "1f469_200d_1f467_200d_1f466",
            ShortName = "family: woman, girl, boy",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👩‍👧‍👧",
            Code = "1f469_200d_1f467_200d_1f467",
            ShortName = "family: woman, girl, girl",
            Category = "family",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤳",
            Code = "1f933",
            ShortName = "selfie",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤳🏻",
            Code = "1f933_1f3fb",
            ShortName = "selfie: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤳🏼",
            Code = "1f933_1f3fc",
            ShortName = "selfie: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤳🏽",
            Code = "1f933_1f3fd",
            ShortName = "selfie: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤳🏾",
            Code = "1f933_1f3fe",
            ShortName = "selfie: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤳🏿",
            Code = "1f933_1f3ff",
            ShortName = "selfie: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💪",
            Code = "1f4aa",
            ShortName = "flexed biceps",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💪🏻",
            Code = "1f4aa_1f3fb",
            ShortName = "flexed biceps: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💪🏼",
            Code = "1f4aa_1f3fc",
            ShortName = "flexed biceps: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💪🏽",
            Code = "1f4aa_1f3fd",
            ShortName = "flexed biceps: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💪🏾",
            Code = "1f4aa_1f3fe",
            ShortName = "flexed biceps: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💪🏿",
            Code = "1f4aa_1f3ff",
            ShortName = "flexed biceps: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👈",
            Code = "1f448",
            ShortName = "backhand index pointing left",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👈🏻",
            Code = "1f448_1f3fb",
            ShortName = "backhand index pointing left: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👈🏼",
            Code = "1f448_1f3fc",
            ShortName = "backhand index pointing left: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👈🏽",
            Code = "1f448_1f3fd",
            ShortName = "backhand index pointing left: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👈🏾",
            Code = "1f448_1f3fe",
            ShortName = "backhand index pointing left: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👈🏿",
            Code = "1f448_1f3ff",
            ShortName = "backhand index pointing left: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👉",
            Code = "1f449",
            ShortName = "backhand index pointing right",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👉🏻",
            Code = "1f449_1f3fb",
            ShortName = "backhand index pointing right: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👉🏼",
            Code = "1f449_1f3fc",
            ShortName = "backhand index pointing right: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👉🏽",
            Code = "1f449_1f3fd",
            ShortName = "backhand index pointing right: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👉🏾",
            Code = "1f449_1f3fe",
            ShortName = "backhand index pointing right: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👉🏿",
            Code = "1f449_1f3ff",
            ShortName = "backhand index pointing right: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☝",
            Code = "261d",
            ShortName = "index pointing up",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☝🏻",
            Code = "261d_1f3fb",
            ShortName = "index pointing up: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☝🏼",
            Code = "261d_1f3fc",
            ShortName = "index pointing up: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☝🏽",
            Code = "261d_1f3fd",
            ShortName = "index pointing up: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☝🏾",
            Code = "261d_1f3fe",
            ShortName = "index pointing up: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☝🏿",
            Code = "261d_1f3ff",
            ShortName = "index pointing up: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👆",
            Code = "1f446",
            ShortName = "backhand index pointing up",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👆🏻",
            Code = "1f446_1f3fb",
            ShortName = "backhand index pointing up: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👆🏼",
            Code = "1f446_1f3fc",
            ShortName = "backhand index pointing up: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👆🏽",
            Code = "1f446_1f3fd",
            ShortName = "backhand index pointing up: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👆🏾",
            Code = "1f446_1f3fe",
            ShortName = "backhand index pointing up: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👆🏿",
            Code = "1f446_1f3ff",
            ShortName = "backhand index pointing up: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖕",
            Code = "1f595",
            ShortName = "middle finger",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖕🏻",
            Code = "1f595_1f3fb",
            ShortName = "middle finger: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖕🏼",
            Code = "1f595_1f3fc",
            ShortName = "middle finger: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖕🏽",
            Code = "1f595_1f3fd",
            ShortName = "middle finger: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖕🏾",
            Code = "1f595_1f3fe",
            ShortName = "middle finger: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖕🏿",
            Code = "1f595_1f3ff",
            ShortName = "middle finger: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👇",
            Code = "1f447",
            ShortName = "backhand index pointing down",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👇🏻",
            Code = "1f447_1f3fb",
            ShortName = "backhand index pointing down: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👇🏼",
            Code = "1f447_1f3fc",
            ShortName = "backhand index pointing down: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👇🏽",
            Code = "1f447_1f3fd",
            ShortName = "backhand index pointing down: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👇🏾",
            Code = "1f447_1f3fe",
            ShortName = "backhand index pointing down: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👇🏿",
            Code = "1f447_1f3ff",
            ShortName = "backhand index pointing down: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✌",
            Code = "270c",
            ShortName = "victory hand",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✌🏻",
            Code = "270c_1f3fb",
            ShortName = "victory hand: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✌🏼",
            Code = "270c_1f3fc",
            ShortName = "victory hand: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✌🏽",
            Code = "270c_1f3fd",
            ShortName = "victory hand: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✌🏾",
            Code = "270c_1f3fe",
            ShortName = "victory hand: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✌🏿",
            Code = "270c_1f3ff",
            ShortName = "victory hand: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤞",
            Code = "1f91e",
            ShortName = "crossed fingers",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤞🏻",
            Code = "1f91e_1f3fb",
            ShortName = "crossed fingers: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤞🏼",
            Code = "1f91e_1f3fc",
            ShortName = "crossed fingers: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤞🏽",
            Code = "1f91e_1f3fd",
            ShortName = "crossed fingers: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤞🏾",
            Code = "1f91e_1f3fe",
            ShortName = "crossed fingers: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤞🏿",
            Code = "1f91e_1f3ff",
            ShortName = "crossed fingers: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖖",
            Code = "1f596",
            ShortName = "vulcan salute",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖖🏻",
            Code = "1f596_1f3fb",
            ShortName = "vulcan salute: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖖🏼",
            Code = "1f596_1f3fc",
            ShortName = "vulcan salute: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖖🏽",
            Code = "1f596_1f3fd",
            ShortName = "vulcan salute: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖖🏾",
            Code = "1f596_1f3fe",
            ShortName = "vulcan salute: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖖🏿",
            Code = "1f596_1f3ff",
            ShortName = "vulcan salute: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤘",
            Code = "1f918",
            ShortName = "sign of the horns",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤘🏻",
            Code = "1f918_1f3fb",
            ShortName = "sign of the horns: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤘🏼",
            Code = "1f918_1f3fc",
            ShortName = "sign of the horns: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤘🏽",
            Code = "1f918_1f3fd",
            ShortName = "sign of the horns: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤘🏾",
            Code = "1f918_1f3fe",
            ShortName = "sign of the horns: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤘🏿",
            Code = "1f918_1f3ff",
            ShortName = "sign of the horns: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤙",
            Code = "1f919",
            ShortName = "call me hand",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤙🏻",
            Code = "1f919_1f3fb",
            ShortName = "call me hand: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤙🏼",
            Code = "1f919_1f3fc",
            ShortName = "call me hand: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤙🏽",
            Code = "1f919_1f3fd",
            ShortName = "call me hand: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤙🏾",
            Code = "1f919_1f3fe",
            ShortName = "call me hand: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤙🏿",
            Code = "1f919_1f3ff",
            ShortName = "call me hand: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖐",
            Code = "1f590",
            ShortName = "raised hand with fingers splayed",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖐🏻",
            Code = "1f590_1f3fb",
            ShortName = "raised hand with fingers splayed: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖐🏼",
            Code = "1f590_1f3fc",
            ShortName = "raised hand with fingers splayed: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖐🏽",
            Code = "1f590_1f3fd",
            ShortName = "raised hand with fingers splayed: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖐🏾",
            Code = "1f590_1f3fe",
            ShortName = "raised hand with fingers splayed: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖐🏿",
            Code = "1f590_1f3ff",
            ShortName = "raised hand with fingers splayed: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✋",
            Code = "270b",
            ShortName = "raised hand",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✋🏻",
            Code = "270b_1f3fb",
            ShortName = "raised hand: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✋🏼",
            Code = "270b_1f3fc",
            ShortName = "raised hand: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✋🏽",
            Code = "270b_1f3fd",
            ShortName = "raised hand: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✋🏾",
            Code = "270b_1f3fe",
            ShortName = "raised hand: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✋🏿",
            Code = "270b_1f3ff",
            ShortName = "raised hand: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👌",
            Code = "1f44c",
            ShortName = "OK hand",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👌🏻",
            Code = "1f44c_1f3fb",
            ShortName = "OK hand: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👌🏼",
            Code = "1f44c_1f3fc",
            ShortName = "OK hand: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👌🏽",
            Code = "1f44c_1f3fd",
            ShortName = "OK hand: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👌🏾",
            Code = "1f44c_1f3fe",
            ShortName = "OK hand: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👌🏿",
            Code = "1f44c_1f3ff",
            ShortName = "OK hand: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👍",
            Code = "1f44d",
            ShortName = "thumbs up",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👍🏻",
            Code = "1f44d_1f3fb",
            ShortName = "thumbs up: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👍🏼",
            Code = "1f44d_1f3fc",
            ShortName = "thumbs up: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👍🏽",
            Code = "1f44d_1f3fd",
            ShortName = "thumbs up: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👍🏾",
            Code = "1f44d_1f3fe",
            ShortName = "thumbs up: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👍🏿",
            Code = "1f44d_1f3ff",
            ShortName = "thumbs up: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👎",
            Code = "1f44e",
            ShortName = "thumbs down",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👎🏻",
            Code = "1f44e_1f3fb",
            ShortName = "thumbs down: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👎🏼",
            Code = "1f44e_1f3fc",
            ShortName = "thumbs down: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👎🏽",
            Code = "1f44e_1f3fd",
            ShortName = "thumbs down: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👎🏾",
            Code = "1f44e_1f3fe",
            ShortName = "thumbs down: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👎🏿",
            Code = "1f44e_1f3ff",
            ShortName = "thumbs down: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✊",
            Code = "270a",
            ShortName = "raised fist",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✊🏻",
            Code = "270a_1f3fb",
            ShortName = "raised fist: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✊🏼",
            Code = "270a_1f3fc",
            ShortName = "raised fist: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✊🏽",
            Code = "270a_1f3fd",
            ShortName = "raised fist: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✊🏾",
            Code = "270a_1f3fe",
            ShortName = "raised fist: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✊🏿",
            Code = "270a_1f3ff",
            ShortName = "raised fist: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👊",
            Code = "1f44a",
            ShortName = "oncoming fist",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👊🏻",
            Code = "1f44a_1f3fb",
            ShortName = "oncoming fist: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👊🏼",
            Code = "1f44a_1f3fc",
            ShortName = "oncoming fist: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👊🏽",
            Code = "1f44a_1f3fd",
            ShortName = "oncoming fist: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👊🏾",
            Code = "1f44a_1f3fe",
            ShortName = "oncoming fist: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👊🏿",
            Code = "1f44a_1f3ff",
            ShortName = "oncoming fist: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤛",
            Code = "1f91b",
            ShortName = "left-facing fist",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤛🏻",
            Code = "1f91b_1f3fb",
            ShortName = "left-facing fist: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤛🏼",
            Code = "1f91b_1f3fc",
            ShortName = "left-facing fist: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤛🏽",
            Code = "1f91b_1f3fd",
            ShortName = "left-facing fist: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤛🏾",
            Code = "1f91b_1f3fe",
            ShortName = "left-facing fist: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤛🏿",
            Code = "1f91b_1f3ff",
            ShortName = "left-facing fist: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤜",
            Code = "1f91c",
            ShortName = "right-facing fist",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤜🏻",
            Code = "1f91c_1f3fb",
            ShortName = "right-facing fist: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤜🏼",
            Code = "1f91c_1f3fc",
            ShortName = "right-facing fist: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤜🏽",
            Code = "1f91c_1f3fd",
            ShortName = "right-facing fist: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤜🏾",
            Code = "1f91c_1f3fe",
            ShortName = "right-facing fist: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤜🏿",
            Code = "1f91c_1f3ff",
            ShortName = "right-facing fist: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤚",
            Code = "1f91a",
            ShortName = "raised back of hand",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤚🏻",
            Code = "1f91a_1f3fb",
            ShortName = "raised back of hand: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤚🏼",
            Code = "1f91a_1f3fc",
            ShortName = "raised back of hand: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤚🏽",
            Code = "1f91a_1f3fd",
            ShortName = "raised back of hand: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤚🏾",
            Code = "1f91a_1f3fe",
            ShortName = "raised back of hand: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤚🏿",
            Code = "1f91a_1f3ff",
            ShortName = "raised back of hand: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👋",
            Code = "1f44b",
            ShortName = "waving hand",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👋🏻",
            Code = "1f44b_1f3fb",
            ShortName = "waving hand: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👋🏼",
            Code = "1f44b_1f3fc",
            ShortName = "waving hand: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👋🏽",
            Code = "1f44b_1f3fd",
            ShortName = "waving hand: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👋🏾",
            Code = "1f44b_1f3fe",
            ShortName = "waving hand: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👋🏿",
            Code = "1f44b_1f3ff",
            ShortName = "waving hand: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤟",
            Code = "1f91f",
            ShortName = "love-you gesture",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤟🏻",
            Code = "1f91f_1f3fb",
            ShortName = "love-you gesture: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤟🏼",
            Code = "1f91f_1f3fc",
            ShortName = "love-you gesture: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤟🏽",
            Code = "1f91f_1f3fd",
            ShortName = "love-you gesture: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤟🏾",
            Code = "1f91f_1f3fe",
            ShortName = "love-you gesture: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤟🏿",
            Code = "1f91f_1f3ff",
            ShortName = "love-you gesture: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✍",
            Code = "270d",
            ShortName = "writing hand",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✍🏻",
            Code = "270d_1f3fb",
            ShortName = "writing hand: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✍🏼",
            Code = "270d_1f3fc",
            ShortName = "writing hand: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✍🏽",
            Code = "270d_1f3fd",
            ShortName = "writing hand: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✍🏾",
            Code = "270d_1f3fe",
            ShortName = "writing hand: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✍🏿",
            Code = "270d_1f3ff",
            ShortName = "writing hand: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👏",
            Code = "1f44f",
            ShortName = "clapping hands",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👏🏻",
            Code = "1f44f_1f3fb",
            ShortName = "clapping hands: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👏🏼",
            Code = "1f44f_1f3fc",
            ShortName = "clapping hands: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👏🏽",
            Code = "1f44f_1f3fd",
            ShortName = "clapping hands: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👏🏾",
            Code = "1f44f_1f3fe",
            ShortName = "clapping hands: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👏🏿",
            Code = "1f44f_1f3ff",
            ShortName = "clapping hands: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👐",
            Code = "1f450",
            ShortName = "open hands",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👐🏻",
            Code = "1f450_1f3fb",
            ShortName = "open hands: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👐🏼",
            Code = "1f450_1f3fc",
            ShortName = "open hands: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👐🏽",
            Code = "1f450_1f3fd",
            ShortName = "open hands: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👐🏾",
            Code = "1f450_1f3fe",
            ShortName = "open hands: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👐🏿",
            Code = "1f450_1f3ff",
            ShortName = "open hands: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙌",
            Code = "1f64c",
            ShortName = "raising hands",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙌🏻",
            Code = "1f64c_1f3fb",
            ShortName = "raising hands: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙌🏼",
            Code = "1f64c_1f3fc",
            ShortName = "raising hands: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙌🏽",
            Code = "1f64c_1f3fd",
            ShortName = "raising hands: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙌🏾",
            Code = "1f64c_1f3fe",
            ShortName = "raising hands: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙌🏿",
            Code = "1f64c_1f3ff",
            ShortName = "raising hands: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤲",
            Code = "1f932",
            ShortName = "palms up together",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤲🏻",
            Code = "1f932_1f3fb",
            ShortName = "palms up together: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤲🏼",
            Code = "1f932_1f3fc",
            ShortName = "palms up together: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤲🏽",
            Code = "1f932_1f3fd",
            ShortName = "palms up together: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤲🏾",
            Code = "1f932_1f3fe",
            ShortName = "palms up together: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤲🏿",
            Code = "1f932_1f3ff",
            ShortName = "palms up together: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙏",
            Code = "1f64f",
            ShortName = "folded hands",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙏🏻",
            Code = "1f64f_1f3fb",
            ShortName = "folded hands: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙏🏼",
            Code = "1f64f_1f3fc",
            ShortName = "folded hands: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙏🏽",
            Code = "1f64f_1f3fd",
            ShortName = "folded hands: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙏🏾",
            Code = "1f64f_1f3fe",
            ShortName = "folded hands: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🙏🏿",
            Code = "1f64f_1f3ff",
            ShortName = "folded hands: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🤝",
            Code = "1f91d",
            ShortName = "handshake",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💅",
            Code = "1f485",
            ShortName = "nail polish",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💅🏻",
            Code = "1f485_1f3fb",
            ShortName = "nail polish: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💅🏼",
            Code = "1f485_1f3fc",
            ShortName = "nail polish: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💅🏽",
            Code = "1f485_1f3fd",
            ShortName = "nail polish: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💅🏾",
            Code = "1f485_1f3fe",
            ShortName = "nail polish: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💅🏿",
            Code = "1f485_1f3ff",
            ShortName = "nail polish: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👂",
            Code = "1f442",
            ShortName = "ear",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👂🏻",
            Code = "1f442_1f3fb",
            ShortName = "ear: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👂🏼",
            Code = "1f442_1f3fc",
            ShortName = "ear: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👂🏽",
            Code = "1f442_1f3fd",
            ShortName = "ear: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👂🏾",
            Code = "1f442_1f3fe",
            ShortName = "ear: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👂🏿",
            Code = "1f442_1f3ff",
            ShortName = "ear: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👃",
            Code = "1f443",
            ShortName = "nose",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👃🏻",
            Code = "1f443_1f3fb",
            ShortName = "nose: light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👃🏼",
            Code = "1f443_1f3fc",
            ShortName = "nose: medium-light skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👃🏽",
            Code = "1f443_1f3fd",
            ShortName = "nose: medium skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👃🏾",
            Code = "1f443_1f3fe",
            ShortName = "nose: medium-dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👃🏿",
            Code = "1f443_1f3ff",
            ShortName = "nose: dark skin tone",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👣",
            Code = "1f463",
            ShortName = "footprints",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👀",
            Code = "1f440",
            ShortName = "eyes",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👁",
            Code = "1f441",
            ShortName = "eye",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👁️‍🗨️",
            Code = "1f441_fe0f_200d_1f5e8_fe0f",
            ShortName = "eye in speech bubble",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧠",
            Code = "1f9e0",
            ShortName = "brain",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👅",
            Code = "1f445",
            ShortName = "tongue",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👄",
            Code = "1f444",
            ShortName = "mouth",
            Category = "body",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💋",
            Code = "1f48b",
            ShortName = "kiss mark",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💘",
            Code = "1f498",
            ShortName = "heart with arrow",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❤",
            Code = "2764",
            ShortName = "red heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💓",
            Code = "1f493",
            ShortName = "beating heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💔",
            Code = "1f494",
            ShortName = "broken heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💕",
            Code = "1f495",
            ShortName = "two hearts",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💖",
            Code = "1f496",
            ShortName = "sparkling heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💗",
            Code = "1f497",
            ShortName = "growing heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💙",
            Code = "1f499",
            ShortName = "blue heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💚",
            Code = "1f49a",
            ShortName = "green heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💛",
            Code = "1f49b",
            ShortName = "yellow heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧡",
            Code = "1f9e1",
            ShortName = "orange heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💜",
            Code = "1f49c",
            ShortName = "purple heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖤",
            Code = "1f5a4",
            ShortName = "black heart",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💝",
            Code = "1f49d",
            ShortName = "heart with ribbon",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💞",
            Code = "1f49e",
            ShortName = "revolving hearts",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💟",
            Code = "1f49f",
            ShortName = "heart decoration",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❣",
            Code = "2763",
            ShortName = "heavy heart exclamation",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💌",
            Code = "1f48c",
            ShortName = "love letter",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💤",
            Code = "1f4a4",
            ShortName = "zzz",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💢",
            Code = "1f4a2",
            ShortName = "anger symbol",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💣",
            Code = "1f4a3",
            ShortName = "bomb",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💥",
            Code = "1f4a5",
            ShortName = "collision",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💦",
            Code = "1f4a6",
            ShortName = "sweat droplets",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💨",
            Code = "1f4a8",
            ShortName = "dashing away",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💫",
            Code = "1f4ab",
            ShortName = "dizzy",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💬",
            Code = "1f4ac",
            ShortName = "speech balloon",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗨",
            Code = "1f5e8",
            ShortName = "left speech bubble",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗯",
            Code = "1f5ef",
            ShortName = "right anger bubble",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💭",
            Code = "1f4ad",
            ShortName = "thought balloon",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕳",
            Code = "1f573",
            ShortName = "hole",
            Category = "emotion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👓",
            Code = "1f453",
            ShortName = "glasses",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕶",
            Code = "1f576",
            ShortName = "sunglasses",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👔",
            Code = "1f454",
            ShortName = "necktie",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👕",
            Code = "1f455",
            ShortName = "t-shirt",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👖",
            Code = "1f456",
            ShortName = "jeans",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧣",
            Code = "1f9e3",
            ShortName = "scarf",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧤",
            Code = "1f9e4",
            ShortName = "gloves",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧥",
            Code = "1f9e5",
            ShortName = "coat",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧦",
            Code = "1f9e6",
            ShortName = "socks",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👗",
            Code = "1f457",
            ShortName = "dress",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👘",
            Code = "1f458",
            ShortName = "kimono",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👙",
            Code = "1f459",
            ShortName = "bikini",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👚",
            Code = "1f45a",
            ShortName = "woman’s clothes",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👛",
            Code = "1f45b",
            ShortName = "purse",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👜",
            Code = "1f45c",
            ShortName = "handbag",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👝",
            Code = "1f45d",
            ShortName = "clutch bag",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛍",
            Code = "1f6cd",
            ShortName = "shopping bags",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎒",
            Code = "1f392",
            ShortName = "school backpack",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👞",
            Code = "1f45e",
            ShortName = "man’s shoe",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👟",
            Code = "1f45f",
            ShortName = "running shoe",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👠",
            Code = "1f460",
            ShortName = "high-heeled shoe",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👡",
            Code = "1f461",
            ShortName = "woman’s sandal",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👢",
            Code = "1f462",
            ShortName = "woman’s boot",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👑",
            Code = "1f451",
            ShortName = "crown",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "👒",
            Code = "1f452",
            ShortName = "woman’s hat",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎩",
            Code = "1f3a9",
            ShortName = "top hat",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎓",
            Code = "1f393",
            ShortName = "graduation cap",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧢",
            Code = "1f9e2",
            ShortName = "billed cap",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛑",
            Code = "26d1",
            ShortName = "rescue worker’s helmet",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📿",
            Code = "1f4ff",
            ShortName = "prayer beads",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💄",
            Code = "1f484",
            ShortName = "lipstick",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💍",
            Code = "1f48d",
            ShortName = "ring",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💎",
            Code = "1f48e",
            ShortName = "gem stone",
            Category = "clothing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐵",
            Code = "1f435",
            ShortName = "monkey face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐒",
            Code = "1f412",
            ShortName = "monkey",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦍",
            Code = "1f98d",
            ShortName = "gorilla",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐶",
            Code = "1f436",
            ShortName = "dog face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐕",
            Code = "1f415",
            ShortName = "dog",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐩",
            Code = "1f429",
            ShortName = "poodle",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐺",
            Code = "1f43a",
            ShortName = "wolf face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦊",
            Code = "1f98a",
            ShortName = "fox face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐱",
            Code = "1f431",
            ShortName = "cat face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐈",
            Code = "1f408",
            ShortName = "cat",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦁",
            Code = "1f981",
            ShortName = "lion face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐯",
            Code = "1f42f",
            ShortName = "tiger face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐅",
            Code = "1f405",
            ShortName = "tiger",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐆",
            Code = "1f406",
            ShortName = "leopard",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐴",
            Code = "1f434",
            ShortName = "horse face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐎",
            Code = "1f40e",
            ShortName = "horse",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦄",
            Code = "1f984",
            ShortName = "unicorn face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦓",
            Code = "1f993",
            ShortName = "zebra",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦌",
            Code = "1f98c",
            ShortName = "deer",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐮",
            Code = "1f42e",
            ShortName = "cow face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐂",
            Code = "1f402",
            ShortName = "ox",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐃",
            Code = "1f403",
            ShortName = "water buffalo",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐄",
            Code = "1f404",
            ShortName = "cow",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐷",
            Code = "1f437",
            ShortName = "pig face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐖",
            Code = "1f416",
            ShortName = "pig",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐗",
            Code = "1f417",
            ShortName = "boar",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐽",
            Code = "1f43d",
            ShortName = "pig nose",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐏",
            Code = "1f40f",
            ShortName = "ram",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐑",
            Code = "1f411",
            ShortName = "ewe",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐐",
            Code = "1f410",
            ShortName = "goat",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐪",
            Code = "1f42a",
            ShortName = "camel",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐫",
            Code = "1f42b",
            ShortName = "two-hump camel",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦒",
            Code = "1f992",
            ShortName = "giraffe",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐘",
            Code = "1f418",
            ShortName = "elephant",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦏",
            Code = "1f98f",
            ShortName = "rhinoceros",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐭",
            Code = "1f42d",
            ShortName = "mouse face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐁",
            Code = "1f401",
            ShortName = "mouse",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐀",
            Code = "1f400",
            ShortName = "rat",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐹",
            Code = "1f439",
            ShortName = "hamster face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐰",
            Code = "1f430",
            ShortName = "rabbit face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐇",
            Code = "1f407",
            ShortName = "rabbit",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐿",
            Code = "1f43f",
            ShortName = "chipmunk",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦔",
            Code = "1f994",
            ShortName = "hedgehog",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦇",
            Code = "1f987",
            ShortName = "bat",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐻",
            Code = "1f43b",
            ShortName = "bear face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐨",
            Code = "1f428",
            ShortName = "koala",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐼",
            Code = "1f43c",
            ShortName = "panda face",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐾",
            Code = "1f43e",
            ShortName = "paw prints",
            Category = "animal-mammal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦃",
            Code = "1f983",
            ShortName = "turkey",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐔",
            Code = "1f414",
            ShortName = "chicken",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐓",
            Code = "1f413",
            ShortName = "rooster",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐣",
            Code = "1f423",
            ShortName = "hatching chick",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐤",
            Code = "1f424",
            ShortName = "baby chick",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐥",
            Code = "1f425",
            ShortName = "front-facing baby chick",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐦",
            Code = "1f426",
            ShortName = "bird",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐧",
            Code = "1f427",
            ShortName = "penguin",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕊",
            Code = "1f54a",
            ShortName = "dove",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦅",
            Code = "1f985",
            ShortName = "eagle",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦆",
            Code = "1f986",
            ShortName = "duck",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦉",
            Code = "1f989",
            ShortName = "owl",
            Category = "animal-bird",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐸",
            Code = "1f438",
            ShortName = "frog face",
            Category = "animal-amphibian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐊",
            Code = "1f40a",
            ShortName = "crocodile",
            Category = "animal-reptile",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐢",
            Code = "1f422",
            ShortName = "turtle",
            Category = "animal-reptile",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦎",
            Code = "1f98e",
            ShortName = "lizard",
            Category = "animal-reptile",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐍",
            Code = "1f40d",
            ShortName = "snake",
            Category = "animal-reptile",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐲",
            Code = "1f432",
            ShortName = "dragon face",
            Category = "animal-reptile",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐉",
            Code = "1f409",
            ShortName = "dragon",
            Category = "animal-reptile",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦕",
            Code = "1f995",
            ShortName = "sauropod",
            Category = "animal-reptile",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦖",
            Code = "1f996",
            ShortName = "T-Rex",
            Category = "animal-reptile",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐳",
            Code = "1f433",
            ShortName = "spouting whale",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐋",
            Code = "1f40b",
            ShortName = "whale",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐬",
            Code = "1f42c",
            ShortName = "dolphin",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐟",
            Code = "1f41f",
            ShortName = "fish",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐠",
            Code = "1f420",
            ShortName = "tropical fish",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐡",
            Code = "1f421",
            ShortName = "blowfish",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦈",
            Code = "1f988",
            ShortName = "shark",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐙",
            Code = "1f419",
            ShortName = "octopus",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐚",
            Code = "1f41a",
            ShortName = "spiral shell",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦀",
            Code = "1f980",
            ShortName = "crab",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦐",
            Code = "1f990",
            ShortName = "shrimp",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦑",
            Code = "1f991",
            ShortName = "squid",
            Category = "animal-marine",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐌",
            Code = "1f40c",
            ShortName = "snail",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦋",
            Code = "1f98b",
            ShortName = "butterfly",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐛",
            Code = "1f41b",
            ShortName = "bug",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐜",
            Code = "1f41c",
            ShortName = "ant",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐝",
            Code = "1f41d",
            ShortName = "honeybee",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🐞",
            Code = "1f41e",
            ShortName = "lady beetle",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦗",
            Code = "1f997",
            ShortName = "cricket",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕷",
            Code = "1f577",
            ShortName = "spider",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕸",
            Code = "1f578",
            ShortName = "spider web",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🦂",
            Code = "1f982",
            ShortName = "scorpion",
            Category = "animal-bug",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💐",
            Code = "1f490",
            ShortName = "bouquet",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌸",
            Code = "1f338",
            ShortName = "cherry blossom",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💮",
            Code = "1f4ae",
            ShortName = "white flower",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏵",
            Code = "1f3f5",
            ShortName = "rosette",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌹",
            Code = "1f339",
            ShortName = "rose",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥀",
            Code = "1f940",
            ShortName = "wilted flower",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌺",
            Code = "1f33a",
            ShortName = "hibiscus",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌻",
            Code = "1f33b",
            ShortName = "sunflower",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌼",
            Code = "1f33c",
            ShortName = "blossom",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌷",
            Code = "1f337",
            ShortName = "tulip",
            Category = "plant-flower",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌱",
            Code = "1f331",
            ShortName = "seedling",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌲",
            Code = "1f332",
            ShortName = "evergreen tree",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌳",
            Code = "1f333",
            ShortName = "deciduous tree",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌴",
            Code = "1f334",
            ShortName = "palm tree",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌵",
            Code = "1f335",
            ShortName = "cactus",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌾",
            Code = "1f33e",
            ShortName = "sheaf of rice",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌿",
            Code = "1f33f",
            ShortName = "herb",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☘",
            Code = "2618",
            ShortName = "shamrock",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍀",
            Code = "1f340",
            ShortName = "four leaf clover",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍁",
            Code = "1f341",
            ShortName = "maple leaf",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍂",
            Code = "1f342",
            ShortName = "fallen leaf",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍃",
            Code = "1f343",
            ShortName = "leaf fluttering in wind",
            Category = "plant-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍇",
            Code = "1f347",
            ShortName = "grapes",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍈",
            Code = "1f348",
            ShortName = "melon",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍉",
            Code = "1f349",
            ShortName = "watermelon",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍊",
            Code = "1f34a",
            ShortName = "tangerine",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍋",
            Code = "1f34b",
            ShortName = "lemon",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍌",
            Code = "1f34c",
            ShortName = "banana",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍍",
            Code = "1f34d",
            ShortName = "pineapple",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍎",
            Code = "1f34e",
            ShortName = "red apple",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍏",
            Code = "1f34f",
            ShortName = "green apple",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍐",
            Code = "1f350",
            ShortName = "pear",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍑",
            Code = "1f351",
            ShortName = "peach",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍒",
            Code = "1f352",
            ShortName = "cherries",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍓",
            Code = "1f353",
            ShortName = "strawberry",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥝",
            Code = "1f95d",
            ShortName = "kiwi fruit",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍅",
            Code = "1f345",
            ShortName = "tomato",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥥",
            Code = "1f965",
            ShortName = "coconut",
            Category = "food-fruit",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥑",
            Code = "1f951",
            ShortName = "avocado",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍆",
            Code = "1f346",
            ShortName = "eggplant",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥔",
            Code = "1f954",
            ShortName = "potato",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥕",
            Code = "1f955",
            ShortName = "carrot",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌽",
            Code = "1f33d",
            ShortName = "ear of corn",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌶",
            Code = "1f336",
            ShortName = "hot pepper",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥒",
            Code = "1f952",
            ShortName = "cucumber",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥦",
            Code = "1f966",
            ShortName = "broccoli",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍄",
            Code = "1f344",
            ShortName = "mushroom",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥜",
            Code = "1f95c",
            ShortName = "peanuts",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌰",
            Code = "1f330",
            ShortName = "chestnut",
            Category = "food-vegetable",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍞",
            Code = "1f35e",
            ShortName = "bread",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥐",
            Code = "1f950",
            ShortName = "croissant",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥖",
            Code = "1f956",
            ShortName = "baguette bread",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥨",
            Code = "1f968",
            ShortName = "pretzel",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥞",
            Code = "1f95e",
            ShortName = "pancakes",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🧀",
            Code = "1f9c0",
            ShortName = "cheese wedge",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍖",
            Code = "1f356",
            ShortName = "meat on bone",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍗",
            Code = "1f357",
            ShortName = "poultry leg",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥩",
            Code = "1f969",
            ShortName = "cut of meat",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥓",
            Code = "1f953",
            ShortName = "bacon",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍔",
            Code = "1f354",
            ShortName = "hamburger",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍟",
            Code = "1f35f",
            ShortName = "french fries",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍕",
            Code = "1f355",
            ShortName = "pizza",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌭",
            Code = "1f32d",
            ShortName = "hot dog",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥪",
            Code = "1f96a",
            ShortName = "sandwich",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌮",
            Code = "1f32e",
            ShortName = "taco",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌯",
            Code = "1f32f",
            ShortName = "burrito",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥙",
            Code = "1f959",
            ShortName = "stuffed flatbread",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥚",
            Code = "1f95a",
            ShortName = "egg",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍳",
            Code = "1f373",
            ShortName = "cooking",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥘",
            Code = "1f958",
            ShortName = "shallow pan of food",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍲",
            Code = "1f372",
            ShortName = "pot of food",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥣",
            Code = "1f963",
            ShortName = "bowl with spoon",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥗",
            Code = "1f957",
            ShortName = "green salad",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍿",
            Code = "1f37f",
            ShortName = "popcorn",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥫",
            Code = "1f96b",
            ShortName = "canned food",
            Category = "food-prepared",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍱",
            Code = "1f371",
            ShortName = "bento box",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍘",
            Code = "1f358",
            ShortName = "rice cracker",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍙",
            Code = "1f359",
            ShortName = "rice ball",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍚",
            Code = "1f35a",
            ShortName = "cooked rice",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍛",
            Code = "1f35b",
            ShortName = "curry rice",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍜",
            Code = "1f35c",
            ShortName = "steaming bowl",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍝",
            Code = "1f35d",
            ShortName = "spaghetti",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍠",
            Code = "1f360",
            ShortName = "roasted sweet potato",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍢",
            Code = "1f362",
            ShortName = "oden",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍣",
            Code = "1f363",
            ShortName = "sushi",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍤",
            Code = "1f364",
            ShortName = "fried shrimp",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍥",
            Code = "1f365",
            ShortName = "fish cake with swirl",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍡",
            Code = "1f361",
            ShortName = "dango",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥟",
            Code = "1f95f",
            ShortName = "dumpling",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥠",
            Code = "1f960",
            ShortName = "fortune cookie",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥡",
            Code = "1f961",
            ShortName = "takeout box",
            Category = "food-asian",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍦",
            Code = "1f366",
            ShortName = "soft ice cream",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍧",
            Code = "1f367",
            ShortName = "shaved ice",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍨",
            Code = "1f368",
            ShortName = "ice cream",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍩",
            Code = "1f369",
            ShortName = "doughnut",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍪",
            Code = "1f36a",
            ShortName = "cookie",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎂",
            Code = "1f382",
            ShortName = "birthday cake",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍰",
            Code = "1f370",
            ShortName = "shortcake",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥧",
            Code = "1f967",
            ShortName = "pie",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍫",
            Code = "1f36b",
            ShortName = "chocolate bar",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍬",
            Code = "1f36c",
            ShortName = "candy",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍭",
            Code = "1f36d",
            ShortName = "lollipop",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍮",
            Code = "1f36e",
            ShortName = "custard",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍯",
            Code = "1f36f",
            ShortName = "honey pot",
            Category = "food-sweet",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍼",
            Code = "1f37c",
            ShortName = "baby bottle",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥛",
            Code = "1f95b",
            ShortName = "glass of milk",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☕",
            Code = "2615",
            ShortName = "hot beverage",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍵",
            Code = "1f375",
            ShortName = "teacup without handle",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍶",
            Code = "1f376",
            ShortName = "sake",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍾",
            Code = "1f37e",
            ShortName = "bottle with popping cork",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍷",
            Code = "1f377",
            ShortName = "wine glass",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍸",
            Code = "1f378",
            ShortName = "cocktail glass",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍹",
            Code = "1f379",
            ShortName = "tropical drink",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍺",
            Code = "1f37a",
            ShortName = "beer mug",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍻",
            Code = "1f37b",
            ShortName = "clinking beer mugs",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥂",
            Code = "1f942",
            ShortName = "clinking glasses",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥃",
            Code = "1f943",
            ShortName = "tumbler glass",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥤",
            Code = "1f964",
            ShortName = "cup with straw",
            Category = "drink",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥢",
            Code = "1f962",
            ShortName = "chopsticks",
            Category = "dishware",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍽",
            Code = "1f37d",
            ShortName = "fork and knife with plate",
            Category = "dishware",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🍴",
            Code = "1f374",
            ShortName = "fork and knife",
            Category = "dishware",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥄",
            Code = "1f944",
            ShortName = "spoon",
            Category = "dishware",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔪",
            Code = "1f52a",
            ShortName = "kitchen knife",
            Category = "dishware",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏺",
            Code = "1f3fa",
            ShortName = "amphora",
            Category = "dishware",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌍",
            Code = "1f30d",
            ShortName = "globe showing Europe-Africa",
            Category = "place-map",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌎",
            Code = "1f30e",
            ShortName = "globe showing Americas",
            Category = "place-map",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌏",
            Code = "1f30f",
            ShortName = "globe showing Asia-Australia",
            Category = "place-map",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌐",
            Code = "1f310",
            ShortName = "globe with meridians",
            Category = "place-map",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗺",
            Code = "1f5fa",
            ShortName = "world map",
            Category = "place-map",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗾",
            Code = "1f5fe",
            ShortName = "map of Japan",
            Category = "place-map",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏔",
            Code = "1f3d4",
            ShortName = "snow-capped mountain",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛰",
            Code = "26f0",
            ShortName = "mountain",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌋",
            Code = "1f30b",
            ShortName = "volcano",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗻",
            Code = "1f5fb",
            ShortName = "mount fuji",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏕",
            Code = "1f3d5",
            ShortName = "camping",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏖",
            Code = "1f3d6",
            ShortName = "beach with umbrella",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏜",
            Code = "1f3dc",
            ShortName = "desert",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏝",
            Code = "1f3dd",
            ShortName = "desert island",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏞",
            Code = "1f3de",
            ShortName = "national park",
            Category = "place-geographic",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏟",
            Code = "1f3df",
            ShortName = "stadium",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏛",
            Code = "1f3db",
            ShortName = "classical building",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏗",
            Code = "1f3d7",
            ShortName = "building construction",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏘",
            Code = "1f3d8",
            ShortName = "houses",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏙",
            Code = "1f3d9",
            ShortName = "cityscape",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏚",
            Code = "1f3da",
            ShortName = "derelict house",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏠",
            Code = "1f3e0",
            ShortName = "house",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏡",
            Code = "1f3e1",
            ShortName = "house with garden",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏢",
            Code = "1f3e2",
            ShortName = "office building",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏣",
            Code = "1f3e3",
            ShortName = "Japanese post office",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏤",
            Code = "1f3e4",
            ShortName = "post office",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏥",
            Code = "1f3e5",
            ShortName = "hospital",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏦",
            Code = "1f3e6",
            ShortName = "bank",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏨",
            Code = "1f3e8",
            ShortName = "hotel",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏩",
            Code = "1f3e9",
            ShortName = "love hotel",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏪",
            Code = "1f3ea",
            ShortName = "convenience store",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏫",
            Code = "1f3eb",
            ShortName = "school",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏬",
            Code = "1f3ec",
            ShortName = "department store",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏭",
            Code = "1f3ed",
            ShortName = "factory",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏯",
            Code = "1f3ef",
            ShortName = "Japanese castle",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏰",
            Code = "1f3f0",
            ShortName = "castle",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💒",
            Code = "1f492",
            ShortName = "wedding",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗼",
            Code = "1f5fc",
            ShortName = "Tokyo tower",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗽",
            Code = "1f5fd",
            ShortName = "Statue of Liberty",
            Category = "place-building",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛪",
            Code = "26ea",
            ShortName = "church",
            Category = "place-religious",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕌",
            Code = "1f54c",
            ShortName = "mosque",
            Category = "place-religious",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕍",
            Code = "1f54d",
            ShortName = "synagogue",
            Category = "place-religious",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛩",
            Code = "26e9",
            ShortName = "shinto shrine",
            Category = "place-religious",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕋",
            Code = "1f54b",
            ShortName = "kaaba",
            Category = "place-religious",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛲",
            Code = "26f2",
            ShortName = "fountain",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛺",
            Code = "26fa",
            ShortName = "tent",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌁",
            Code = "1f301",
            ShortName = "foggy",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌃",
            Code = "1f303",
            ShortName = "night with stars",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌄",
            Code = "1f304",
            ShortName = "sunrise over mountains",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌅",
            Code = "1f305",
            ShortName = "sunrise",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌆",
            Code = "1f306",
            ShortName = "cityscape at dusk",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌇",
            Code = "1f307",
            ShortName = "sunset",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌉",
            Code = "1f309",
            ShortName = "bridge at night",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♨",
            Code = "2668",
            ShortName = "hot springs",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌌",
            Code = "1f30c",
            ShortName = "milky way",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎠",
            Code = "1f3a0",
            ShortName = "carousel horse",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎡",
            Code = "1f3a1",
            ShortName = "ferris wheel",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎢",
            Code = "1f3a2",
            ShortName = "roller coaster",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💈",
            Code = "1f488",
            ShortName = "barber pole",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎪",
            Code = "1f3aa",
            ShortName = "circus tent",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎭",
            Code = "1f3ad",
            ShortName = "performing arts",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖼",
            Code = "1f5bc",
            ShortName = "framed picture",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎨",
            Code = "1f3a8",
            ShortName = "artist palette",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎰",
            Code = "1f3b0",
            ShortName = "slot machine",
            Category = "place-other",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚂",
            Code = "1f682",
            ShortName = "locomotive",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚃",
            Code = "1f683",
            ShortName = "railway car",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚄",
            Code = "1f684",
            ShortName = "high-speed train",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚅",
            Code = "1f685",
            ShortName = "high-speed train with bullet nose",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚆",
            Code = "1f686",
            ShortName = "train",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚇",
            Code = "1f687",
            ShortName = "metro",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚈",
            Code = "1f688",
            ShortName = "light rail",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚉",
            Code = "1f689",
            ShortName = "station",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚊",
            Code = "1f68a",
            ShortName = "tram",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚝",
            Code = "1f69d",
            ShortName = "monorail",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚞",
            Code = "1f69e",
            ShortName = "mountain railway",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚋",
            Code = "1f68b",
            ShortName = "tram car",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚌",
            Code = "1f68c",
            ShortName = "bus",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚍",
            Code = "1f68d",
            ShortName = "oncoming bus",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚎",
            Code = "1f68e",
            ShortName = "trolleybus",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚐",
            Code = "1f690",
            ShortName = "minibus",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚑",
            Code = "1f691",
            ShortName = "ambulance",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚒",
            Code = "1f692",
            ShortName = "fire engine",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚓",
            Code = "1f693",
            ShortName = "police car",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚔",
            Code = "1f694",
            ShortName = "oncoming police car",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚕",
            Code = "1f695",
            ShortName = "taxi",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚖",
            Code = "1f696",
            ShortName = "oncoming taxi",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚗",
            Code = "1f697",
            ShortName = "automobile",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚘",
            Code = "1f698",
            ShortName = "oncoming automobile",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚙",
            Code = "1f699",
            ShortName = "sport utility vehicle",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚚",
            Code = "1f69a",
            ShortName = "delivery truck",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚛",
            Code = "1f69b",
            ShortName = "articulated lorry",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚜",
            Code = "1f69c",
            ShortName = "tractor",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚲",
            Code = "1f6b2",
            ShortName = "bicycle",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛴",
            Code = "1f6f4",
            ShortName = "kick scooter",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛵",
            Code = "1f6f5",
            ShortName = "motor scooter",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚏",
            Code = "1f68f",
            ShortName = "bus stop",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛣",
            Code = "1f6e3",
            ShortName = "motorway",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛤",
            Code = "1f6e4",
            ShortName = "railway track",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛽",
            Code = "26fd",
            ShortName = "fuel pump",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚨",
            Code = "1f6a8",
            ShortName = "police car light",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚥",
            Code = "1f6a5",
            ShortName = "horizontal traffic light",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚦",
            Code = "1f6a6",
            ShortName = "vertical traffic light",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚧",
            Code = "1f6a7",
            ShortName = "construction",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛑",
            Code = "1f6d1",
            ShortName = "stop sign",
            Category = "transport-ground",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚓",
            Code = "2693",
            ShortName = "anchor",
            Category = "transport-water",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛵",
            Code = "26f5",
            ShortName = "sailboat",
            Category = "transport-water",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛶",
            Code = "1f6f6",
            ShortName = "canoe",
            Category = "transport-water",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚤",
            Code = "1f6a4",
            ShortName = "speedboat",
            Category = "transport-water",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛳",
            Code = "1f6f3",
            ShortName = "passenger ship",
            Category = "transport-water",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛴",
            Code = "26f4",
            ShortName = "ferry",
            Category = "transport-water",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛥",
            Code = "1f6e5",
            ShortName = "motor boat",
            Category = "transport-water",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚢",
            Code = "1f6a2",
            ShortName = "ship",
            Category = "transport-water",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✈",
            Code = "2708",
            ShortName = "airplane",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛩",
            Code = "1f6e9",
            ShortName = "small airplane",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛫",
            Code = "1f6eb",
            ShortName = "airplane departure",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛬",
            Code = "1f6ec",
            ShortName = "airplane arrival",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💺",
            Code = "1f4ba",
            ShortName = "seat",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚁",
            Code = "1f681",
            ShortName = "helicopter",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚟",
            Code = "1f69f",
            ShortName = "suspension railway",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚠",
            Code = "1f6a0",
            ShortName = "mountain cableway",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚡",
            Code = "1f6a1",
            ShortName = "aerial tramway",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛰",
            Code = "1f6f0",
            ShortName = "satellite",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚀",
            Code = "1f680",
            ShortName = "rocket",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛸",
            Code = "1f6f8",
            ShortName = "flying saucer",
            Category = "transport-air",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛎",
            Code = "1f6ce",
            ShortName = "bellhop bell",
            Category = "hotel",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚪",
            Code = "1f6aa",
            ShortName = "door",
            Category = "hotel",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛏",
            Code = "1f6cf",
            ShortName = "bed",
            Category = "hotel",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛋",
            Code = "1f6cb",
            ShortName = "couch and lamp",
            Category = "hotel",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚽",
            Code = "1f6bd",
            ShortName = "toilet",
            Category = "hotel",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚿",
            Code = "1f6bf",
            ShortName = "shower",
            Category = "hotel",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛁",
            Code = "1f6c1",
            ShortName = "bathtub",
            Category = "hotel",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⌛",
            Code = "231b",
            ShortName = "hourglass",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏳",
            Code = "23f3",
            ShortName = "hourglass with flowing sand",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⌚",
            Code = "231a",
            ShortName = "watch",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏰",
            Code = "23f0",
            ShortName = "alarm clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏱",
            Code = "23f1",
            ShortName = "stopwatch",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏲",
            Code = "23f2",
            ShortName = "timer clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕰",
            Code = "1f570",
            ShortName = "mantelpiece clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕛",
            Code = "1f55b",
            ShortName = "twelve o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕧",
            Code = "1f567",
            ShortName = "twelve-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕐",
            Code = "1f550",
            ShortName = "one o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕜",
            Code = "1f55c",
            ShortName = "one-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕑",
            Code = "1f551",
            ShortName = "two o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕝",
            Code = "1f55d",
            ShortName = "two-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕒",
            Code = "1f552",
            ShortName = "three o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕞",
            Code = "1f55e",
            ShortName = "three-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕓",
            Code = "1f553",
            ShortName = "four o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕟",
            Code = "1f55f",
            ShortName = "four-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕔",
            Code = "1f554",
            ShortName = "five o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕠",
            Code = "1f560",
            ShortName = "five-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕕",
            Code = "1f555",
            ShortName = "six o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕡",
            Code = "1f561",
            ShortName = "six-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕖",
            Code = "1f556",
            ShortName = "seven o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕢",
            Code = "1f562",
            ShortName = "seven-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕗",
            Code = "1f557",
            ShortName = "eight o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕣",
            Code = "1f563",
            ShortName = "eight-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕘",
            Code = "1f558",
            ShortName = "nine o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕤",
            Code = "1f564",
            ShortName = "nine-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕙",
            Code = "1f559",
            ShortName = "ten o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕥",
            Code = "1f565",
            ShortName = "ten-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕚",
            Code = "1f55a",
            ShortName = "eleven o’clock",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕦",
            Code = "1f566",
            ShortName = "eleven-thirty",
            Category = "time",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌑",
            Code = "1f311",
            ShortName = "new moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌒",
            Code = "1f312",
            ShortName = "waxing crescent moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌓",
            Code = "1f313",
            ShortName = "first quarter moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌔",
            Code = "1f314",
            ShortName = "waxing gibbous moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌕",
            Code = "1f315",
            ShortName = "full moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌖",
            Code = "1f316",
            ShortName = "waning gibbous moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌗",
            Code = "1f317",
            ShortName = "last quarter moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌘",
            Code = "1f318",
            ShortName = "waning crescent moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌙",
            Code = "1f319",
            ShortName = "crescent moon",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌚",
            Code = "1f31a",
            ShortName = "new moon face",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌛",
            Code = "1f31b",
            ShortName = "first quarter moon with face",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌜",
            Code = "1f31c",
            ShortName = "last quarter moon with face",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌡",
            Code = "1f321",
            ShortName = "thermometer",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☀",
            Code = "2600",
            ShortName = "sun",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌝",
            Code = "1f31d",
            ShortName = "full moon with face",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌞",
            Code = "1f31e",
            ShortName = "sun with face",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⭐",
            Code = "2b50",
            ShortName = "white medium star",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌟",
            Code = "1f31f",
            ShortName = "glowing star",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌠",
            Code = "1f320",
            ShortName = "shooting star",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☁",
            Code = "2601",
            ShortName = "cloud",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛅",
            Code = "26c5",
            ShortName = "sun behind cloud",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛈",
            Code = "26c8",
            ShortName = "cloud with lightning and rain",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌤",
            Code = "1f324",
            ShortName = "sun behind small cloud",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌥",
            Code = "1f325",
            ShortName = "sun behind large cloud",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌦",
            Code = "1f326",
            ShortName = "sun behind rain cloud",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌧",
            Code = "1f327",
            ShortName = "cloud with rain",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌨",
            Code = "1f328",
            ShortName = "cloud with snow",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌩",
            Code = "1f329",
            ShortName = "cloud with lightning",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌪",
            Code = "1f32a",
            ShortName = "tornado",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌫",
            Code = "1f32b",
            ShortName = "fog",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌬",
            Code = "1f32c",
            ShortName = "wind face",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌀",
            Code = "1f300",
            ShortName = "cyclone",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌈",
            Code = "1f308",
            ShortName = "rainbow",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌂",
            Code = "1f302",
            ShortName = "closed umbrella",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☂",
            Code = "2602",
            ShortName = "umbrella",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☔",
            Code = "2614",
            ShortName = "umbrella with rain drops",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛱",
            Code = "26f1",
            ShortName = "umbrella on ground",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚡",
            Code = "26a1",
            ShortName = "high voltage",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❄",
            Code = "2744",
            ShortName = "snowflake",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☃",
            Code = "2603",
            ShortName = "snowman",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛄",
            Code = "26c4",
            ShortName = "snowman without snow",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☄",
            Code = "2604",
            ShortName = "comet",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔥",
            Code = "1f525",
            ShortName = "fire",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💧",
            Code = "1f4a7",
            ShortName = "droplet",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🌊",
            Code = "1f30a",
            ShortName = "water wave",
            Category = "sky_&amp;_weather",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎃",
            Code = "1f383",
            ShortName = "jack-o-lantern",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎄",
            Code = "1f384",
            ShortName = "Christmas tree",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎆",
            Code = "1f386",
            ShortName = "fireworks",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎇",
            Code = "1f387",
            ShortName = "sparkler",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✨",
            Code = "2728",
            ShortName = "sparkles",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎈",
            Code = "1f388",
            ShortName = "balloon",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎉",
            Code = "1f389",
            ShortName = "party popper",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎊",
            Code = "1f38a",
            ShortName = "confetti ball",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎋",
            Code = "1f38b",
            ShortName = "tanabata tree",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎍",
            Code = "1f38d",
            ShortName = "pine decoration",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎎",
            Code = "1f38e",
            ShortName = "Japanese dolls",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎏",
            Code = "1f38f",
            ShortName = "carp streamer",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎐",
            Code = "1f390",
            ShortName = "wind chime",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎑",
            Code = "1f391",
            ShortName = "moon viewing ceremony",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎀",
            Code = "1f380",
            ShortName = "ribbon",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎁",
            Code = "1f381",
            ShortName = "wrapped gift",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎗",
            Code = "1f397",
            ShortName = "reminder ribbon",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎟",
            Code = "1f39f",
            ShortName = "admission tickets",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎫",
            Code = "1f3ab",
            ShortName = "ticket",
            Category = "event",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎖",
            Code = "1f396",
            ShortName = "military medal",
            Category = "award-medal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏆",
            Code = "1f3c6",
            ShortName = "trophy",
            Category = "award-medal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏅",
            Code = "1f3c5",
            ShortName = "sports medal",
            Category = "award-medal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥇",
            Code = "1f947",
            ShortName = "1st place medal",
            Category = "award-medal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥈",
            Code = "1f948",
            ShortName = "2nd place medal",
            Category = "award-medal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥉",
            Code = "1f949",
            ShortName = "3rd place medal",
            Category = "award-medal",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚽",
            Code = "26bd",
            ShortName = "soccer ball",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚾",
            Code = "26be",
            ShortName = "baseball",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏀",
            Code = "1f3c0",
            ShortName = "basketball",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏐",
            Code = "1f3d0",
            ShortName = "volleyball",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏈",
            Code = "1f3c8",
            ShortName = "american football",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏉",
            Code = "1f3c9",
            ShortName = "rugby football",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎾",
            Code = "1f3be",
            ShortName = "tennis",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎱",
            Code = "1f3b1",
            ShortName = "pool 8 ball",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎳",
            Code = "1f3b3",
            ShortName = "bowling",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏏",
            Code = "1f3cf",
            ShortName = "cricket game",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏑",
            Code = "1f3d1",
            ShortName = "field hockey",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏒",
            Code = "1f3d2",
            ShortName = "ice hockey",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏓",
            Code = "1f3d3",
            ShortName = "ping pong",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏸",
            Code = "1f3f8",
            ShortName = "badminton",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥊",
            Code = "1f94a",
            ShortName = "boxing glove",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥋",
            Code = "1f94b",
            ShortName = "martial arts uniform",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥅",
            Code = "1f945",
            ShortName = "goal net",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎯",
            Code = "1f3af",
            ShortName = "direct hit",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛳",
            Code = "26f3",
            ShortName = "flag in hole",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛸",
            Code = "26f8",
            ShortName = "ice skate",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎣",
            Code = "1f3a3",
            ShortName = "fishing pole",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎽",
            Code = "1f3bd",
            ShortName = "running shirt",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎿",
            Code = "1f3bf",
            ShortName = "skis",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛷",
            Code = "1f6f7",
            ShortName = "sled",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥌",
            Code = "1f94c",
            ShortName = "curling stone",
            Category = "sport",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎮",
            Code = "1f3ae",
            ShortName = "video game",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕹",
            Code = "1f579",
            ShortName = "joystick",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎲",
            Code = "1f3b2",
            ShortName = "game die",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♠",
            Code = "2660",
            ShortName = "spade suit",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♥",
            Code = "2665",
            ShortName = "heart suit",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♦",
            Code = "2666",
            ShortName = "diamond suit",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♣",
            Code = "2663",
            ShortName = "club suit",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🃏",
            Code = "1f0cf",
            ShortName = "joker",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🀄",
            Code = "1f004",
            ShortName = "mahjong red dragon",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎴",
            Code = "1f3b4",
            ShortName = "flower playing cards",
            Category = "game",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔇",
            Code = "1f507",
            ShortName = "muted speaker",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔈",
            Code = "1f508",
            ShortName = "speaker low volume",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔉",
            Code = "1f509",
            ShortName = "speaker medium volume",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔊",
            Code = "1f50a",
            ShortName = "speaker high volume",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📢",
            Code = "1f4e2",
            ShortName = "loudspeaker",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📣",
            Code = "1f4e3",
            ShortName = "megaphone",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📯",
            Code = "1f4ef",
            ShortName = "postal horn",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔔",
            Code = "1f514",
            ShortName = "bell",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔕",
            Code = "1f515",
            ShortName = "bell with slash",
            Category = "sound",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎼",
            Code = "1f3bc",
            ShortName = "musical score",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎵",
            Code = "1f3b5",
            ShortName = "musical note",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎶",
            Code = "1f3b6",
            ShortName = "musical notes",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎙",
            Code = "1f399",
            ShortName = "studio microphone",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎚",
            Code = "1f39a",
            ShortName = "level slider",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎛",
            Code = "1f39b",
            ShortName = "control knobs",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎤",
            Code = "1f3a4",
            ShortName = "microphone",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎧",
            Code = "1f3a7",
            ShortName = "headphone",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📻",
            Code = "1f4fb",
            ShortName = "radio",
            Category = "music",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎷",
            Code = "1f3b7",
            ShortName = "saxophone",
            Category = "musical-instrument",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎸",
            Code = "1f3b8",
            ShortName = "guitar",
            Category = "musical-instrument",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎹",
            Code = "1f3b9",
            ShortName = "musical keyboard",
            Category = "musical-instrument",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎺",
            Code = "1f3ba",
            ShortName = "trumpet",
            Category = "musical-instrument",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎻",
            Code = "1f3bb",
            ShortName = "violin",
            Category = "musical-instrument",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🥁",
            Code = "1f941",
            ShortName = "drum",
            Category = "musical-instrument",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📱",
            Code = "1f4f1",
            ShortName = "mobile phone",
            Category = "phone",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📲",
            Code = "1f4f2",
            ShortName = "mobile phone with arrow",
            Category = "phone",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☎",
            Code = "260e",
            ShortName = "telephone",
            Category = "phone",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📞",
            Code = "1f4de",
            ShortName = "telephone receiver",
            Category = "phone",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📟",
            Code = "1f4df",
            ShortName = "pager",
            Category = "phone",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📠",
            Code = "1f4e0",
            ShortName = "fax machine",
            Category = "phone",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔋",
            Code = "1f50b",
            ShortName = "battery",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔌",
            Code = "1f50c",
            ShortName = "electric plug",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💻",
            Code = "1f4bb",
            ShortName = "laptop computer",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖥",
            Code = "1f5a5",
            ShortName = "desktop computer",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖨",
            Code = "1f5a8",
            ShortName = "printer",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⌨",
            Code = "2328",
            ShortName = "keyboard",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖱",
            Code = "1f5b1",
            ShortName = "computer mouse",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖲",
            Code = "1f5b2",
            ShortName = "trackball",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💽",
            Code = "1f4bd",
            ShortName = "computer disk",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💾",
            Code = "1f4be",
            ShortName = "floppy disk",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💿",
            Code = "1f4bf",
            ShortName = "optical disk",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📀",
            Code = "1f4c0",
            ShortName = "dvd",
            Category = "computer",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎥",
            Code = "1f3a5",
            ShortName = "movie camera",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎞",
            Code = "1f39e",
            ShortName = "film frames",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📽",
            Code = "1f4fd",
            ShortName = "film projector",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎬",
            Code = "1f3ac",
            ShortName = "clapper board",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📺",
            Code = "1f4fa",
            ShortName = "television",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📷",
            Code = "1f4f7",
            ShortName = "camera",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📸",
            Code = "1f4f8",
            ShortName = "camera with flash",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📹",
            Code = "1f4f9",
            ShortName = "video camera",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📼",
            Code = "1f4fc",
            ShortName = "videocassette",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔍",
            Code = "1f50d",
            ShortName = "left-pointing magnifying glass",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔎",
            Code = "1f50e",
            ShortName = "right-pointing magnifying glass",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔬",
            Code = "1f52c",
            ShortName = "microscope",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔭",
            Code = "1f52d",
            ShortName = "telescope",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📡",
            Code = "1f4e1",
            ShortName = "satellite antenna",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕯",
            Code = "1f56f",
            ShortName = "candle",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💡",
            Code = "1f4a1",
            ShortName = "light bulb",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔦",
            Code = "1f526",
            ShortName = "flashlight",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏮",
            Code = "1f3ee",
            ShortName = "red paper lantern",
            Category = "light_&amp;_video",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📔",
            Code = "1f4d4",
            ShortName = "notebook with decorative cover",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📕",
            Code = "1f4d5",
            ShortName = "closed book",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📖",
            Code = "1f4d6",
            ShortName = "open book",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📗",
            Code = "1f4d7",
            ShortName = "green book",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📘",
            Code = "1f4d8",
            ShortName = "blue book",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📙",
            Code = "1f4d9",
            ShortName = "orange book",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📚",
            Code = "1f4da",
            ShortName = "books",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📓",
            Code = "1f4d3",
            ShortName = "notebook",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📒",
            Code = "1f4d2",
            ShortName = "ledger",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📃",
            Code = "1f4c3",
            ShortName = "page with curl",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📜",
            Code = "1f4dc",
            ShortName = "scroll",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📄",
            Code = "1f4c4",
            ShortName = "page facing up",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📰",
            Code = "1f4f0",
            ShortName = "newspaper",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗞",
            Code = "1f5de",
            ShortName = "rolled-up newspaper",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📑",
            Code = "1f4d1",
            ShortName = "bookmark tabs",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔖",
            Code = "1f516",
            ShortName = "bookmark",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏷",
            Code = "1f3f7",
            ShortName = "label",
            Category = "book-paper",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💰",
            Code = "1f4b0",
            ShortName = "money bag",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💴",
            Code = "1f4b4",
            ShortName = "yen banknote",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💵",
            Code = "1f4b5",
            ShortName = "dollar banknote",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💶",
            Code = "1f4b6",
            ShortName = "euro banknote",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💷",
            Code = "1f4b7",
            ShortName = "pound banknote",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💸",
            Code = "1f4b8",
            ShortName = "money with wings",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💳",
            Code = "1f4b3",
            ShortName = "credit card",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💹",
            Code = "1f4b9",
            ShortName = "chart increasing with yen",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💱",
            Code = "1f4b1",
            ShortName = "currency exchange",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💲",
            Code = "1f4b2",
            ShortName = "heavy dollar sign",
            Category = "money",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✉",
            Code = "2709",
            ShortName = "envelope",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📧",
            Code = "1f4e7",
            ShortName = "e-mail",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📨",
            Code = "1f4e8",
            ShortName = "incoming envelope",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📩",
            Code = "1f4e9",
            ShortName = "envelope with arrow",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📤",
            Code = "1f4e4",
            ShortName = "outbox tray",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📥",
            Code = "1f4e5",
            ShortName = "inbox tray",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📦",
            Code = "1f4e6",
            ShortName = "package",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📫",
            Code = "1f4eb",
            ShortName = "closed mailbox with raised flag",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📪",
            Code = "1f4ea",
            ShortName = "closed mailbox with lowered flag",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📬",
            Code = "1f4ec",
            ShortName = "open mailbox with raised flag",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📭",
            Code = "1f4ed",
            ShortName = "open mailbox with lowered flag",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📮",
            Code = "1f4ee",
            ShortName = "postbox",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗳",
            Code = "1f5f3",
            ShortName = "ballot box with ballot",
            Category = "mail",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✏",
            Code = "270f",
            ShortName = "pencil",
            Category = "writing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✒",
            Code = "2712",
            ShortName = "black nib",
            Category = "writing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖋",
            Code = "1f58b",
            ShortName = "fountain pen",
            Category = "writing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖊",
            Code = "1f58a",
            ShortName = "pen",
            Category = "writing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖌",
            Code = "1f58c",
            ShortName = "paintbrush",
            Category = "writing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖍",
            Code = "1f58d",
            ShortName = "crayon",
            Category = "writing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📝",
            Code = "1f4dd",
            ShortName = "memo",
            Category = "writing",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💼",
            Code = "1f4bc",
            ShortName = "briefcase",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📁",
            Code = "1f4c1",
            ShortName = "file folder",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📂",
            Code = "1f4c2",
            ShortName = "open file folder",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗂",
            Code = "1f5c2",
            ShortName = "card index dividers",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📅",
            Code = "1f4c5",
            ShortName = "calendar",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📆",
            Code = "1f4c6",
            ShortName = "tear-off calendar",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗒",
            Code = "1f5d2",
            ShortName = "spiral notepad",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗓",
            Code = "1f5d3",
            ShortName = "spiral calendar",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📇",
            Code = "1f4c7",
            ShortName = "card index",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📈",
            Code = "1f4c8",
            ShortName = "chart increasing",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📉",
            Code = "1f4c9",
            ShortName = "chart decreasing",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📊",
            Code = "1f4ca",
            ShortName = "bar chart",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📋",
            Code = "1f4cb",
            ShortName = "clipboard",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📌",
            Code = "1f4cc",
            ShortName = "pushpin",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📍",
            Code = "1f4cd",
            ShortName = "round pushpin",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📎",
            Code = "1f4ce",
            ShortName = "paperclip",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🖇",
            Code = "1f587",
            ShortName = "linked paperclips",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📏",
            Code = "1f4cf",
            ShortName = "straight ruler",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📐",
            Code = "1f4d0",
            ShortName = "triangular ruler",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✂",
            Code = "2702",
            ShortName = "scissors",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗃",
            Code = "1f5c3",
            ShortName = "card file box",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗄",
            Code = "1f5c4",
            ShortName = "file cabinet",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗑",
            Code = "1f5d1",
            ShortName = "wastebasket",
            Category = "office",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔒",
            Code = "1f512",
            ShortName = "locked",
            Category = "lock",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔓",
            Code = "1f513",
            ShortName = "unlocked",
            Category = "lock",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔏",
            Code = "1f50f",
            ShortName = "locked with pen",
            Category = "lock",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔐",
            Code = "1f510",
            ShortName = "locked with key",
            Category = "lock",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔑",
            Code = "1f511",
            ShortName = "key",
            Category = "lock",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗝",
            Code = "1f5dd",
            ShortName = "old key",
            Category = "lock",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔨",
            Code = "1f528",
            ShortName = "hammer",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛏",
            Code = "26cf",
            ShortName = "pick",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚒",
            Code = "2692",
            ShortName = "hammer and pick",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛠",
            Code = "1f6e0",
            ShortName = "hammer and wrench",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗡",
            Code = "1f5e1",
            ShortName = "dagger",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚔",
            Code = "2694",
            ShortName = "crossed swords",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔫",
            Code = "1f52b",
            ShortName = "pistol",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏹",
            Code = "1f3f9",
            ShortName = "bow and arrow",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛡",
            Code = "1f6e1",
            ShortName = "shield",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔧",
            Code = "1f527",
            ShortName = "wrench",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔩",
            Code = "1f529",
            ShortName = "nut and bolt",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚙",
            Code = "2699",
            ShortName = "gear",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗜",
            Code = "1f5dc",
            ShortName = "clamp",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚗",
            Code = "2697",
            ShortName = "alembic",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚖",
            Code = "2696",
            ShortName = "balance scale",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔗",
            Code = "1f517",
            ShortName = "link",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛓",
            Code = "26d3",
            ShortName = "chains",
            Category = "tool",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💉",
            Code = "1f489",
            ShortName = "syringe",
            Category = "medical",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💊",
            Code = "1f48a",
            ShortName = "pill",
            Category = "medical",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚬",
            Code = "1f6ac",
            ShortName = "cigarette",
            Category = "other-object",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚰",
            Code = "26b0",
            ShortName = "coffin",
            Category = "other-object",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚱",
            Code = "26b1",
            ShortName = "funeral urn",
            Category = "other-object",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🗿",
            Code = "1f5ff",
            ShortName = "moai",
            Category = "other-object",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛢",
            Code = "1f6e2",
            ShortName = "oil drum",
            Category = "other-object",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔮",
            Code = "1f52e",
            ShortName = "crystal ball",
            Category = "other-object",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛒",
            Code = "1f6d2",
            ShortName = "shopping cart",
            Category = "other-object",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏧",
            Code = "1f3e7",
            ShortName = "ATM sign",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚮",
            Code = "1f6ae",
            ShortName = "litter in bin sign",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚰",
            Code = "1f6b0",
            ShortName = "potable water",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♿",
            Code = "267f",
            ShortName = "wheelchair symbol",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚹",
            Code = "1f6b9",
            ShortName = "men’s room",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚺",
            Code = "1f6ba",
            ShortName = "women’s room",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚻",
            Code = "1f6bb",
            ShortName = "restroom",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚼",
            Code = "1f6bc",
            ShortName = "baby symbol",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚾",
            Code = "1f6be",
            ShortName = "water closet",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛂",
            Code = "1f6c2",
            ShortName = "passport control",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛃",
            Code = "1f6c3",
            ShortName = "customs",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛄",
            Code = "1f6c4",
            ShortName = "baggage claim",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛅",
            Code = "1f6c5",
            ShortName = "left luggage",
            Category = "transport-sign",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚠",
            Code = "26a0",
            ShortName = "warning",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚸",
            Code = "1f6b8",
            ShortName = "children crossing",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛔",
            Code = "26d4",
            ShortName = "no entry",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚫",
            Code = "1f6ab",
            ShortName = "prohibited",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚳",
            Code = "1f6b3",
            ShortName = "no bicycles",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚭",
            Code = "1f6ad",
            ShortName = "no smoking",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚯",
            Code = "1f6af",
            ShortName = "no littering",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚱",
            Code = "1f6b1",
            ShortName = "non-potable water",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚷",
            Code = "1f6b7",
            ShortName = "no pedestrians",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📵",
            Code = "1f4f5",
            ShortName = "no mobile phones",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔞",
            Code = "1f51e",
            ShortName = "no one under eighteen",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☢",
            Code = "2622",
            ShortName = "radioactive",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☣",
            Code = "2623",
            ShortName = "biohazard",
            Category = "warning",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⬆",
            Code = "2b06",
            ShortName = "up arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "↗",
            Code = "2197",
            ShortName = "up-right arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "➡",
            Code = "27a1",
            ShortName = "right arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "↘",
            Code = "2198",
            ShortName = "down-right arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⬇",
            Code = "2b07",
            ShortName = "down arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "↙",
            Code = "2199",
            ShortName = "down-left arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⬅",
            Code = "2b05",
            ShortName = "left arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "↖",
            Code = "2196",
            ShortName = "up-left arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "↕",
            Code = "2195",
            ShortName = "up-down arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "↔",
            Code = "2194",
            ShortName = "left-right arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "↩",
            Code = "21a9",
            ShortName = "right arrow curving left",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "↪",
            Code = "21aa",
            ShortName = "left arrow curving right",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⤴",
            Code = "2934",
            ShortName = "right arrow curving up",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⤵",
            Code = "2935",
            ShortName = "right arrow curving down",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔃",
            Code = "1f503",
            ShortName = "clockwise vertical arrows",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔄",
            Code = "1f504",
            ShortName = "anticlockwise arrows button",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔙",
            Code = "1f519",
            ShortName = "BACK arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔚",
            Code = "1f51a",
            ShortName = "END arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔛",
            Code = "1f51b",
            ShortName = "ON! arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔜",
            Code = "1f51c",
            ShortName = "SOON arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔝",
            Code = "1f51d",
            ShortName = "TOP arrow",
            Category = "arrow",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🛐",
            Code = "1f6d0",
            ShortName = "place of worship",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚛",
            Code = "269b",
            ShortName = "atom symbol",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕉",
            Code = "1f549",
            ShortName = "om",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✡",
            Code = "2721",
            ShortName = "star of David",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☸",
            Code = "2638",
            ShortName = "wheel of dharma",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☯",
            Code = "262f",
            ShortName = "yin yang",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✝",
            Code = "271d",
            ShortName = "latin cross",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☦",
            Code = "2626",
            ShortName = "orthodox cross",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☪",
            Code = "262a",
            ShortName = "star and crescent",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☮",
            Code = "262e",
            ShortName = "peace symbol",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🕎",
            Code = "1f54e",
            ShortName = "menorah",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔯",
            Code = "1f52f",
            ShortName = "dotted six-pointed star",
            Category = "religion",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♈",
            Code = "2648",
            ShortName = "Aries",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♉",
            Code = "2649",
            ShortName = "Taurus",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♊",
            Code = "264a",
            ShortName = "Gemini",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♋",
            Code = "264b",
            ShortName = "Cancer",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♌",
            Code = "264c",
            ShortName = "Leo",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♍",
            Code = "264d",
            ShortName = "Virgo",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♎",
            Code = "264e",
            ShortName = "Libra",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♏",
            Code = "264f",
            ShortName = "Scorpius",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♐",
            Code = "2650",
            ShortName = "Sagittarius",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♑",
            Code = "2651",
            ShortName = "Capricorn",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♒",
            Code = "2652",
            ShortName = "Aquarius",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♓",
            Code = "2653",
            ShortName = "Pisces",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⛎",
            Code = "26ce",
            ShortName = "Ophiuchus",
            Category = "zodiac",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔀",
            Code = "1f500",
            ShortName = "shuffle tracks button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔁",
            Code = "1f501",
            ShortName = "repeat button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔂",
            Code = "1f502",
            ShortName = "repeat single button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "▶",
            Code = "25b6",
            ShortName = "play button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏩",
            Code = "23e9",
            ShortName = "fast-forward button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏭",
            Code = "23ed",
            ShortName = "next track button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏯",
            Code = "23ef",
            ShortName = "play or pause button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "◀",
            Code = "25c0",
            ShortName = "reverse button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏪",
            Code = "23ea",
            ShortName = "fast reverse button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏮",
            Code = "23ee",
            ShortName = "last track button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔼",
            Code = "1f53c",
            ShortName = "up button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏫",
            Code = "23eb",
            ShortName = "fast up button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔽",
            Code = "1f53d",
            ShortName = "down button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏬",
            Code = "23ec",
            ShortName = "fast down button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏸",
            Code = "23f8",
            ShortName = "pause button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏹",
            Code = "23f9",
            ShortName = "stop button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏺",
            Code = "23fa",
            ShortName = "record button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⏏",
            Code = "23cf",
            ShortName = "eject button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎦",
            Code = "1f3a6",
            ShortName = "cinema",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔅",
            Code = "1f505",
            ShortName = "dim button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔆",
            Code = "1f506",
            ShortName = "bright button",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📶",
            Code = "1f4f6",
            ShortName = "antenna bars",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📳",
            Code = "1f4f3",
            ShortName = "vibration mode",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📴",
            Code = "1f4f4",
            ShortName = "mobile phone off",
            Category = "av-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♀",
            Code = "2640",
            ShortName = "female sign",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♂",
            Code = "2642",
            ShortName = "male sign",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚕",
            Code = "2695",
            ShortName = "medical symbol",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "♻",
            Code = "267b",
            ShortName = "recycling symbol",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚜",
            Code = "269c",
            ShortName = "fleur-de-lis",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔱",
            Code = "1f531",
            ShortName = "trident emblem",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "📛",
            Code = "1f4db",
            ShortName = "name badge",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔰",
            Code = "1f530",
            ShortName = "Japanese symbol for beginner",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⭕",
            Code = "2b55",
            ShortName = "heavy large circle",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✅",
            Code = "2705",
            ShortName = "white heavy check mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "☑",
            Code = "2611",
            ShortName = "ballot box with check",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✔",
            Code = "2714",
            ShortName = "heavy check mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✖",
            Code = "2716",
            ShortName = "heavy multiplication x",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❌",
            Code = "274c",
            ShortName = "cross mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❎",
            Code = "274e",
            ShortName = "cross mark button",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "➕",
            Code = "2795",
            ShortName = "heavy plus sign",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "➖",
            Code = "2796",
            ShortName = "heavy minus sign",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "➗",
            Code = "2797",
            ShortName = "heavy division sign",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "➰",
            Code = "27b0",
            ShortName = "curly loop",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "➿",
            Code = "27bf",
            ShortName = "double curly loop",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "",
            Code = "303d",
            ShortName = "part alternation mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✳",
            Code = "2733",
            ShortName = "eight-spoked asterisk",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "✴",
            Code = "2734",
            ShortName = "eight-pointed star",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❇",
            Code = "2747",
            ShortName = "sparkle",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "‼",
            Code = "203c",
            ShortName = "double exclamation mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⁉",
            Code = "2049",
            ShortName = "exclamation question mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❓",
            Code = "2753",
            ShortName = "question mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❔",
            Code = "2754",
            ShortName = "white question mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❕",
            Code = "2755",
            ShortName = "white exclamation mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "❗",
            Code = "2757",
            ShortName = "exclamation mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "〰",
            Code = "3030",
            ShortName = "wavy dash",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "©",
            Code = "00a9",
            ShortName = "copyright",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "®",
            Code = "00ae",
            ShortName = "registered",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "™",
            Code = "2122",
            ShortName = "trade mark",
            Category = "other-symbol",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "#️⃣",
            Code = "0023_fe0f_20e3",
            ShortName = "keycap: #",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "*️⃣",
            Code = "002a_fe0f_20e3",
            ShortName = "keycap: *",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "0️⃣",
            Code = "0030_fe0f_20e3",
            ShortName = "keycap: 0",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "1️⃣",
            Code = "0031_fe0f_20e3",
            ShortName = "keycap: 1",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "2️⃣",
            Code = "0032_fe0f_20e3",
            ShortName = "keycap: 2",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "3️⃣",
            Code = "0033_fe0f_20e3",
            ShortName = "keycap: 3",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "4️⃣",
            Code = "0034_fe0f_20e3",
            ShortName = "keycap: 4",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "5️⃣",
            Code = "0035_fe0f_20e3",
            ShortName = "keycap: 5",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "6️⃣",
            Code = "0036_fe0f_20e3",
            ShortName = "keycap: 6",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "7️⃣",
            Code = "0037_fe0f_20e3",
            ShortName = "keycap: 7",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "8️⃣",
            Code = "0038_fe0f_20e3",
            ShortName = "keycap: 8",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "9️⃣",
            Code = "0039_fe0f_20e3",
            ShortName = "keycap: 9",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔟",
            Code = "1f51f",
            ShortName = "keycap 10",
            Category = "keycap",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💯",
            Code = "1f4af",
            ShortName = "hundred points",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔠",
            Code = "1f520",
            ShortName = "input latin uppercase",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔡",
            Code = "1f521",
            ShortName = "input latin lowercase",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔢",
            Code = "1f522",
            ShortName = "input numbers",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔣",
            Code = "1f523",
            ShortName = "input symbols",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔤",
            Code = "1f524",
            ShortName = "input latin letters",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🅰",
            Code = "1f170",
            ShortName = "A button (blood type)",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆎",
            Code = "1f18e",
            ShortName = "AB button (blood type)",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🅱",
            Code = "1f171",
            ShortName = "B button (blood type)",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆑",
            Code = "1f191",
            ShortName = "CL button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆒",
            Code = "1f192",
            ShortName = "COOL button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆓",
            Code = "1f193",
            ShortName = "FREE button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "ℹ",
            Code = "2139",
            ShortName = "information",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆔",
            Code = "1f194",
            ShortName = "ID button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "Ⓜ",
            Code = "24c2",
            ShortName = "circled M",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆕",
            Code = "1f195",
            ShortName = "NEW button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆖",
            Code = "1f196",
            ShortName = "NG button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🅾",
            Code = "1f17e",
            ShortName = "O button (blood type)",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆗",
            Code = "1f197",
            ShortName = "OK button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🅿",
            Code = "1f17f",
            ShortName = "P button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆘",
            Code = "1f198",
            ShortName = "SOS button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆙",
            Code = "1f199",
            ShortName = "UP! button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🆚",
            Code = "1f19a",
            ShortName = "VS button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈁",
            Code = "1f201",
            ShortName = "Japanese “here” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈂",
            Code = "1f202",
            ShortName = "Japanese “service charge” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈷",
            Code = "1f237",
            ShortName = "Japanese “monthly amount” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈶",
            Code = "1f236",
            ShortName = "Japanese “not free of charge” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈯",
            Code = "1f22f",
            ShortName = "Japanese “reserved” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🉐",
            Code = "1f250",
            ShortName = "Japanese “bargain” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈹",
            Code = "1f239",
            ShortName = "Japanese “discount” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈚",
            Code = "1f21a",
            ShortName = "Japanese “free of charge” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈲",
            Code = "1f232",
            ShortName = "Japanese “prohibited” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🉑",
            Code = "1f251",
            ShortName = "Japanese “acceptable” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈸",
            Code = "1f238",
            ShortName = "Japanese “application” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈴",
            Code = "1f234",
            ShortName = "Japanese “passing grade” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈳",
            Code = "1f233",
            ShortName = "Japanese “vacancy” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "㊗",
            Code = "3297",
            ShortName = "Japanese “congratulations” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "㊙",
            Code = "3299",
            ShortName = "Japanese “secret” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈺",
            Code = "1f23a",
            ShortName = "Japanese “open for business” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🈵",
            Code = "1f235",
            ShortName = "Japanese “no vacancy” button",
            Category = "alphanum",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "▪",
            Code = "25aa",
            ShortName = "black small square",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "▫",
            Code = "25ab",
            ShortName = "white small square",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "◻",
            Code = "25fb",
            ShortName = "white medium square",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "◼",
            Code = "25fc",
            ShortName = "black medium square",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "◽",
            Code = "25fd",
            ShortName = "white medium-small square",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "◾",
            Code = "25fe",
            ShortName = "black medium-small square",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⬛",
            Code = "2b1b",
            ShortName = "black large square",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⬜",
            Code = "2b1c",
            ShortName = "white large square",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔶",
            Code = "1f536",
            ShortName = "large orange diamond",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔷",
            Code = "1f537",
            ShortName = "large blue diamond",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔸",
            Code = "1f538",
            ShortName = "small orange diamond",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔹",
            Code = "1f539",
            ShortName = "small blue diamond",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔺",
            Code = "1f53a",
            ShortName = "red triangle pointed up",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔻",
            Code = "1f53b",
            ShortName = "red triangle pointed down",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "💠",
            Code = "1f4a0",
            ShortName = "diamond with a dot",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔘",
            Code = "1f518",
            ShortName = "radio button",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔲",
            Code = "1f532",
            ShortName = "black square button",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔳",
            Code = "1f533",
            ShortName = "white square button",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚪",
            Code = "26aa",
            ShortName = "white circle",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "⚫",
            Code = "26ab",
            ShortName = "black circle",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔴",
            Code = "1f534",
            ShortName = "red circle",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🔵",
            Code = "1f535",
            ShortName = "blue circle",
            Category = "geometric",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏁",
            Code = "1f3c1",
            ShortName = "chequered flag",
            Category = "flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🚩",
            Code = "1f6a9",
            ShortName = "triangular flag",
            Category = "flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🎌",
            Code = "1f38c",
            ShortName = "crossed flags",
            Category = "flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏴",
            Code = "1f3f4",
            ShortName = "black flag",
            Category = "flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏳",
            Code = "1f3f3",
            ShortName = "white flag",
            Category = "flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏳️‍🌈",
            Code = "1f3f3_fe0f_200d_1f308",
            ShortName = "rainbow flag",
            Category = "flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇨",
            Code = "1f1e6_1f1e8",
            ShortName = "Ascension Island",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇩",
            Code = "1f1e6_1f1e9",
            ShortName = "Andorra",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇪",
            Code = "1f1e6_1f1ea",
            ShortName = "United Arab Emirates",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇫",
            Code = "1f1e6_1f1eb",
            ShortName = "Afghanistan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇬",
            Code = "1f1e6_1f1ec",
            ShortName = "Antigua &amp; Barbuda",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇮",
            Code = "1f1e6_1f1ee",
            ShortName = "Anguilla",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇱",
            Code = "1f1e6_1f1f1",
            ShortName = "Albania",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇲",
            Code = "1f1e6_1f1f2",
            ShortName = "Armenia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇴",
            Code = "1f1e6_1f1f4",
            ShortName = "Angola",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇶",
            Code = "1f1e6_1f1f6",
            ShortName = "Antarctica",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇷",
            Code = "1f1e6_1f1f7",
            ShortName = "Argentina",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇸",
            Code = "1f1e6_1f1f8",
            ShortName = "American Samoa",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇹",
            Code = "1f1e6_1f1f9",
            ShortName = "Austria",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇺",
            Code = "1f1e6_1f1fa",
            ShortName = "Australia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇼",
            Code = "1f1e6_1f1fc",
            ShortName = "Aruba",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇽",
            Code = "1f1e6_1f1fd",
            ShortName = "Åland Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇦🇿",
            Code = "1f1e6_1f1ff",
            ShortName = "Azerbaijan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇦",
            Code = "1f1e7_1f1e6",
            ShortName = "Bosnia &amp; Herzegovina",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇧",
            Code = "1f1e7_1f1e7",
            ShortName = "Barbados",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇩",
            Code = "1f1e7_1f1e9",
            ShortName = "Bangladesh",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇪",
            Code = "1f1e7_1f1ea",
            ShortName = "Belgium",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇫",
            Code = "1f1e7_1f1eb",
            ShortName = "Burkina Faso",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇬",
            Code = "1f1e7_1f1ec",
            ShortName = "Bulgaria",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇭",
            Code = "1f1e7_1f1ed",
            ShortName = "Bahrain",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇮",
            Code = "1f1e7_1f1ee",
            ShortName = "Burundi",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇯",
            Code = "1f1e7_1f1ef",
            ShortName = "Benin",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇱",
            Code = "1f1e7_1f1f1",
            ShortName = "St. Barthélemy",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇲",
            Code = "1f1e7_1f1f2",
            ShortName = "Bermuda",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇳",
            Code = "1f1e7_1f1f3",
            ShortName = "Brunei",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇴",
            Code = "1f1e7_1f1f4",
            ShortName = "Bolivia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇶",
            Code = "1f1e7_1f1f6",
            ShortName = "Caribbean Netherlands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇷",
            Code = "1f1e7_1f1f7",
            ShortName = "Brazil",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇸",
            Code = "1f1e7_1f1f8",
            ShortName = "Bahamas",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇹",
            Code = "1f1e7_1f1f9",
            ShortName = "Bhutan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇻",
            Code = "1f1e7_1f1fb",
            ShortName = "Bouvet Island",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇼",
            Code = "1f1e7_1f1fc",
            ShortName = "Botswana",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇾",
            Code = "1f1e7_1f1fe",
            ShortName = "Belarus",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇧🇿",
            Code = "1f1e7_1f1ff",
            ShortName = "Belize",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇦",
            Code = "1f1e8_1f1e6",
            ShortName = "Canada",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇨",
            Code = "1f1e8_1f1e8",
            ShortName = "Cocos (Keeling) Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇩",
            Code = "1f1e8_1f1e9",
            ShortName = "Congo - Kinshasa",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇫",
            Code = "1f1e8_1f1eb",
            ShortName = "Central African Republic",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇬",
            Code = "1f1e8_1f1ec",
            ShortName = "Congo - Brazzaville",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇭",
            Code = "1f1e8_1f1ed",
            ShortName = "Switzerland",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇮",
            Code = "1f1e8_1f1ee",
            ShortName = "Côte d’Ivoire",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇰",
            Code = "1f1e8_1f1f0",
            ShortName = "Cook Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇱",
            Code = "1f1e8_1f1f1",
            ShortName = "Chile",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇲",
            Code = "1f1e8_1f1f2",
            ShortName = "Cameroon",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇳",
            Code = "1f1e8_1f1f3",
            ShortName = "China",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇴",
            Code = "1f1e8_1f1f4",
            ShortName = "Colombia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇵",
            Code = "1f1e8_1f1f5",
            ShortName = "Clipperton Island",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇷",
            Code = "1f1e8_1f1f7",
            ShortName = "Costa Rica",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇺",
            Code = "1f1e8_1f1fa",
            ShortName = "Cuba",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇻",
            Code = "1f1e8_1f1fb",
            ShortName = "Cape Verde",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇼",
            Code = "1f1e8_1f1fc",
            ShortName = "Curaçao",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇽",
            Code = "1f1e8_1f1fd",
            ShortName = "Christmas Island",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇾",
            Code = "1f1e8_1f1fe",
            ShortName = "Cyprus",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇨🇿",
            Code = "1f1e8_1f1ff",
            ShortName = "Czechia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇩🇪",
            Code = "1f1e9_1f1ea",
            ShortName = "Germany",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇩🇬",
            Code = "1f1e9_1f1ec",
            ShortName = "Diego Garcia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇩🇯",
            Code = "1f1e9_1f1ef",
            ShortName = "Djibouti",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇩🇰",
            Code = "1f1e9_1f1f0",
            ShortName = "Denmark",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇩🇲",
            Code = "1f1e9_1f1f2",
            ShortName = "Dominica",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇩🇴",
            Code = "1f1e9_1f1f4",
            ShortName = "Dominican Republic",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇩🇿",
            Code = "1f1e9_1f1ff",
            ShortName = "Algeria",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇦",
            Code = "1f1ea_1f1e6",
            ShortName = "Ceuta &amp; Melilla",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇨",
            Code = "1f1ea_1f1e8",
            ShortName = "Ecuador",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇪",
            Code = "1f1ea_1f1ea",
            ShortName = "Estonia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇬",
            Code = "1f1ea_1f1ec",
            ShortName = "Egypt",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇭",
            Code = "1f1ea_1f1ed",
            ShortName = "Western Sahara",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇷",
            Code = "1f1ea_1f1f7",
            ShortName = "Eritrea",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇸",
            Code = "1f1ea_1f1f8",
            ShortName = "Spain",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇹",
            Code = "1f1ea_1f1f9",
            ShortName = "Ethiopia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇪🇺",
            Code = "1f1ea_1f1fa",
            ShortName = "European Union",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇫🇮",
            Code = "1f1eb_1f1ee",
            ShortName = "Finland",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇫🇯",
            Code = "1f1eb_1f1ef",
            ShortName = "Fiji",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇫🇰",
            Code = "1f1eb_1f1f0",
            ShortName = "Falkland Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇫🇲",
            Code = "1f1eb_1f1f2",
            ShortName = "Micronesia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇫🇴",
            Code = "1f1eb_1f1f4",
            ShortName = "Faroe Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇫🇷",
            Code = "1f1eb_1f1f7",
            ShortName = "France",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇦",
            Code = "1f1ec_1f1e6",
            ShortName = "Gabon",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇧",
            Code = "1f1ec_1f1e7",
            ShortName = "United Kingdom",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇩",
            Code = "1f1ec_1f1e9",
            ShortName = "Grenada",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇪",
            Code = "1f1ec_1f1ea",
            ShortName = "Georgia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇫",
            Code = "1f1ec_1f1eb",
            ShortName = "French Guiana",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇬",
            Code = "1f1ec_1f1ec",
            ShortName = "Guernsey",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇭",
            Code = "1f1ec_1f1ed",
            ShortName = "Ghana",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇮",
            Code = "1f1ec_1f1ee",
            ShortName = "Gibraltar",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇱",
            Code = "1f1ec_1f1f1",
            ShortName = "Greenland",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇲",
            Code = "1f1ec_1f1f2",
            ShortName = "Gambia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇳",
            Code = "1f1ec_1f1f3",
            ShortName = "Guinea",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇵",
            Code = "1f1ec_1f1f5",
            ShortName = "Guadeloupe",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇶",
            Code = "1f1ec_1f1f6",
            ShortName = "Equatorial Guinea",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇷",
            Code = "1f1ec_1f1f7",
            ShortName = "Greece",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇸",
            Code = "1f1ec_1f1f8",
            ShortName = "South Georgia &amp; South Sandwich Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇹",
            Code = "1f1ec_1f1f9",
            ShortName = "Guatemala",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇺",
            Code = "1f1ec_1f1fa",
            ShortName = "Guam",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇼",
            Code = "1f1ec_1f1fc",
            ShortName = "Guinea-Bissau",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇬🇾",
            Code = "1f1ec_1f1fe",
            ShortName = "Guyana",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇭🇰",
            Code = "1f1ed_1f1f0",
            ShortName = "Hong Kong SAR China",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇭🇲",
            Code = "1f1ed_1f1f2",
            ShortName = "Heard &amp; McDonald Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇭🇳",
            Code = "1f1ed_1f1f3",
            ShortName = "Honduras",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇭🇷",
            Code = "1f1ed_1f1f7",
            ShortName = "Croatia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇭🇹",
            Code = "1f1ed_1f1f9",
            ShortName = "Haiti",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇭🇺",
            Code = "1f1ed_1f1fa",
            ShortName = "Hungary",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇨",
            Code = "1f1ee_1f1e8",
            ShortName = "Canary Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇩",
            Code = "1f1ee_1f1e9",
            ShortName = "Indonesia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇪",
            Code = "1f1ee_1f1ea",
            ShortName = "Ireland",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇱",
            Code = "1f1ee_1f1f1",
            ShortName = "Israel",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇲",
            Code = "1f1ee_1f1f2",
            ShortName = "Isle of Man",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇳",
            Code = "1f1ee_1f1f3",
            ShortName = "India",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇴",
            Code = "1f1ee_1f1f4",
            ShortName = "British Indian Ocean Territory",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇶",
            Code = "1f1ee_1f1f6",
            ShortName = "Iraq",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇷",
            Code = "1f1ee_1f1f7",
            ShortName = "Iran",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇸",
            Code = "1f1ee_1f1f8",
            ShortName = "Iceland",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇮🇹",
            Code = "1f1ee_1f1f9",
            ShortName = "Italy",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇯🇪",
            Code = "1f1ef_1f1ea",
            ShortName = "Jersey",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇯🇲",
            Code = "1f1ef_1f1f2",
            ShortName = "Jamaica",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇯🇴",
            Code = "1f1ef_1f1f4",
            ShortName = "Jordan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇯🇵",
            Code = "1f1ef_1f1f5",
            ShortName = "Japan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇪",
            Code = "1f1f0_1f1ea",
            ShortName = "Kenya",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇬",
            Code = "1f1f0_1f1ec",
            ShortName = "Kyrgyzstan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇭",
            Code = "1f1f0_1f1ed",
            ShortName = "Cambodia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇮",
            Code = "1f1f0_1f1ee",
            ShortName = "Kiribati",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇲",
            Code = "1f1f0_1f1f2",
            ShortName = "Comoros",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇳",
            Code = "1f1f0_1f1f3",
            ShortName = "St. Kitts &amp; Nevis",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇵",
            Code = "1f1f0_1f1f5",
            ShortName = "North Korea",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇷",
            Code = "1f1f0_1f1f7",
            ShortName = "South Korea",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇼",
            Code = "1f1f0_1f1fc",
            ShortName = "Kuwait",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇾",
            Code = "1f1f0_1f1fe",
            ShortName = "Cayman Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇰🇿",
            Code = "1f1f0_1f1ff",
            ShortName = "Kazakhstan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇦",
            Code = "1f1f1_1f1e6",
            ShortName = "Laos",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇧",
            Code = "1f1f1_1f1e7",
            ShortName = "Lebanon",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇨",
            Code = "1f1f1_1f1e8",
            ShortName = "St. Lucia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇮",
            Code = "1f1f1_1f1ee",
            ShortName = "Liechtenstein",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇰",
            Code = "1f1f1_1f1f0",
            ShortName = "Sri Lanka",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇷",
            Code = "1f1f1_1f1f7",
            ShortName = "Liberia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇸",
            Code = "1f1f1_1f1f8",
            ShortName = "Lesotho",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇹",
            Code = "1f1f1_1f1f9",
            ShortName = "Lithuania",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇺",
            Code = "1f1f1_1f1fa",
            ShortName = "Luxembourg",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇻",
            Code = "1f1f1_1f1fb",
            ShortName = "Latvia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇱🇾",
            Code = "1f1f1_1f1fe",
            ShortName = "Libya",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇦",
            Code = "1f1f2_1f1e6",
            ShortName = "Morocco",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇨",
            Code = "1f1f2_1f1e8",
            ShortName = "Monaco",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇩",
            Code = "1f1f2_1f1e9",
            ShortName = "Moldova",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇪",
            Code = "1f1f2_1f1ea",
            ShortName = "Montenegro",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇫",
            Code = "1f1f2_1f1eb",
            ShortName = "St. Martin",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇬",
            Code = "1f1f2_1f1ec",
            ShortName = "Madagascar",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇭",
            Code = "1f1f2_1f1ed",
            ShortName = "Marshall Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇰",
            Code = "1f1f2_1f1f0",
            ShortName = "Macedonia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇱",
            Code = "1f1f2_1f1f1",
            ShortName = "Mali",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇲",
            Code = "1f1f2_1f1f2",
            ShortName = "Myanmar (Burma)",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇳",
            Code = "1f1f2_1f1f3",
            ShortName = "Mongolia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇴",
            Code = "1f1f2_1f1f4",
            ShortName = "Macau SAR China",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇵",
            Code = "1f1f2_1f1f5",
            ShortName = "Northern Mariana Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇶",
            Code = "1f1f2_1f1f6",
            ShortName = "Martinique",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇷",
            Code = "1f1f2_1f1f7",
            ShortName = "Mauritania",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇸",
            Code = "1f1f2_1f1f8",
            ShortName = "Montserrat",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇹",
            Code = "1f1f2_1f1f9",
            ShortName = "Malta",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇺",
            Code = "1f1f2_1f1fa",
            ShortName = "Mauritius",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇻",
            Code = "1f1f2_1f1fb",
            ShortName = "Maldives",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇼",
            Code = "1f1f2_1f1fc",
            ShortName = "Malawi",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇽",
            Code = "1f1f2_1f1fd",
            ShortName = "Mexico",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇾",
            Code = "1f1f2_1f1fe",
            ShortName = "Malaysia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇲🇿",
            Code = "1f1f2_1f1ff",
            ShortName = "Mozambique",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇦",
            Code = "1f1f3_1f1e6",
            ShortName = "Namibia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇨",
            Code = "1f1f3_1f1e8",
            ShortName = "New Caledonia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇪",
            Code = "1f1f3_1f1ea",
            ShortName = "Niger",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇫",
            Code = "1f1f3_1f1eb",
            ShortName = "Norfolk Island",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇬",
            Code = "1f1f3_1f1ec",
            ShortName = "Nigeria",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇮",
            Code = "1f1f3_1f1ee",
            ShortName = "Nicaragua",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇱",
            Code = "1f1f3_1f1f1",
            ShortName = "Netherlands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇴",
            Code = "1f1f3_1f1f4",
            ShortName = "Norway",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇵",
            Code = "1f1f3_1f1f5",
            ShortName = "Nepal",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇷",
            Code = "1f1f3_1f1f7",
            ShortName = "Nauru",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇺",
            Code = "1f1f3_1f1fa",
            ShortName = "Niue",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇳🇿",
            Code = "1f1f3_1f1ff",
            ShortName = "New Zealand",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇴🇲",
            Code = "1f1f4_1f1f2",
            ShortName = "Oman",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇦",
            Code = "1f1f5_1f1e6",
            ShortName = "Panama",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇪",
            Code = "1f1f5_1f1ea",
            ShortName = "Peru",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇫",
            Code = "1f1f5_1f1eb",
            ShortName = "French Polynesia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇬",
            Code = "1f1f5_1f1ec",
            ShortName = "Papua New Guinea",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇭",
            Code = "1f1f5_1f1ed",
            ShortName = "Philippines",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇰",
            Code = "1f1f5_1f1f0",
            ShortName = "Pakistan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇱",
            Code = "1f1f5_1f1f1",
            ShortName = "Poland",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇲",
            Code = "1f1f5_1f1f2",
            ShortName = "St. Pierre &amp; Miquelon",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇳",
            Code = "1f1f5_1f1f3",
            ShortName = "Pitcairn Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇷",
            Code = "1f1f5_1f1f7",
            ShortName = "Puerto Rico",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇸",
            Code = "1f1f5_1f1f8",
            ShortName = "Palestinian Territories",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇹",
            Code = "1f1f5_1f1f9",
            ShortName = "Portugal",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇼",
            Code = "1f1f5_1f1fc",
            ShortName = "Palau",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇵🇾",
            Code = "1f1f5_1f1fe",
            ShortName = "Paraguay",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇶🇦",
            Code = "1f1f6_1f1e6",
            ShortName = "Qatar",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇷🇪",
            Code = "1f1f7_1f1ea",
            ShortName = "Réunion",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇷🇴",
            Code = "1f1f7_1f1f4",
            ShortName = "Romania",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇷🇸",
            Code = "1f1f7_1f1f8",
            ShortName = "Serbia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇷🇺",
            Code = "1f1f7_1f1fa",
            ShortName = "Russia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇷🇼",
            Code = "1f1f7_1f1fc",
            ShortName = "Rwanda",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇦",
            Code = "1f1f8_1f1e6",
            ShortName = "Saudi Arabia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇧",
            Code = "1f1f8_1f1e7",
            ShortName = "Solomon Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇨",
            Code = "1f1f8_1f1e8",
            ShortName = "Seychelles",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇩",
            Code = "1f1f8_1f1e9",
            ShortName = "Sudan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇪",
            Code = "1f1f8_1f1ea",
            ShortName = "Sweden",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇬",
            Code = "1f1f8_1f1ec",
            ShortName = "Singapore",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇭",
            Code = "1f1f8_1f1ed",
            ShortName = "St. Helena",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇮",
            Code = "1f1f8_1f1ee",
            ShortName = "Slovenia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇯",
            Code = "1f1f8_1f1ef",
            ShortName = "Svalbard &amp; Jan Mayen",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇰",
            Code = "1f1f8_1f1f0",
            ShortName = "Slovakia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇱",
            Code = "1f1f8_1f1f1",
            ShortName = "Sierra Leone",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇲",
            Code = "1f1f8_1f1f2",
            ShortName = "San Marino",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇳",
            Code = "1f1f8_1f1f3",
            ShortName = "Senegal",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇴",
            Code = "1f1f8_1f1f4",
            ShortName = "Somalia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇷",
            Code = "1f1f8_1f1f7",
            ShortName = "Suriname",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇸",
            Code = "1f1f8_1f1f8",
            ShortName = "South Sudan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇹",
            Code = "1f1f8_1f1f9",
            ShortName = "São Tomé &amp; Príncipe",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇻",
            Code = "1f1f8_1f1fb",
            ShortName = "El Salvador",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇽",
            Code = "1f1f8_1f1fd",
            ShortName = "Sint Maarten",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇾",
            Code = "1f1f8_1f1fe",
            ShortName = "Syria",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇸🇿",
            Code = "1f1f8_1f1ff",
            ShortName = "Swaziland",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇦",
            Code = "1f1f9_1f1e6",
            ShortName = "Tristan da Cunha",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇨",
            Code = "1f1f9_1f1e8",
            ShortName = "Turks &amp; Caicos Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇩",
            Code = "1f1f9_1f1e9",
            ShortName = "Chad",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇫",
            Code = "1f1f9_1f1eb",
            ShortName = "French Southern Territories",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇬",
            Code = "1f1f9_1f1ec",
            ShortName = "Togo",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇭",
            Code = "1f1f9_1f1ed",
            ShortName = "Thailand",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇯",
            Code = "1f1f9_1f1ef",
            ShortName = "Tajikistan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇰",
            Code = "1f1f9_1f1f0",
            ShortName = "Tokelau",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇱",
            Code = "1f1f9_1f1f1",
            ShortName = "Timor-Leste",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇲",
            Code = "1f1f9_1f1f2",
            ShortName = "Turkmenistan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇳",
            Code = "1f1f9_1f1f3",
            ShortName = "Tunisia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇴",
            Code = "1f1f9_1f1f4",
            ShortName = "Tonga",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇷",
            Code = "1f1f9_1f1f7",
            ShortName = "Turkey",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇹",
            Code = "1f1f9_1f1f9",
            ShortName = "Trinidad &amp; Tobago",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇻",
            Code = "1f1f9_1f1fb",
            ShortName = "Tuvalu",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇼",
            Code = "1f1f9_1f1fc",
            ShortName = "Taiwan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇹🇿",
            Code = "1f1f9_1f1ff",
            ShortName = "Tanzania",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇺🇦",
            Code = "1f1fa_1f1e6",
            ShortName = "Ukraine",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇺🇬",
            Code = "1f1fa_1f1ec",
            ShortName = "Uganda",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇺🇲",
            Code = "1f1fa_1f1f2",
            ShortName = "U.S. Outlying Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇺🇳",
            Code = "1f1fa_1f1f3",
            ShortName = "United Nations",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇺🇸",
            Code = "1f1fa_1f1f8",
            ShortName = "United States",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇺🇾",
            Code = "1f1fa_1f1fe",
            ShortName = "Uruguay",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇺🇿",
            Code = "1f1fa_1f1ff",
            ShortName = "Uzbekistan",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇻🇦",
            Code = "1f1fb_1f1e6",
            ShortName = "Vatican City",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇻🇨",
            Code = "1f1fb_1f1e8",
            ShortName = "St. Vincent &amp; Grenadines",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇻🇪",
            Code = "1f1fb_1f1ea",
            ShortName = "Venezuela",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇻🇬",
            Code = "1f1fb_1f1ec",
            ShortName = "British Virgin Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇻🇮",
            Code = "1f1fb_1f1ee",
            ShortName = "U.S. Virgin Islands",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇻🇳",
            Code = "1f1fb_1f1f3",
            ShortName = "Vietnam",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇻🇺",
            Code = "1f1fb_1f1fa",
            ShortName = "Vanuatu",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇼🇫",
            Code = "1f1fc_1f1eb",
            ShortName = "Wallis &amp; Futuna",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇼🇸",
            Code = "1f1fc_1f1f8",
            ShortName = "Samoa",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇽🇰",
            Code = "1f1fd_1f1f0",
            ShortName = "Kosovo",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇾🇪",
            Code = "1f1fe_1f1ea",
            ShortName = "Yemen",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇾🇹",
            Code = "1f1fe_1f1f9",
            ShortName = "Mayotte",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇿🇦",
            Code = "1f1ff_1f1e6",
            ShortName = "South Africa",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇿🇲",
            Code = "1f1ff_1f1f2",
            ShortName = "Zambia",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🇿🇼",
            Code = "1f1ff_1f1fc",
            ShortName = "Zimbabwe",
            Category = "country-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏴󠁧󠁢󠁥󠁮󠁧󠁿",
            Code = "1f3f4_e0067_e0062_e0065_e006e_e0067_e007f",
            ShortName = "England",
            Category = "subdivision-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏴󠁧󠁢󠁳󠁣󠁴󠁿",
            Code = "1f3f4_e0067_e0062_e0073_e0063_e0074_e007f",
            ShortName = "Scotland",
            Category = "subdivision-flag",
        });

        emojis.Add(new Emoji()
        {
            EmojiAsUnicode = "🏴󠁧󠁢󠁷󠁬󠁳󠁿",
            Code = "1f3f4_e0067_e0062_e0077_e006c_e0073_e007f",
            ShortName = "Wales",
            Category = "subdivision-flag",
        });

    }
}

public class Emoji
{
    private string emojiAsUnicode = "";
    private string code = "";
    private string shortName = "";
    private string category = "";

    public string EmojiAsUnicode { get => this.emojiAsUnicode; set => this.emojiAsUnicode = value; }
    public string Code { get => this.code; set => this.code = value; }
    public string ShortName { get => this.shortName; set => this.shortName = value; }
    public string Category { get => this.category; set => this.category = value; }
}